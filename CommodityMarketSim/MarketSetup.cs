using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketFrameworkLibrary;

namespace CommodityMarketSim {
    public partial class MarketSetup : Form {

        public MarketSetup() {
            InitializeComponent();
        }

        private void MarketSetup_Load(object sender, EventArgs e) {
            this.numTeamQuantity.Value = Properties.Settings.Default.TeamQuantity;
            this.txtMonetarySymbol.Text = Properties.Settings.Default.MonetarySymbol;
            this.numTeamBudget.Value = Properties.Settings.Default.TeamBudget;
        }

        private void btnStart_Click(object sender, EventArgs e) {
            Properties.Settings.Default.TeamQuantity = (int)this.numTeamQuantity.Value;
            Properties.Settings.Default.MonetarySymbol = this.txtMonetarySymbol.Text;
            Properties.Settings.Default.TeamBudget = (int)this.numTeamBudget.Value;
            Properties.Settings.Default.Save();
            Market newInstance = new Market(Properties.Settings.Default.TeamQuantity, Properties.Settings.Default.TeamBudget, Properties.Settings.Default.MonetarySymbol);
            List<Team> teams = new List<Team>();
            for(int i = 0; i < Properties.Settings.Default.TeamQuantity; i++) {
                teams.Add(new Team(i + 1, "Team " + (i + 1).ToString(), Properties.Settings.Default.TeamBudget));
            }
            newInstance.TeamList = teams.ToArray();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
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
                Properties.Settings.Default.TeamQuantity = newInstance.TeamCount;
                Properties.Settings.Default.MonetarySymbol = newInstance.MonetarySymbol;
                Properties.Settings.Default.TeamBudget = newInstance.TeamBudget;
                Properties.Settings.Default.Save();
            }
            this.Close();
        }
    }
}
