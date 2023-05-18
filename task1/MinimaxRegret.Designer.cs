
namespace carRental
{
    partial class MinimaxRegret
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
            this.Minimaxregret_lbl = new System.Windows.Forms.Label();
            this.maxmaxdg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.maxmaxdg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Minimax";
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(653, 366);
            this.calculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(159, 52);
            this.calculate.TabIndex = 11;
            this.calculate.Text = "calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Minimaxregret_lbl
            // 
            this.Minimaxregret_lbl.AutoSize = true;
            this.Minimaxregret_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimaxregret_lbl.Location = new System.Drawing.Point(208, 75);
            this.Minimaxregret_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Minimaxregret_lbl.Name = "Minimaxregret_lbl";
            this.Minimaxregret_lbl.Size = new System.Drawing.Size(0, 31);
            this.Minimaxregret_lbl.TabIndex = 10;
            // 
            // maxmaxdg
            // 
            this.maxmaxdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maxmaxdg.Location = new System.Drawing.Point(332, 27);
            this.maxmaxdg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maxmaxdg.Name = "maxmaxdg";
            this.maxmaxdg.RowHeadersWidth = 51;
            this.maxmaxdg.Size = new System.Drawing.Size(697, 300);
            this.maxmaxdg.TabIndex = 9;
            // 
            // MinimaxRegret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.Minimaxregret_lbl);
            this.Controls.Add(this.maxmaxdg);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MinimaxRegret";
            this.Size = new System.Drawing.Size(1052, 443);
            ((System.ComponentModel.ISupportInitialize)(this.maxmaxdg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label Minimaxregret_lbl;
        private System.Windows.Forms.DataGridView maxmaxdg;
    }
}
