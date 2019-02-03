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

namespace CommodityMarketSim {
    public partial class CommodityDisplay : UserControl {

        private Commodity commodity;
        public Commodity Commodity {
            get => commodity;
            set {
                if(value != null) {
                    commodity.ValueChanged -= this.ValueChanged;
                }
                commodity = value;
                if(commodity != null) {
                    commodity.ValueChanged += this.ValueChanged;
                }
                UpdateUI();
            }
        }

        public CommodityDisplay() {
            InitializeComponent();
        }

        private void ValueChanged(object sender, EventArgs e) {
            UpdateUI();
        }

        private void UpdateUI() {
            this.lblName.Text = commodity.Name;
            this.lblPrice.Text = commodity.Price.ToString() + " bc";
            this.lblQuantity.Text = commodity.Available.ToString() + " units";
            this.pbIcon.Image = imgsCommodities.Images[commodity.ImageIndex];
            this.BackColor = Globals.GetFormBackcolor(commodity.Available > 0);
        }

        private void CommodityDisplay_Load(object sender, EventArgs e) {
            UpdateUI();
        }
    }
}
