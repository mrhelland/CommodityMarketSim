namespace CommodityMarketSim {
    partial class FloatSliderWithDisplay {
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
            this.tbSlider = new System.Windows.Forms.TrackBar();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSlider
            // 
            this.tbSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSlider.AutoSize = false;
            this.tbSlider.Location = new System.Drawing.Point(0, 19);
            this.tbSlider.Margin = new System.Windows.Forms.Padding(0);
            this.tbSlider.Name = "tbSlider";
            this.tbSlider.Size = new System.Drawing.Size(588, 47);
            this.tbSlider.TabIndex = 0;
            this.tbSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbSlider.Scroll += new System.EventHandler(this.tbSlider_Scroll);
            this.tbSlider.ValueChanged += new System.EventHandler(this.tbSlider_ValueChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(512, 19);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Slider Title";
            // 
            // lblValue
            // 
            this.lblValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValue.BackColor = System.Drawing.Color.Transparent;
            this.lblValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(66, 59);
            this.lblValue.Margin = new System.Windows.Forms.Padding(0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(456, 28);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "0.0";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMin
            // 
            this.lblMin.Location = new System.Drawing.Point(0, 59);
            this.lblMin.Margin = new System.Windows.Forms.Padding(0);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(66, 24);
            this.lblMin.TabIndex = 3;
            this.lblMin.Text = "label2";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMax
            // 
            this.lblMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMax.Location = new System.Drawing.Point(522, 59);
            this.lblMax.Margin = new System.Windows.Forms.Padding(0);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(66, 24);
            this.lblMax.TabIndex = 4;
            this.lblMax.Text = "label2";
            this.lblMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FloatSliderWithDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbSlider);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FloatSliderWithDisplay";
            this.Size = new System.Drawing.Size(588, 87);
            ((System.ComponentModel.ISupportInitialize)(this.tbSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar tbSlider;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
    }
}
