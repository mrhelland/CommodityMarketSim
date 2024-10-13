using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CommodityMarketSim {
    public class ImageCropChangedEventArgs : EventArgs{
        private Image croppedImage;
        public Image CroppedImage {
            get => croppedImage;
        }

        public ImageCropChangedEventArgs(Image image) {
            this.croppedImage = image;
        }
    }
}
