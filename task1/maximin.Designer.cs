﻿
namespace carRental
{
    partial class maximin
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
            this.label1 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.maxmaxlbl = new System.Windows.Forms.Label();
            this.maxmaxdg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.maxmaxdg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Maximin";
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(492, 294);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(119, 42);
            this.calculate.TabIndex = 7;
            this.calculate.Text = "calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // maxmaxlbl
            // 
            this.maxmaxlbl.AutoSize = true;
            this.maxmaxlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxmaxlbl.Location = new System.Drawing.Point(162, 70);
            this.maxmaxlbl.Name = "maxmaxlbl";
            this.maxmaxlbl.Size = new System.Drawing.Size(0, 25);
            this.maxmaxlbl.TabIndex = 6;
            // 
            // maxmaxdg
            // 
            this.maxmaxdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maxmaxdg.Location = new System.Drawing.Point(286, 19);
            this.maxmaxdg.Name = "maxmaxdg";
            this.maxmaxdg.Size = new System.Drawing.Size(484, 244);
            this.maxmaxdg.TabIndex = 5;
            this.maxmaxdg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.maxmaxdg_CellContentClick);
            // 
            // maximin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.maxmaxlbl);
            this.Controls.Add(this.maxmaxdg);
            this.Name = "maximin";
            this.Size = new System.Drawing.Size(792, 354);
            this.Load += new System.EventHandler(this.maximin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maxmaxdg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label maxmaxlbl;
        private System.Windows.Forms.DataGridView maxmaxdg;
    }
}
