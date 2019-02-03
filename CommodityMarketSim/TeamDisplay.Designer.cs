namespace CommodityMarketSim
{
    partial class TeamDisplay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamDisplay));
            this.lblFunds = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.imgsTeams = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFunds
            // 
            this.lblFunds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFunds.AutoEllipsis = true;
            this.lblFunds.BackColor = System.Drawing.Color.White;
            this.lblFunds.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunds.ForeColor = System.Drawing.Color.Black;
            this.lblFunds.Location = new System.Drawing.Point(3, 104);
            this.lblFunds.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblFunds.Name = "lblFunds";
            this.lblFunds.Size = new System.Drawing.Size(133, 24);
            this.lblFunds.TabIndex = 5;
            this.lblFunds.Text = "$0";
            this.lblFunds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoEllipsis = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(3, 74);
            this.lblName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(133, 24);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Team Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbIcon
            // 
            this.pbIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbIcon.Location = new System.Drawing.Point(4, 4);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(132, 64);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbIcon.TabIndex = 6;
            this.pbIcon.TabStop = false;
            // 
            // imgsTeams
            // 
            this.imgsTeams.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgsTeams.ImageStream")));
            this.imgsTeams.TransparentColor = System.Drawing.Color.Transparent;
            this.imgsTeams.Images.SetKeyName(0, "1.png");
            this.imgsTeams.Images.SetKeyName(1, "2.png");
            this.imgsTeams.Images.SetKeyName(2, "3.png");
            this.imgsTeams.Images.SetKeyName(3, "4.png");
            this.imgsTeams.Images.SetKeyName(4, "5.png");
            this.imgsTeams.Images.SetKeyName(5, "6.png");
            this.imgsTeams.Images.SetKeyName(6, "7.png");
            this.imgsTeams.Images.SetKeyName(7, "8.png");
            this.imgsTeams.Images.SetKeyName(8, "9.png");
            this.imgsTeams.Images.SetKeyName(9, "10.png");
            // 
            // TeamDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.lblFunds);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TeamDisplay";
            this.Size = new System.Drawing.Size(139, 138);
            this.Load += new System.EventHandler(this.TeamDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFunds;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.ImageList imgsTeams;
    }
}
