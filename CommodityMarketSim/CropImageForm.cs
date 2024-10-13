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
    public partial class CropImageForm : Form {

        public Image Image {
            get => pbCroppable.Image;
            set => pbCroppable.Image = value;
        }


        public CropImageForm() {
            InitializeComponent();
        }

        private void CropImageForm_Load(object sender, EventArgs e) {

        }

        private void btnOk_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult= DialogResult.Cancel;
        }

        private void btnPreview_Click(object sender, EventArgs e) {
            if(this.Image != null) {
                pbPreview.Image = pbCroppable.CroppedImage;
            }
        }
    }
}
