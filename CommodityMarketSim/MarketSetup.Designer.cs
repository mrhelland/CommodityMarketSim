﻿
namespace CommodityMarketSim {
    partial class MarketSetup {
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
            this.label1 = new System.Windows.Forms.Label();
            this.numTeamQuantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMonetarySymbol = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numTeamBudget = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numTeamQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTeamBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teams:";
            // 
            // numTeamQuantity
            // 
            this.numTeamQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTeamQuantity.Location = new System.Drawing.Point(16, 45);
            this.numTeamQuantity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTeamQuantity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numTeamQuantity.Name = "numTeamQuantity";
            this.numTeamQuantity.Size = new System.Drawing.Size(120, 26);
            this.numTeamQuantity.TabIndex = 1;
            this.numTeamQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTeamQuantity.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(157, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monetary Symbol:";
            // 
            // txtMonetarySymbol
            // 
            this.txtMonetarySymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonetarySymbol.Location = new System.Drawing.Point(161, 45);
            this.txtMonetarySymbol.MaxLength = 3;
            this.txtMonetarySymbol.Name = "txtMonetarySymbol";
            this.txtMonetarySymbol.Size = new System.Drawing.Size(120, 26);
            this.txtMonetarySymbol.TabIndex = 3;
            this.txtMonetarySymbol.Text = "ↂ";
            this.txtMonetarySymbol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(16, 128);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 40);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Create...";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(307, 128);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(161, 128);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 40);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load...";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(303, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Team Budget:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numTeamBudget
            // 
            this.numTeamBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTeamBudget.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTeamBudget.Location = new System.Drawing.Point(307, 46);
            this.numTeamBudget.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numTeamBudget.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTeamBudget.Name = "numTeamBudget";
            this.numTeamBudget.Size = new System.Drawing.Size(120, 26);
            this.numTeamBudget.TabIndex = 8;
            this.numTeamBudget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTeamBudget.Value = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            // 
            // MarketSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(445, 257);
            this.Controls.Add(this.numTeamBudget);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtMonetarySymbol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numTeamQuantity);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MarketSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Market Setup";
            this.Load += new System.EventHandler(this.MarketSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTeamQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTeamBudget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numTeamQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMonetarySymbol;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numTeamBudget;
    }
}