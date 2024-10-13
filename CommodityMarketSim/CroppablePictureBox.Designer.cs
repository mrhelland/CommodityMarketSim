namespace CommodityMarketSim {
    partial class CroppablePictureBox {
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
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // CroppablePictureBox
            // 
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CroppablePictureBox_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CroppablePictureBox_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CroppablePictureBox_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CroppablePictureBox_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
