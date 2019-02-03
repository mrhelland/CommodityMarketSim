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
            this.lblFunds = new System.Windows.Forms.Label();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblTeamNumber = new System.Windows.Forms.Label();
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
            this.lblFunds.Location = new System.Drawing.Point(4, 97);
            this.lblFunds.Margin = new System.Windows.Forms.Padding(4);
            this.lblFunds.Name = "lblFunds";
            this.lblFunds.Size = new System.Drawing.Size(177, 39);
            this.lblFunds.TabIndex = 5;
            this.lblFunds.Text = "$0";
            this.lblFunds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTeamName
            // 
            this.lblTeamName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTeamName.AutoEllipsis = true;
            this.lblTeamName.BackColor = System.Drawing.Color.White;
            this.lblTeamName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.ForeColor = System.Drawing.Color.Black;
            this.lblTeamName.Location = new System.Drawing.Point(4, 51);
            this.lblTeamName.Margin = new System.Windows.Forms.Padding(4);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(177, 39);
            this.lblTeamName.TabIndex = 4;
            this.lblTeamName.Text = "Team Name";
            this.lblTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTeamNumber
            // 
            this.lblTeamNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTeamNumber.AutoEllipsis = true;
            this.lblTeamNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTeamNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamNumber.ForeColor = System.Drawing.Color.White;
            this.lblTeamNumber.Location = new System.Drawing.Point(4, 4);
            this.lblTeamNumber.Margin = new System.Windows.Forms.Padding(4);
            this.lblTeamNumber.Name = "lblTeamNumber";
            this.lblTeamNumber.Size = new System.Drawing.Size(177, 39);
            this.lblTeamNumber.TabIndex = 3;
            this.lblTeamNumber.Text = "Team 1";
            this.lblTeamNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TeamDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFunds);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.lblTeamNumber);
            this.Name = "TeamDisplay";
            this.Size = new System.Drawing.Size(185, 145);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFunds;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblTeamNumber;
    }
}
