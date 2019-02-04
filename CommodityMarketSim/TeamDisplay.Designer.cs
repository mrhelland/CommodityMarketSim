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
            this.pbCommodity = new System.Windows.Forms.PictureBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.imgsCommodities = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCommodity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFunds
            // 
            this.lblFunds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFunds.AutoEllipsis = true;
            this.lblFunds.BackColor = System.Drawing.Color.White;
            this.lblFunds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFunds.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunds.ForeColor = System.Drawing.Color.Black;
            this.lblFunds.Location = new System.Drawing.Point(70, 38);
            this.lblFunds.Margin = new System.Windows.Forms.Padding(1, 1, 3, 3);
            this.lblFunds.Name = "lblFunds";
            this.lblFunds.Size = new System.Drawing.Size(93, 30);
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
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(70, 4);
            this.lblName.Margin = new System.Windows.Forms.Padding(1, 3, 3, 1);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(93, 30);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Team Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbIcon
            // 
            this.pbIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbIcon.Location = new System.Drawing.Point(4, 4);
            this.pbIcon.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(64, 64);
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
            // pbCommodity
            // 
            this.pbCommodity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCommodity.BackColor = System.Drawing.Color.White;
            this.pbCommodity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCommodity.Image = ((System.Drawing.Image)(resources.GetObject("pbCommodity.Image")));
            this.pbCommodity.Location = new System.Drawing.Point(99, 73);
            this.pbCommodity.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.pbCommodity.Name = "pbCommodity";
            this.pbCommodity.Size = new System.Drawing.Size(64, 64);
            this.pbCommodity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCommodity.TabIndex = 7;
            this.pbCommodity.TabStop = false;
            this.pbCommodity.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbCommodity_DragDrop);
            this.pbCommodity.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbCommodity_DragEnter);
            this.pbCommodity.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.pbCommodity_QueryContinueDrag);
            this.pbCommodity.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbCommodity_MouseDown);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantity.AutoEllipsis = true;
            this.lblQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Gray;
            this.lblQuantity.Location = new System.Drawing.Point(4, 107);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(1, 1, 3, 3);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(93, 30);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "0 units";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoEllipsis = true;
            this.lblPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Gray;
            this.lblPrice.Location = new System.Drawing.Point(4, 73);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(1, 3, 3, 1);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(93, 30);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "0 bc";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // 
            // TeamDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.pbCommodity);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.lblFunds);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "TeamDisplay";
            this.Size = new System.Drawing.Size(166, 140);
            this.Load += new System.EventHandler(this.TeamDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCommodity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFunds;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.ImageList imgsTeams;
        private System.Windows.Forms.PictureBox pbCommodity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ImageList imgsCommodities;
    }
}
