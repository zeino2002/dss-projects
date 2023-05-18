
namespace carRental
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rows = new System.Windows.Forms.Label();
            this.columns = new System.Windows.Forms.Label();
            this.columntxt = new System.Windows.Forms.TextBox();
            this.rowtxt = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.panelveiw = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rows
            // 
            this.rows.AutoSize = true;
            this.rows.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rows.Location = new System.Drawing.Point(99, 15);
            this.rows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rows.Name = "rows";
            this.rows.Size = new System.Drawing.Size(75, 31);
            this.rows.TabIndex = 0;
            this.rows.Text = "Rows";
            // 
            // columns
            // 
            this.columns.AutoSize = true;
            this.columns.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns.Location = new System.Drawing.Point(99, 62);
            this.columns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.columns.Name = "columns";
            this.columns.Size = new System.Drawing.Size(114, 31);
            this.columns.TabIndex = 1;
            this.columns.Text = "Columns";
            // 
            // columntxt
            // 
            this.columntxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columntxt.Location = new System.Drawing.Point(245, 65);
            this.columntxt.Margin = new System.Windows.Forms.Padding(4);
            this.columntxt.Name = "columntxt";
            this.columntxt.Size = new System.Drawing.Size(43, 26);
            this.columntxt.TabIndex = 2;
            // 
            // rowtxt
            // 
            this.rowtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowtxt.Location = new System.Drawing.Point(245, 21);
            this.rowtxt.Margin = new System.Windows.Forms.Padding(4);
            this.rowtxt.Name = "rowtxt";
            this.rowtxt.Size = new System.Drawing.Size(43, 26);
            this.rowtxt.TabIndex = 3;
            // 
            // Generate
            // 
            this.Generate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Generate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate.Location = new System.Drawing.Point(548, 11);
            this.Generate.Margin = new System.Windows.Forms.Padding(4);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(116, 55);
            this.Generate.TabIndex = 4;
            this.Generate.Text = "Maximax";
            this.Generate.UseVisualStyleBackColor = false;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // panelveiw
            // 
            this.panelveiw.Location = new System.Drawing.Point(37, 116);
            this.panelveiw.Margin = new System.Windows.Forms.Padding(4);
            this.panelveiw.Name = "panelveiw";
            this.panelveiw.Size = new System.Drawing.Size(1072, 441);
            this.panelveiw.TabIndex = 5;
            this.panelveiw.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(409, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Maximin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(693, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 55);
            this.button2.TabIndex = 8;
            this.button2.Text = "equally";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(817, 11);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 55);
            this.button3.TabIndex = 7;
            this.button3.Text = "Minimax Regret";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 583);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelveiw);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.rowtxt);
            this.Controls.Add(this.columntxt);
            this.Controls.Add(this.columns);
            this.Controls.Add(this.rows);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rows;
        private System.Windows.Forms.Label columns;
        private System.Windows.Forms.TextBox columntxt;
        private System.Windows.Forms.TextBox rowtxt;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Panel panelveiw;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

