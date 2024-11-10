using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketFrameworkLibrary;

namespace CommodityMarketSim {
    public partial class MarketSetup : Form {

        private List<Commodity> commodityList;
        private BindingSource commoditySource;
        private DataGridViewColumn columnName;
        private DataGridViewColumn columnAvailable;
        private DataGridViewColumn columnPrice;
        private DataGridViewColumn columnImage;

        private Market market;
        public Market Market {
            get => market;
            set {
                market = value;
                updateControlValues();
            }
        }

        public MarketSetup() {
            InitializeComponent();
            bindCommodityGrid();
        }

        private void bindCommodityGrid() {
            commoditySource = new BindingSource();
            commoditySource.AllowNew = true;
            if(market == null) {
                commodityList = new List<Commodity>();
                commodityList.AddRange(Commodity.DefaultCommodityList);
                commoditySource.DataSource = commodityList;
            }
            else {
                commoditySource.DataSource = this.market.Commodities;
            }

            dgvCommodities.Font = new Font(this.Font.FontFamily, 12);
            dgvCommodities.AllowUserToAddRows = true;            
            dgvCommodities.DefaultCellStyle.Font = new Font(this.Font.FontFamily, 12);
            dgvCommodities.RowTemplate.Height = 32;
            dgvCommodities.DataSource = null;
            dgvCommodities.DataSource = commoditySource;

            foreach(DataGridViewColumn c in dgvCommodities.Columns) {
                string propertyName = c.DataPropertyName.ToLower();
                if(propertyName.ToLower().Contains("pending") || propertyName.ToLower().Contains("imagename")) {
                    c.Visible = false;
                }
                else if(propertyName.ToLower().Contains("name")) {
                    columnName = c;
                    c.Width = 256;
                    c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
                else if(propertyName.ToLower().Contains("image")) {
                    columnImage = c;
                    c.Width = 64;
                    c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    c.ValueType = typeof(Image);
                    DataGridViewImageColumn imgCol = (DataGridViewImageColumn)c;
                    imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    imgCol.Image = (Image)Properties.Resources.ResourceManager.GetObject("placeholder");
                }
                else if(propertyName.ToLower().Contains("price")) {
                    NumberFormatInfo format = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
                    format.CurrencySymbol = this.txtMonetarySymbol.Text;
                    format.CurrencyDecimalDigits = 0;
                    columnPrice = c;
                    c.Width = 128;
                    c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    c.DefaultCellStyle.FormatProvider = format;
                    c.DefaultCellStyle.Format = "c";
                }
                else if(propertyName.ToLower().Contains("available")) {
                    columnAvailable = c;
                    c.Width = 128;
                    c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }

        private void MarketSetup_Load(object sender, EventArgs e) {
            updateControlValues();
            bindCommodityGrid();
        }

        private void updateControlValues() {
            if(this.market == null) {
                this.numTeamQuantity.Value = Properties.Settings.Default.TeamQuantity;
                this.txtMonetarySymbol.Text = Properties.Settings.Default.MonetarySymbol;
                this.numTeamBudget.Value = Properties.Settings.Default.TeamBudget;
            }
            else {
                this.numTeamQuantity.Value = this.market.Configuration.TeamCount;
                this.txtMonetarySymbol.Text = this.market.Configuration.MonetarySymbol;
                this.numTeamBudget.Value = this.market.Configuration.TeamBudget;
            }
        }

        private void btnStart_Click(object sender, EventArgs e) {
            Market newInstance = new Market(Properties.Settings.Default.TeamQuantity, Properties.Settings.Default.TeamBudget, Properties.Settings.Default.MonetarySymbol);
            List<Team> teams = new List<Team>();
            for(int i = 0; i < Properties.Settings.Default.TeamQuantity; i++) {
                teams.Add(new Team(i + 1, "Team " + (i + 1).ToString(), Properties.Settings.Default.TeamBudget));
            }
            newInstance.TeamList = teams.ToArray();
            this.DialogResult = DialogResult.OK;
            this.market = newInstance;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void btnLoad_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            if(String.IsNullOrEmpty(Properties.Settings.Default.LastSavePath)) {
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            } else {
                ofd.InitialDirectory = Properties.Settings.Default.LastSavePath;
            }
            ofd.DefaultExt = "xml";
            ofd.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            if(ofd.ShowDialog() == DialogResult.OK) {
                Market newInstance = Market.Load(ofd.FileName);
                Properties.Settings.Default.LastSavePath = new FileInfo(ofd.FileName).DirectoryName;
                Properties.Settings.Default.Save();
                this.market = newInstance;
                updateControlValues();
            }
        }

        private void MarketSetup_FormClosed(object sender, FormClosedEventArgs e) {
            if(this.DialogResult != DialogResult.OK)
                Application.Exit();
        }

        private void dgvCommodities_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            DataGridViewColumn column = dgvCommodities.Columns[e.ColumnIndex];
            if(!column.DataPropertyName.ToLower().Contains("image")) {
                return;
            }
            CommodityIconBrowser browser = new CommodityIconBrowser();
            browser.ShowDialog();
        }

        private void txtMonetarySymbol_TextChanged(object sender, EventArgs e) {
            bindCommodityGrid();
        }

        private void btnSaveSetup_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Properties.Settings.Default.LastSavePath;
            sfd.DefaultExt = "xml";
            sfd.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            if(sfd.ShowDialog() == DialogResult.OK) {
                try {
                    Market temp = createMarketFromCurrent();
                    temp.Save(sfd.FileName);
                    MessageBox.Show("Market setup has been saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex) {
                    MessageBox.Show("Unable to save: \n" + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Market createMarketFromCurrent() {
            Market newInstance = new Market(Properties.Settings.Default.TeamQuantity, Properties.Settings.Default.TeamBudget, Properties.Settings.Default.MonetarySymbol);
            List<Team> teams = new List<Team>();
            for(int i = 0; i < Properties.Settings.Default.TeamQuantity; i++) {
                teams.Add(new Team(i + 1, "Team " + (i + 1).ToString(), Properties.Settings.Default.TeamBudget));
            }
            newInstance.TeamList = teams.ToArray();
            return newInstance;
        }
    }
}
