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
    public partial class TeamDisplay : UserControl
    {

        private Team team;
        public Team Team {
            get => team;
            set {
                if(value != null) {
                    team.ValueChanged -= this.ValueChanged;
                }
                team = value;
                if(team != null) {
                    team.ValueChanged += this.ValueChanged;
                }
                UpdateUI();
            }
        }

        public TeamDisplay()
        {
            InitializeComponent();
        }

        private void ValueChanged(object sender, EventArgs e) {
            UpdateUI();
        }

        private void UpdateUI() {
            this.lblName.Text = team.Name;
            this.lblFunds.Text = team.Funds.ToString() + " bc";
            this.pbIcon.Image = imgsTeams.Images[team.ImageIndex];
            this.BackColor = Globals.GetFormBackcolor(team.Funds > 200);
        }

        private void TeamDisplay_Load(object sender, EventArgs e) {
            UpdateUI();
        }
    }
}
