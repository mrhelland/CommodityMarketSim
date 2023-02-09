using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketFrameworkLibrary;

namespace CommodityMarketSim
{
    public partial class PurchaseRoundDisplay : UserControl
    {

        private PurchaseRound round;
        public PurchaseRound Round {
            get => round;
            set {
                round = value;
                UpdateUI();
            }
        }

        public PurchaseRoundDisplay()
        {
            InitializeComponent();
            
        }

        public void OnPendingTransactionChanged(object sender, EventArgs e) {
            if(round != null) {
                foreach(Control c in flpTeams.Controls) {
                    TeamDisplay td = (TeamDisplay)c;
                    if(td.Pending == null) {
                        btnFinish.Enabled = false;
                        return;
                    }
                }
                btnFinish.Enabled = true;
                return;
            }
            btnFinish.Enabled = false;
        }

        private void PurchaseRoundDisplay_Load(object sender, EventArgs e) {
            LoadTeams();
            LoadCommodities();
        }

        private void LoadTeams() {
            if(Market.TeamList == null) {
                return;
            }

            int index = 0;
            foreach(Team t in Market.TeamList) {
                TeamDisplay temp = new TeamDisplay();
                temp.Team = t;
                temp.Width = 200;
                temp.Pending = null;
                temp.PendingTransactionChanged += OnPendingTransactionChanged;
                flpTeams.Controls.Add(temp);

            }
        }

        private void LoadCommodities() {
            foreach(Commodity c in Market.CommodityList) {
                CommodityDisplay temp = new CommodityDisplay();
                temp.Width = 200;
                temp.Commodity = c;
                flpCommodities.Controls.Add(temp);
            }
        }

        private void UpdateUI() {
            if(round != null) {
                lblRoundNumber.Text = round.Number.ToString();
            } else {
                lblRoundNumber.Text = "n/a";
            }
        }

        private void btnFinish_Click(object sender, EventArgs e) {
            if(round != null) {
                foreach(Control c in flpTeams.Controls) {
                    TeamDisplay td = (TeamDisplay)c;
                    if(td.Pending != null) {

                    }
                    round.Transactions.Add(td.Pending);
                }
                round.ProcessTransactions();
            }
            this.ParentForm.Close();
        }

        public void FillBlanks() {
            Commodity nothing = null;
            foreach(Commodity c in Market.CommodityList) {
                if(c.CommmodityType == Commodity.Commodities.none) {
                    nothing = c;
                }
            }
            foreach(TeamDisplay td in flpTeams.Controls) {
                if(td.Pending == null) {
                    td.Pending = new Transaction(DateTime.Now, td.Team, nothing, 1, 0);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            FillBlanks();
        }
    }
}
