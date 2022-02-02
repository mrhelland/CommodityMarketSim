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

namespace CommodityMarketSim {
    public partial class MarketSetup : Form {

        private Market market;
        public Market Market {
            get => market;
            set => market = value;
        }

        public MarketSetup() {
            InitializeComponent();
        }

        private void MarketSetup_Load(object sender, EventArgs e) {
            if(market != null) {
                this.numTeamQuantity.Value = Market.TeamQuantity;
                this.txtMonetarySymbol.Text = Market.MonetarySymbol;
            }
        }

        private void btnStart_Click(object sender, EventArgs e) {
            Market.TeamQuantity = (int)this.numTeamQuantity.Value;
            Market.MonetarySymbol = this.txtMonetarySymbol.Text;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
