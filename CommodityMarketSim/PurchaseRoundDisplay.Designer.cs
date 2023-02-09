namespace CommodityMarketSim
{
    partial class PurchaseRoundDisplay
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpTeams = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCommodities = new System.Windows.Forms.FlowLayoutPanel();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblRoundNumber = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpTeams
            // 
            this.flpTeams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpTeams.AutoScroll = true;
            this.flpTeams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flpTeams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpTeams.Location = new System.Drawing.Point(3, 4);
            this.flpTeams.Name = "flpTeams";
            this.flpTeams.Size = new System.Drawing.Size(822, 311);
            this.flpTeams.TabIndex = 0;
            // 
            // flpCommodities
            // 
            this.flpCommodities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpCommodities.AutoScroll = true;
            this.flpCommodities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flpCommodities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpCommodities.Location = new System.Drawing.Point(3, 321);
            this.flpCommodities.Name = "flpCommodities";
            this.flpCommodities.Size = new System.Drawing.Size(822, 292);
            this.flpCommodities.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(831, 4);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(76, 34);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Round";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoundNumber
            // 
            this.lblRoundNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoundNumber.BackColor = System.Drawing.Color.White;
            this.lblRoundNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRoundNumber.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundNumber.ForeColor = System.Drawing.Color.Black;
            this.lblRoundNumber.Location = new System.Drawing.Point(831, 38);
            this.lblRoundNumber.Name = "lblRoundNumber";
            this.lblRoundNumber.Size = new System.Drawing.Size(76, 81);
            this.lblRoundNumber.TabIndex = 3;
            this.lblRoundNumber.Text = "1";
            this.lblRoundNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.Enabled = false;
            this.btnFinish.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(830, 537);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(77, 76);
            this.btnFinish.TabIndex = 4;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnFill
            // 
            this.btnFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFill.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFill.Location = new System.Drawing.Point(830, 239);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(77, 76);
            this.btnFill.TabIndex = 5;
            this.btnFill.Text = "Fill Empty";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.button1_Click);
            // 
            // PurchaseRoundDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lblRoundNumber);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.flpCommodities);
            this.Controls.Add(this.flpTeams);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PurchaseRoundDisplay";
            this.Size = new System.Drawing.Size(910, 616);
            this.Load += new System.EventHandler(this.PurchaseRoundDisplay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTeams;
        private System.Windows.Forms.FlowLayoutPanel flpCommodities;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label lblRoundNumber;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnFill;
    }
}
