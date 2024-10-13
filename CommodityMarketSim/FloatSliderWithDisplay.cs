using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommodityMarketSim {
    public partial class FloatSliderWithDisplay : UserControl {

        public event EventHandler SliderValueChanged;

        protected virtual void OnSliderValueChanged() {
            SliderValueChanged?.Invoke(this, new EventArgs());
        }
        
        private float tickFrequency = 0.1f;
        private float minValue = 0.1f;
        private float maxValue = 2.0f;
        private float value = 1.0f;

        public String Title {
            get { return lblTitle.Text; }
            set { 
                lblTitle.Text = value;
            }
        }


        public float MaxValue {
            get {
                return maxValue;
            }
            set {
                maxValue = value;
                updateControls();
            }
        }

        public float MinValue {
            get {
                return tbSlider.Minimum * tickFrequency;
            }
            set {
                minValue = value;
                updateControls();
            }
        }

        public float Value {
            get {
                return this.value;
            }
            set {
                this.value = value;
                this.tbSlider.Value = (int)((value + this.tickFrequency / 2) / tickFrequency);
                updateControls();
            }
        }

        public float TickFrequency {
            get { return tickFrequency; }
            set { tickFrequency = value; updateControls(); }
        }

        public new Color ForeColor {
            get {
                return base.ForeColor;
            } set {
                base.ForeColor = value;
                foreach(Control c in base.Controls) {
                    c.ForeColor = value;
                }
            }
        }

        public new Color BackColor {
            get {
                return base.BackColor;
            }
            set {
                this.BackColor = value;
                foreach(Control c in base.Controls) {
                    c.BackColor = value;
                }
            }
        }

        private void updateControls() {
            this.lblValue.Text = getRoundedValue(this.value, 2);
            this.lblMin.Text = getRoundedValue(this.minValue, 2);
            this.lblMax.Text = getRoundedValue(this.maxValue, 2);
            this.tbSlider.SmallChange = 1;
            this.tbSlider.LargeChange = 1;
            this.tbSlider.Maximum = (int) (this.maxValue / tickFrequency);
            this.tbSlider.Minimum = (int)(this.minValue / tickFrequency);
            this.tbSlider.TickFrequency = (this.tbSlider.Maximum - this.tbSlider.Minimum);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Trackbar Values: ");
            sb.AppendLine(" Max: " + tbSlider.Maximum);
            sb.AppendLine(" Min: " + tbSlider.Minimum);
            sb.AppendLine(" Tick: " + tbSlider.TickFrequency);
            sb.AppendLine(" Value: " + tbSlider.Value);
            Console.WriteLine(sb.ToString());
        }

        private String getRoundedValue(float value, int decimalPlaces) {
            StringBuilder roundFormat = new StringBuilder();
            roundFormat.Append("0");
            if(decimalPlaces > 0) {
                roundFormat.Append(".");
            }
            for(int i = 0; i < decimalPlaces; i++) {
                roundFormat.Append('0');
            }
            string result = value.ToString(roundFormat.ToString());
            return result;
        }

        public FloatSliderWithDisplay() {
            InitializeComponent();
            updateControls();
        }

        private void tbSlider_Scroll(object sender, EventArgs e) {
            this.value = tbSlider.Value * tickFrequency;
            updateControls();
            OnSliderValueChanged();
        }

        private void tbSlider_ValueChanged(object sender, EventArgs e) {
            this.value = tbSlider.Value * tickFrequency;
            updateControls();
            OnSliderValueChanged();

        }
    }
}
