namespace CommodityMarketSim {
    partial class CommodityDisplay {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommodityDisplay));
            this.lblName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.imgsCommodities = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoEllipsis = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(4, 68);
            this.lblName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(136, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Commodity Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantity.AutoEllipsis = true;
            this.lblQuantity.BackColor = System.Drawing.Color.White;
            this.lblQuantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblQuantity.Location = new System.Drawing.Point(69, 2);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(1, 1, 3, 1);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(70, 30);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "0";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuantity.Click += new System.EventHandler(this.lblQuantity_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoEllipsis = true;
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(69, 34);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(1, 1, 3, 1);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(70, 30);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "$0";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // pbIcon
            // 
            this.pbIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbIcon.Location = new System.Drawing.Point(3, 2);
            this.pbIcon.Margin = new System.Windows.Forms.Padding(3, 3, 1, 1);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(64, 64);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbIcon.TabIndex = 3;
            this.pbIcon.TabStop = false;
            this.pbIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbIcon_MouseDown);
            // 
            // imgsCommodities
            // 
            this.imgsCommodities.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgsCommodities.ImageStream")));
            this.imgsCommodities.TransparentColor = System.Drawing.Color.Transparent;
            this.imgsCommodities.Images.SetKeyName(0, "rubberbands.png");
            this.imgsCommodities.Images.SetKeyName(1, "notecards.png");
            this.imgsCommodities.Images.SetKeyName(2, "paperclip-sm.png");
            this.imgsCommodities.Images.SetKeyName(3, "paperclip-lg.png");
            this.imgsCommodities.Images.SetKeyName(4, "paper.png");
            this.imgsCommodities.Images.SetKeyName(5, "popsiclesticks.png");
            this.imgsCommodities.Images.SetKeyName(6, "tape.png");
            this.imgsCommodities.Images.SetKeyName(7, "string.png");
            this.imgsCommodities.Images.SetKeyName(8, "pencils.png");
            this.imgsCommodities.Images.SetKeyName(9, "pen.png");
            this.imgsCommodities.Images.SetKeyName(10, "pencil.png");
            this.imgsCommodities.Images.SetKeyName(11, "ruler.png");
            this.imgsCommodities.Images.SetKeyName(12, "scissors.png");
            this.imgsCommodities.Images.SetKeyName(13, "none.png");
            // 
            // CommodityDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CommodityDisplay";
            this.Size = new System.Drawing.Size(143, 97);
            this.Load += new System.EventHandler(this.CommodityDisplay_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.CommodityDisplay_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.CommodityDisplay_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.ImageList imgsCommodities;
    }
}
