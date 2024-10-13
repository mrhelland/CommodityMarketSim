using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketFrameworkLibrary;

namespace CommodityMarketSim {
    public partial class CropImageForm : Form {

        public Image Image {
            get => pbCroppable.Image;
            set => pbCroppable.Image = value;
        }

        public Image CroppedImage {
            get => pbCroppable.CroppedImage;
        }

        private DirectoryInfo saveDirectory;
        public DirectoryInfo SaveDirectory {
            get => saveDirectory;
            set => saveDirectory = value;
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

        private void pbCroppable_ImageCropChanged(object sender, ImageCropChangedEventArgs e) {
            pbPreview.Image = (Image)e.CroppedImage.Clone();
        }

        private Image originalImage;
        private void updateAdjustedImage() {
            if(this.originalImage == null) {
                originalImage = pbCroppable.Image;
            }
            pbCroppable.Image = Utility.adjustImage(originalImage, this.sliderBrightness.Value, this.sliderContrast.Value, this.sliderGamma.Value);
        }

        private void sliderBrightness_SliderValueChanged(object sender, EventArgs e) {
            updateAdjustedImage();
        }

        private void sliderContrast_SliderValueChanged(object sender, EventArgs e) {
            updateAdjustedImage();
        }

        private void sliderGamma_SliderValueChanged(object sender, EventArgs e) {
            updateAdjustedImage();
        }
    }
}
