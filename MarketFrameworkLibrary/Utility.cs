using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketFrameworkLibrary {

    public static class StringExtension {
        public static string StripPunctuation(this string s) {
            var sb = new StringBuilder();
            foreach(char c in s) {
                if(!char.IsPunctuation(c))
                    sb.Append(c);
            }
            return sb.ToString();
        }
        public static string StripInvalidFileChars(this string s) {
            var sb = new StringBuilder();
            foreach(char c in s) {
                if(c == '\\') {
                    continue;
                }
                else if(!char.IsPunctuation(c)) {
                    sb.Append(c); 
                }
            }
            return sb.ToString();
        }
    }

    public class Utility {
        private static Random random = new Random();
        public static int RandomNumber(int min, int max) {
            return random.Next(min, max);
        }

        public static float RandomNumber(float min, float max) {
            return (float)random.NextDouble() * (max-min) + min;
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height) {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using(var graphics = Graphics.FromImage(destImage)) {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using(var wrapMode = new ImageAttributes()) {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
