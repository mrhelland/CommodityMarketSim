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
            foreach(Team t in Market.TeamList) {
                TeamDisplay temp = new TeamDisplay();
                temp.Team = t;
                temp.Pending = null;
                temp.PendingTransactionChanged += OnPendingTransactionChanged;
                flpTeams.Controls.Add(temp);

            }
        }

        private void LoadCommodities() {
            foreach(Commodity c in Market.CommodityList) {
                CommodityDisplay temp = new CommodityDisplay();
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
    }
}
