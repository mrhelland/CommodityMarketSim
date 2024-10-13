using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketFrameworkLibrary;
using System.IO;

namespace CommodityMarketSim {
    public partial class MainForm : Form {

        private int currentround;

        public MainForm() {
            InitializeComponent();
            DirectoryInfo exeDirectory = new FileInfo(Application.ExecutablePath).Directory;
            string imagesPath = Path.Combine(exeDirectory.FullName, "Images");
            Commodity.BuildImageList(new DirectoryInfo(imagesPath));

        }

        private void MainForm_Load(object sender, EventArgs e) {
            currentround = 1;
            MarketSetup ms = new MarketSetup();
            if(ms.ShowDialog() == DialogResult.OK) {
                LoadTeams();
                LoadCommodities();
            }
        }

        private void btnNextRound_Click(object sender, EventArgs e) {
            PurchaseRound temp = new PurchaseRound(currentround);
            PurchaseRoundForm form = new PurchaseRoundForm();
           
            form.Round = temp;
            form.ShowDialog();
            currentround += 1;
        }

        private void LoadTeams() {
            tlpTeams.ColumnStyles.Clear();
            tlpTeams.ColumnCount = Market.Instance.TeamList.Length;
            tlpTeams.RowCount = 1;
            tlpTeams.RowStyles.Clear();
            tlpTeams.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            int column = 0 ;
            foreach(Team t in Market.Instance.TeamList) {
                tlpTeams.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / Market.Instance.TeamList.Length));
                TeamDisplay temp = new TeamDisplay();
                temp.Team = t;
                temp.ShowDropBox = false;
                temp.Pending = null;
                temp.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
                tlpTeams.Controls.Add(temp, column, 1);
                column++;
            }
        }

        private void LoadCommodities() {
            tlpCommodities.ColumnStyles.Clear();
            tlpCommodities.ColumnCount = (int)Math.Ceiling(Market.Instance.Commodities.Count / 3.0);
            tlpCommodities.RowCount = 3;
            tlpCommodities.RowStyles.Clear();
            tlpCommodities.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33f));
            for(int i = 0; i < tlpCommodities.ColumnCount; i++) {
                tlpCommodities.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0f / tlpCommodities.ColumnCount));
            }
            for(int i = 0; i < tlpCommodities.RowCount; i++) {
                tlpCommodities.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f / tlpCommodities.RowCount));
            }
            int column = 0;
            int row = 0;
            foreach(Commodity c in Market.Instance.Commodities) {
                CommodityDisplay temp = new CommodityDisplay();
                temp.Commodity = c;
                temp.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
                tlpCommodities.Controls.Add(temp, column, row);
                column++;
                if(column >= tlpCommodities.ColumnCount) {
                    column = 0;
                    row++;
                }
            }
        }

        private void btnFinish_Click(object sender, EventArgs e) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            DialogResult result = fbd.ShowDialog();
            if(result == DialogResult.OK || result == DialogResult.Yes) {
                foreach(Team t in Market.Instance.TeamList) {
                    StreamWriter sw = new StreamWriter(Path.Combine(fbd.SelectedPath, t.Name + ".html"));
                    sw.Write(t.GetHTML());
                    sw.Close();
                }
            } else {
                MessageBox.Show(this, "No results were saved.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            if(String.IsNullOrEmpty(Properties.Settings.Default.LastSavePath)) {
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            } else {
                sfd.InitialDirectory = Properties.Settings.Default.LastSavePath;
            }
            sfd.DefaultExt = "xml";
            sfd.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            if(sfd.ShowDialog() == DialogResult.OK) {
                Market.Instance.Save(sfd.FileName);
                Properties.Settings.Default.LastSavePath = sfd.FileName;
            }
        }

        
    }
}
