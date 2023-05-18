using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carRental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Generate_Click(object sender, EventArgs e)
        {
            int row = int.Parse(rowtxt.Text.ToString());
            int column = int.Parse(columntxt.Text.ToString());

            maxmaxuc mmuc = new maxmaxuc(row, column);
            panelveiw.Controls.Clear();
            panelveiw.Controls.Add(mmuc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int row = int.Parse(rowtxt.Text.ToString());
            int column = int.Parse(columntxt.Text.ToString());

            maximin min = new maximin(row, column);
            panelveiw.Controls.Clear();
            panelveiw.Controls.Add(min);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int row = int.Parse(rowtxt.Text.ToString());
            int column = int.Parse(columntxt.Text.ToString());
            MinimaxRegret minimaxRegret = new MinimaxRegret(row,column);
            panelveiw.Controls.Clear();
            panelveiw.Controls.Add(minimaxRegret);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int row = int.Parse(rowtxt.Text.ToString());
            int column = int.Parse(columntxt.Text.ToString());
            equally equallyRegret = new equally(row, column);
            panelveiw.Controls.Clear();
            panelveiw.Controls.Add(equallyRegret);
        }
    }
}
