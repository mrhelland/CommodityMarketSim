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
    public partial class TeamDisplay : UserControl {

        public event EventHandler PendingTransactionChanged;

        private Team team;
        public Team Team {
            get => team;
            set {
                if(team != null) {
                    team.ValueChanged -= this.ValueChanged;
                    team = null;
                }
                team = value;
                if(team != null) {
                    team.ValueChanged += this.ValueChanged;
                }
                UpdateUI();
            }
        }

        private Transaction pending;
        public Transaction Pending {
            get => pending;
            set {
                pending = value;
                UpdateUI();
                OnValueChanged();
            }
        }

        private bool showdropbox = true;
        public bool ShowDropBox {
            get => showdropbox;
            set {
                showdropbox = value;
                UpdateUI();
            }
        }

        public TeamDisplay() {
            InitializeComponent();
            pbCommodity.AllowDrop = true;
        }

        protected virtual void OnValueChanged() {
            EventHandler handler = PendingTransactionChanged;
            if(handler != null) {
                handler(this, new EventArgs());
            }
        }

        private void ValueChanged(object sender, EventArgs e) {
            UpdateUI();
        }

        private void UpdateUI() {
            if(team == null) {
                //this.lblName.Text = "n/a";
                this.lblFunds.Text = "n/a";
                this.pbIcon.Image = null;
                this.BackColor = Globals.GetFormBackcolor(false);
            } else {
                //this.lblName.Text = team.Name;
                if(pending != null) {
                    this.lblFunds.Text = Market.MonetarySymbol + (team.Funds-pending.Totalprice).ToString();
                } else {
                    this.lblFunds.Text = Market.MonetarySymbol + team.Funds.ToString();
                }
                this.pbIcon.Image = imgsTeams.Images[team.ImageIndex];
                this.BackColor = Globals.GetFormBackcolor(team.Funds > 200);
            }
            if(showdropbox) {
                this.Height = 154;
                pbCommodity.Visible = true;
            } else {
                this.Height = 68;
                pbCommodity.Visible = false;
            }
            if(pending == null) {
                this.lblPrice.Text = Market.MonetarySymbol + "0";
                this.lblQuantity.Text = "0 units";
                this.pbCommodity.Image = Properties.Resources.target;
            } else {
                this.lblPrice.Text = Market.MonetarySymbol + pending.Unitprice.ToString();
                this.lblQuantity.Text = pending.Quantity.ToString() + " units";
                this.pbCommodity.Image = imgsCommodities.Images[pending.Commodity.ImageIndex];
            }
        }

        private void TeamDisplay_Load(object sender, EventArgs e) {
            UpdateUI();
        }

        private void pbCommodity_DragEnter(object sender, DragEventArgs e) {
            if(e.Data.GetDataPresent(DataFormats.Text) && pending == null) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }

        private int last_quantity = 1;
        private void pbCommodity_DragDrop(object sender, DragEventArgs e) {
            string json = (string)e.Data.GetData(DataFormats.Text);
            if(!String.IsNullOrEmpty(json)) {
                Commodity fromJSON = Commodity.GetCommodity(json);
                Commodity matched = null;
                foreach(Commodity c in Market.CommodityList) {
                    if(String.Compare(c.Name, fromJSON.Name) == 0) {
                        matched = c;
                    }
                }
                last_quantity = 1;
                if(ModifierKeys.HasFlag(Keys.Control)) {
                    last_quantity = 5;
                } else if(ModifierKeys.HasFlag(Keys.Shift)) {
                    last_quantity = 10;
                }
                this.Pending = new Transaction(DateTime.Now, this.team, matched, last_quantity, matched.Price);
                matched.Reserve(last_quantity);
                ((CommodityDisplay)sender).UpdateUI();
            }
        }

        private void pbCommodity_MouseDown(object sender, MouseEventArgs e) {
            if(pending != null) {
                pbCommodity.DoDragDrop(pending, DragDropEffects.Copy);
            }
        }

        private void pbCommodity_QueryContinueDrag(object sender, QueryContinueDragEventArgs e) {
            if(e.Action == DragAction.Drop) {
                this.pending.Commodity.Reserve(-last_quantity);
                this.Pending = null;
                UpdateUI();
            }
        }

        private void pbCommodity_Click(object sender, EventArgs e) {

        }
    }
}
