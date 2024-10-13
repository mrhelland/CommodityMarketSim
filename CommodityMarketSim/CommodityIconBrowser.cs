using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketFrameworkLibrary;

namespace CommodityMarketSim {
    public partial class CommodityIconBrowser : Form {

        private Image selectedImage;
        private string selectedImageName;

        public Image SelectedImage {
            get => selectedImage;
            set => selectedImage = value;
        }

        public CommodityIconBrowser() {
            InitializeComponent();
        }

        private void CommodityIconBrowser_Load(object sender, EventArgs e) {
            populateImageResources();
        }

        private void populateImageResources() {
            imgList.Images.Clear();
            SortedList<string, Image> images = Commodity.Images;
            for(int i = 0; i < images.Count; i++) {
                imgList.Images.Add(images.Values[i]);
                ListViewItem item = new ListViewItem();
                item.Text = images.Keys[i];
                item.ImageIndex = i;
                lvImages.Items.Add(item);
            }
        }

        private void btnImport_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "png";
            ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if(ofd.ShowDialog() == DialogResult.OK) {
                FileInfo f = new FileInfo(ofd.FileName);
                string name = f.Name.Replace(f.Extension, "");
                Image newImage = new Bitmap(f.FullName);
                CropImageForm crop = new CropImageForm();
                crop.Image = newImage;
                crop.ShowDialog();

                //string fileSavePath = Path.Combine(Commodity.ImageDirectory, 
                //newImage.Save()

            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            selectedImage = null;
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
