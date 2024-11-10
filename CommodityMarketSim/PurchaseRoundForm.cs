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
    public partial class PurchaseRoundForm : Form {


        private Market market;
        public Market Market {
            get => market;
        }

        public PurchaseRound Round {
            get {
                return purchaseRoundDisplay1.Round;
            }
            set {
                purchaseRoundDisplay1.Round = value;
            }
        }

        public PurchaseRoundForm(Market market) {
            InitializeComponent();
            this.market = market;
        }

        private void Form1_Load(object sender, EventArgs e) {
            purchaseRoundDisplay1.Parent = this;
            purchaseRoundDisplay1.Market = this.market;
        }
    }
}
