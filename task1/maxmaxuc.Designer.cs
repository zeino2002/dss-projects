
namespace carRental
{
    partial class maxmaxuc
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
            this.maxmaxdg = new System.Windows.Forms.DataGridView();
            this.maxmaxlbl = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.maxmaxdg)).BeginInit();
            this.SuspendLayout();
            // 
            // maxmaxdg
            // 
            this.maxmaxdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maxmaxdg.Location = new System.Drawing.Point(278, 15);
            this.maxmaxdg.Name = "maxmaxdg";
            this.maxmaxdg.Size = new System.Drawing.Size(499, 257);
            this.maxmaxdg.TabIndex = 0;
            this.maxmaxdg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.maxmaxdg_CellContentClick);
            // 
            // maxmaxlbl
            // 
            this.maxmaxlbl.AutoSize = true;
            this.maxmaxlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxmaxlbl.Location = new System.Drawing.Point(160, 100);
            this.maxmaxlbl.Name = "maxmaxlbl";
            this.maxmaxlbl.Size = new System.Drawing.Size(0, 25);
            this.maxmaxlbl.TabIndex = 2;
            this.maxmaxlbl.Click += new System.EventHandler(this.maxmaxlbl_Click);
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(506, 292);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(129, 40);
            this.calculate.TabIndex = 3;
            this.calculate.Text = "calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Maximax";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // maxmaxuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.maxmaxlbl);
            this.Controls.Add(this.maxmaxdg);
            this.Name = "maxmaxuc";
            this.Size = new System.Drawing.Size(804, 358);
            this.Load += new System.EventHandler(this.maxmaxuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maxmaxdg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView maxmaxdg;
        private System.Windows.Forms.Label maxmaxlbl;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label label1;
    }
}
