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

        public void UpdateUI() {
            this.lblName.Text = commodity.Name;
            this.lblPrice.Text = "ↂ" + commodity.Price.ToString();
            this.lblQuantity.Text = (commodity.Available - commodity.Pendingunits).ToString() + " units";
            this.pbIcon.Image = imgsCommodities.Images[commodity.ImageIndex];

            bool available = commodity.Available > 0 && commodity.Pendingunits < commodity.Available;
            this.BackColor = Globals.GetFormBackcolor(available);
            this.lblName.BackColor = Globals.GetCommodityBackcolor(available);
        }

        private void CommodityDisplay_Load(object sender, EventArgs e) {
            UpdateUI();
        }

        private void lblQuantity_Click(object sender, EventArgs e) {

        }

        private void lblPrice_Click(object sender, EventArgs e) {

        }


        public enum DragDropStatus {
            None,
            Canceled,
            Started,
            Inprogress,
            Completed
        }

        private void pbIcon_MouseDown(object sender, MouseEventArgs e) {
            if(commodity.Available > 0) {
                pbIcon.DoDragDrop(Commodity.GetJSON(commodity), DragDropEffects.Copy);
            }
        }


        private void CommodityDisplay_DragEnter(object sender, DragEventArgs e) {
            if(e.Data.GetDataPresent(DataFormats.Text)) {
                Commodity matched = null;
                string json = (string)e.Data.GetData(DataFormats.Text);
                matched = GetJSONCommodity(json);
                if(matched != null) {
                    e.Effect = DragDropEffects.Copy;
                    return;
                } 
            } 
            e.Effect = DragDropEffects.None;
        }

        private Commodity GetJSONCommodity(string json) {
            Commodity matched = null;
            if(!String.IsNullOrEmpty(json)) {
                Commodity fromJSON = Commodity.GetCommodity(json);
                foreach(Commodity c in Market.CommodityList) {
                    if(String.Compare(c.Name, fromJSON.Name) == 0) {
                        matched = c;
                        break;
                    }
                }
            }
            return matched;
        }



        private void CommodityDisplay_DragDrop(object sender, DragEventArgs e) {
            if(e.Data.GetDataPresent(DataFormats.Text)) {
                //Commodity matched = null;
                //string json = (string)e.Data.GetData(DataFormats.Text);
                //matched = GetJSONCommodity(json);
                //if(matched != null) {
                //    UpdateUI();
                //}
            }
        }

        private void pbIcon_QueryContinueDrag(object sender, QueryContinueDragEventArgs e) {
        // TODO: need to check if later undone in team display
            if(e.Action == DragAction.Drop) {
                UpdateUI();
            }
        }
    }
}
