using MarketFrameworkLibrary;

namespace CommodityMarketSim {
    partial class PurchaseRoundForm {
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
            this.purchaseRoundDisplay1 = new CommodityMarketSim.PurchaseRoundDisplay();
            this.SuspendLayout();
            // 
            // purchaseRoundDisplay1
            // 
            this.purchaseRoundDisplay1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseRoundDisplay1.Location = new System.Drawing.Point(11, 11);
            this.purchaseRoundDisplay1.Margin = new System.Windows.Forms.Padding(2);
            this.purchaseRoundDisplay1.Name = "purchaseRoundDisplay1";
            this.purchaseRoundDisplay1.Round = null;
            this.purchaseRoundDisplay1.Size = new System.Drawing.Size(878, 503);
            this.purchaseRoundDisplay1.TabIndex = 0;
            // 
            // PurchaseRoundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 525);
            this.Controls.Add(this.purchaseRoundDisplay1);
            this.Name = "PurchaseRoundForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PurchaseRoundDisplay purchaseRoundDisplay1;
    }
}

