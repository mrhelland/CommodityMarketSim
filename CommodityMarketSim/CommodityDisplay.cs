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
                if(commodity != null) {
                    commodity.ValueChanged -= this.ValueChanged;
                    commodity = null;
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

        private void lblQuantity_Click(object sender, EventArgs e) {

        }

        private void lblPrice_Click(object sender, EventArgs e) {

        }

        private void pbIcon_MouseDown(object sender, MouseEventArgs e) {
            if(commodity.Available > 0) {
                pbIcon.DoDragDrop(Commodity.GetJSON(commodity), DragDropEffects.Copy);
            }
        }

        private void CommodityDisplay_QueryContinueDrag(object sender, QueryContinueDragEventArgs e) {
            if(e.Action == DragAction.Drop) {
                
            }
        }

        private void CommodityDisplay_DragEnter(object sender, DragEventArgs e) {
            if(e.Data.GetDataPresent(DataFormats.Text)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }



        private void CommodityDisplay_DragDrop(object sender, DragEventArgs e) {

        }

    }
}
