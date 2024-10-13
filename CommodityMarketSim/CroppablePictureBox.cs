using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using MarketFrameworkLibrary;
using System.Drawing.Imaging;
using Newtonsoft.Json.Linq;

namespace CommodityMarketSim {
    public partial class CroppablePictureBox : PictureBox {

        public event EventHandler<ImageCropChangedEventArgs> ImageCropChanged;

        protected virtual void OnImageCropChanged(Image CroppedImage) {
            ImageCropChangedEventArgs e = new ImageCropChangedEventArgs(CroppedImage);
            ImageCropChanged?.Invoke(this, e);
        }

        private Point startCorner;
        private Point endCorner;
        private Rectangle cropRectangle;
        private Brush cropOutlineBrush;
        private Brush selectionBrush;
        private Brush fillBrush;
        private Brush cornerBrush;
        private Pen cropOutlinePen;
        private Pen selectionPen;
        private Pen cornerPen;
        private bool isSelecting = false;
        private Point lastMouseLocation;
        private int cornerLength = 10;
        private Image squareImage; 

        public bool IsSquare {
            get {
                if(cropRectangle != null)
                    return true;
                else if(this.Image != null) {
                    return this.Image.Width == this.Image.Height;
                }
                else {
                    return false;
                }
            }
        }

        public new Image Image {
            get { 
                return base.Image; 
            }

            set { 
                base.Image = value;
                OnImageCropChanged(value);
            }
        }

        public Image CroppedImage {
            get {
                if(this.Image == null) {
                    return null;
                }
                else {
                    return getCroppedImage(64);
                }
            }
        }

        private Image getCroppedImage(int size) {
            Rectangle scaledCropRectangle;
            if(cropRectangle != Rectangle.Empty) {
                Rectangle unscaledCropRectangle = cropRectangle;
                Point scaledTopLeft = GetScaledImageLocation(unscaledCropRectangle.Location);
                Point scaledBottomRight = GetScaledImageLocation(new Point(unscaledCropRectangle.Right, unscaledCropRectangle.Bottom));
                Size scaledSize = new Size(scaledBottomRight.X - scaledTopLeft.Y, scaledBottomRight.Y - scaledTopLeft.Y);
                scaledCropRectangle = GetScaledImageRectangle(unscaledCropRectangle);
            }
            else {
                int minSize = Math.Min(this.Image.Width, this.Image.Height);
                int offsetX = this.Image.Width - minSize;
                int offsetY = this.Image.Height - minSize;
                scaledCropRectangle = new Rectangle(offsetX/2, offsetY/2, minSize, minSize);
            }
            Image cropped = new Bitmap(size, size, PixelFormat.Format32bppArgb);
            Rectangle destRect = new Rectangle(0, 0, size, size);
            Graphics g = Graphics.FromImage(cropped);
            g.CompositingMode = CompositingMode.SourceCopy;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.DrawImage(this.Image, destRect, scaledCropRectangle, GraphicsUnit.Pixel);
            return cropped;
        }

        public CroppablePictureBox() {
            InitializeComponent();
            initializeValues();
        }

        public CroppablePictureBox(IContainer container) {
            container.Add(this);

            InitializeComponent();
            initializeValues();
        }

        private void initializeValues() {
            this.SizeMode = PictureBoxSizeMode.Zoom;
            startCorner = Point.Empty;
            endCorner = Point.Empty;
            cropRectangle = Rectangle.Empty;
            fillBrush = new SolidBrush(Color.FromArgb(128, Color.Black));
            cropOutlineBrush = new SolidBrush(Color.White);
            selectionBrush = new SolidBrush(Color.Red);
            cornerBrush = new SolidBrush(Color.White);
            cropOutlinePen = new Pen(cropOutlineBrush, 2);
            selectionPen = new Pen(selectionBrush, 1);
            selectionPen.DashPattern = new float[] { 2.0f, 1.0f };
            cornerPen = new Pen(cornerBrush, 4);

        }

        private void CroppablePictureBox_Paint(object sender, PaintEventArgs e) {

        }

        private Point GetScaledImageLocation(Point location) {
            double imgWidth = this.Image.Width;
            double imgHeight = this.Image.Height;
            double boxWidth = this.Size.Width;
            double boxHeight = this.Size.Height;

            double X = location.X;
            double Y = location.Y;
            double scale;

            if(imgWidth / imgHeight > boxWidth / boxHeight) {
                scale = boxWidth / imgWidth;
                double blankPart = (boxHeight - scale * imgHeight) / 2;
                Y -= blankPart;
            }
            else {
                scale = boxHeight / imgHeight;
                double blankPart = (boxWidth - scale * imgWidth) / 2;
                X -= blankPart;
            }

            X /= scale;
            Y /= scale;

            return new Point((int)Math.Round(X), (int)Math.Round(Y));
        }

        private Rectangle GetScaledImageRectangle(Rectangle rect) {
            double imgWidth = this.Image.Width;
            double imgHeight = this.Image.Height;
            double boxWidth = this.Size.Width;
            double boxHeight = this.Size.Height;

            double x = rect.X;
            double y = rect.Y;
            double width = rect.Width;
            double height = rect.Height; 
            double scale;

            if(imgWidth / imgHeight > boxWidth / boxHeight) {
                scale = boxWidth / imgWidth;
                double blankPart = (boxHeight - scale * imgHeight) / 2;
                y -= blankPart;
            }
            else {
                scale = boxHeight / imgHeight;
                double blankPart = (boxWidth - scale * imgWidth) / 2;
                x -= blankPart;
            }

            x /= scale;
            y /= scale;
            width /= scale;
            height /= scale;

            return new Rectangle((int)x, (int)y, (int)width, (int)height);
        }




        protected override void OnPaint(PaintEventArgs e) {
            //if(this.Image != null) {
            //    if(this.Image.Width != this.Image.Height) {
            //        int maxDimension = Math.Max(this.Image.Width, this.Image.Height);
            //        int offsetX = (maxDimension - this.Image.Width) / 2;
            //        int offsetY = (maxDimension - this.Image.Height) / 2;
            //        Image square = new Bitmap(maxDimension, maxDimension);
            //        Graphics g = Graphics.FromImage(square);
            //        g.DrawImage(this.Image, new Point(offsetX, offsetY));
            //        squareImage = square;
            //        this.Image = squareImage;
            //        this.SizeMode = PictureBoxSizeMode.Zoom;
            //    }
            //}
            base.OnPaint(e);
            if(selectionPen == null || cropOutlinePen == null) {
                return;
            }
            if( !cropRectangle.Equals(Rectangle.Empty) ) {
                if(isSelecting) {
                    e.Graphics.DrawRectangle(selectionPen, cropRectangle);
                }
                else {
                    drawFill(e.Graphics);
                    e.Graphics.DrawRectangle(cropOutlinePen, cropRectangle);
                    //drawCorners(e.Graphics);
                }
            }

        }

        private void drawFill(Graphics g) {
            // top rectangle
            Rectangle rect = new Rectangle(0, 0, this.Width, cropRectangle.Top);
            g.FillRectangle(fillBrush, rect);

            //bottom rectangle
            rect = new Rectangle(0, cropRectangle.Bottom, this.Width, this.Height - cropRectangle.Bottom);
            g.FillRectangle(fillBrush, rect);

            //left rectangle
            rect = new Rectangle(0, cropRectangle.Top, cropRectangle.Left, cropRectangle.Height);
            g.FillRectangle(fillBrush, rect);

            //right rectangle
            rect = new Rectangle(cropRectangle.Right, cropRectangle.Top, this.Width - cropRectangle.Right, cropRectangle.Height);
            g.FillRectangle(fillBrush, rect);

        }

        private void drawCorners(Graphics g) {
            
            
            Point down = new Point(cropRectangle.Left, cropRectangle.Top + cornerLength);
            g.DrawLine(cornerPen, cropRectangle.Location, down);
            Point right = new Point(cropRectangle.Left + cornerLength, cropRectangle.Top);
            g.DrawLine(cornerPen, cropRectangle.Location, right);

            Point up = new Point(cropRectangle.Right, cropRectangle.Bottom - cornerLength);
            g.DrawLine(cornerPen, cropRectangle.Right, cropRectangle.Bottom, up.X, up.Y);
            Point left = new Point(cropRectangle.Right - cornerLength, cropRectangle.Bottom);
            g.DrawLine(cornerPen, cropRectangle.Right, cropRectangle.Bottom, left.X, left.Y);
        }

        private void CroppablePictureBox_MouseDown(object sender, MouseEventArgs e) {
            if(!(Control.ModifierKeys == Keys.Shift)) {
                isSelecting = true;
                cropRectangle = Rectangle.Empty;
                endCorner = Point.Empty;
                startCorner = e.Location;
                lastMouseLocation = e.Location;
                Console.WriteLine("Start Corner: " + e.Location.ToString() );
                this.Invalidate();
            
            }
        }

        private void CroppablePictureBox_MouseUp(object sender, MouseEventArgs e) {
            if(!cropRectangle.Equals(RectangleF.Empty) && isBottomRight(endCorner, startCorner)) {
                endCorner = e.Location;
                lastMouseLocation = e.Location;
                cropRectangle = getSquare(startCorner, endCorner);
                Console.WriteLine("End Corner: " + e.Location.ToString());
            }
            else {
                cropRectangle = Rectangle.Empty;  
            }
            isSelecting = false;
            this.Invalidate();
            OnImageCropChanged(getCroppedImage(64));


        }



        private void CroppablePictureBox_MouseMove(object sender, MouseEventArgs e) {
            if(lastMouseLocation == null) {
                lastMouseLocation = e.Location;
            }
            int deltaX = e.Location.X - lastMouseLocation.X;
            int deltaY = e.Location.Y - lastMouseLocation.Y;
            if(startCorner != PointF.Empty && isSelecting) {
                if(isBottomRight(e.Location, startCorner)) {
                    if(Control.ModifierKeys == Keys.Shift) {
                        startCorner = new Point(startCorner.X + deltaX, startCorner.Y + deltaY);
                        endCorner = new Point(endCorner.X + deltaX, endCorner.Y + deltaY);
                    }
                    else {
                        endCorner = e.Location;
                    }
                    cropRectangle = getSquare(startCorner, endCorner);
                    Console.WriteLine("Crop Rectangle: " + cropRectangle.ToString());
                    this.Invalidate();
                }
                else {
                    endCorner = Point.Empty;
                    cropRectangle = Rectangle.Empty;
                    this.Invalidate();
                }

            }
            else if(cropRectangle != Rectangle.Empty && Control.ModifierKeys == Keys.Shift) {
                startCorner = new Point(startCorner.X + deltaX, startCorner.Y + deltaY);
                endCorner = new Point(endCorner.X + deltaX, endCorner.Y + deltaY);
                cropRectangle = getSquare(startCorner, endCorner);
                this.Invalidate();

            }
            lastMouseLocation = e.Location;
        }

        private bool isBottomRight(Point point, Point relativeTo) {
            if(point.X > relativeTo.X && point.Y > relativeTo.Y) {
                return true;
            }
            else {
                return false;
            }
        }

        private Rectangle getRectangle(Point a, Point b) {
            Point topLeft = getTopLeft(a, b);
            Point bottomRight = getBottomRight(a, b);
            Size size = getSize(topLeft, bottomRight);
            return new Rectangle(topLeft, size);
        }

        private Rectangle getSquare(Point a, Point b) {
            Point topLeft = getTopLeft(a, b);
            Point bottomRight = getBottomRight(a, b);
            Size size = getSize(topLeft, bottomRight);
            int minSize = Math.Min(size.Width, size.Height);
            //Size deltaSize = new Size(size.Width - minSize, size.Height - minSize);
            //topLeft = Point.Subtract(topLeft, deltaSize);
            return new Rectangle(topLeft, new Size(minSize,minSize));
        }

        private Point getTopLeft(Point a, Point b) {
            int x = Math.Min(a.X, b.X);
            int y = Math.Min(a.Y, b.Y);
            return new Point(x, y);
        }

        private Point getBottomRight(Point a, Point b) {
            int x = Math.Max(a.X, b.X);
            int y = Math.Max(a.Y, b.Y);
            return new Point(x, y);
        }

        private Size getSize(Point topLeft, Point bottomRight) {
            return new Size(bottomRight.X - topLeft.X, bottomRight.Y - topLeft.Y);
        }

        //private PointF getRelativePointF(float x, float y) {
        //    return new PointF(x/this.Width, y/this.Height);
        //}

        //private PointF getRelativePointF(PointF point) {
        //    return getRelativePointF(point.X, point.Y);
        //}

    }
}
