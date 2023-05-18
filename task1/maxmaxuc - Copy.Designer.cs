
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
            this.maxmaxdg.Location = new System.Drawing.Point(367, 15);
            this.maxmaxdg.Name = "maxmaxdg";
            this.maxmaxdg.Size = new System.Drawing.Size(410, 244);
            this.maxmaxdg.TabIndex = 0;
            // 
            // maxmaxlbl
            // 
            this.maxmaxlbl.AutoSize = true;
            this.maxmaxlbl.Location = new System.Drawing.Point(124, 65);
            this.maxmaxlbl.Name = "maxmaxlbl";
            this.maxmaxlbl.Size = new System.Drawing.Size(0, 13);
            this.maxmaxlbl.TabIndex = 2;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(489, 309);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 3;
            this.calculate.Text = "calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "MaxMaxIs";
            // 
            // maxmaxuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
