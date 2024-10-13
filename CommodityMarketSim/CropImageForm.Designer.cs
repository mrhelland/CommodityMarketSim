namespace CommodityMarketSim {
    partial class CropImageForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.sliderGamma = new CommodityMarketSim.FloatSliderWithDisplay();
            this.sliderContrast = new CommodityMarketSim.FloatSliderWithDisplay();
            this.sliderBrightness = new CommodityMarketSim.FloatSliderWithDisplay();
            this.pbCroppable = new CommodityMarketSim.CroppablePictureBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCroppable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(773, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(89, 37);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(773, 64);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 37);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(12, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hold SHIFT to move crop selection";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbPreview
            // 
            this.pbPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPreview.BackgroundImage = global::CommodityMarketSim.Properties.Resources.checker_pattern_dark_64;
            this.pbPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPreview.Location = new System.Drawing.Point(543, 12);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(64, 64);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPreview.TabIndex = 4;
            this.pbPreview.TabStop = false;
            // 
            // sliderGamma
            // 
            this.sliderGamma.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sliderGamma.ForeColor = System.Drawing.Color.White;
            this.sliderGamma.Location = new System.Drawing.Point(543, 340);
            this.sliderGamma.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.sliderGamma.MaxValue = 2F;
            this.sliderGamma.MinValue = 0.05F;
            this.sliderGamma.Name = "sliderGamma";
            this.sliderGamma.Size = new System.Drawing.Size(319, 87);
            this.sliderGamma.TabIndex = 8;
            this.sliderGamma.TickFrequency = 0.01F;
            this.sliderGamma.Title = "Gamma";
            this.sliderGamma.Value = 1F;
            this.sliderGamma.SliderValueChanged += new System.EventHandler(this.sliderGamma_SliderValueChanged);
            // 
            // sliderContrast
            // 
            this.sliderContrast.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sliderContrast.ForeColor = System.Drawing.Color.White;
            this.sliderContrast.Location = new System.Drawing.Point(543, 237);
            this.sliderContrast.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.sliderContrast.MaxValue = 2F;
            this.sliderContrast.MinValue = 0.05F;
            this.sliderContrast.Name = "sliderContrast";
            this.sliderContrast.Size = new System.Drawing.Size(319, 87);
            this.sliderContrast.TabIndex = 7;
            this.sliderContrast.TickFrequency = 0.01F;
            this.sliderContrast.Title = "Contrast";
            this.sliderContrast.Value = 1F;
            this.sliderContrast.SliderValueChanged += new System.EventHandler(this.sliderContrast_SliderValueChanged);
            // 
            // sliderBrightness
            // 
            this.sliderBrightness.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sliderBrightness.ForeColor = System.Drawing.Color.White;
            this.sliderBrightness.Location = new System.Drawing.Point(543, 134);
            this.sliderBrightness.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.sliderBrightness.MaxValue = 2F;
            this.sliderBrightness.MinValue = 0.05F;
            this.sliderBrightness.Name = "sliderBrightness";
            this.sliderBrightness.Size = new System.Drawing.Size(319, 87);
            this.sliderBrightness.TabIndex = 6;
            this.sliderBrightness.TickFrequency = 0.01F;
            this.sliderBrightness.Title = "Brightness";
            this.sliderBrightness.Value = 1F;
            this.sliderBrightness.SliderValueChanged += new System.EventHandler(this.sliderBrightness_SliderValueChanged);
            // 
            // pbCroppable
            // 
            this.pbCroppable.BackgroundImage = global::CommodityMarketSim.Properties.Resources.checker_pattern_dark_64;
            this.pbCroppable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCroppable.Image = null;
            this.pbCroppable.Location = new System.Drawing.Point(12, 12);
            this.pbCroppable.Name = "pbCroppable";
            this.pbCroppable.Size = new System.Drawing.Size(512, 512);
            this.pbCroppable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCroppable.TabIndex = 0;
            this.pbCroppable.TabStop = false;
            this.pbCroppable.ImageCropChanged += new System.EventHandler<CommodityMarketSim.ImageCropChangedEventArgs>(this.pbCroppable_ImageCropChanged);
            // 
            // CropImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(874, 563);
            this.Controls.Add(this.sliderGamma);
            this.Controls.Add(this.sliderContrast);
            this.Controls.Add(this.sliderBrightness);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPreview);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pbCroppable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CropImageForm";
            this.Text = "Select and Crop";
            this.Load += new System.EventHandler(this.CropImageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCroppable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CroppablePictureBox pbCroppable;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.Label label1;
        private FloatSliderWithDisplay sliderBrightness;
        private FloatSliderWithDisplay sliderContrast;
        private FloatSliderWithDisplay sliderGamma;
    }
}