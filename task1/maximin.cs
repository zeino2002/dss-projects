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
    public partial class maximin : UserControl
    {
        int nrow, ncolumn;
        public maximin(int rows , int columns)
        {
            InitializeComponent();



            nrow = rows;
            ncolumn = columns;
            maxmaxdg.RowCount = rows;
            maxmaxdg.ColumnCount = columns;
        }

        private void maxmaxdg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maximin_Load(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            int cell = int.Parse(maxmaxdg.Rows[0].Cells[0].Value.ToString());
            List<int> mylist = new List<int>();
            for (int i = 0; i < nrow; i++)
            {
                for (int a = 1; a < ncolumn; a++)
                {
                    if (int.Parse(maxmaxdg.Rows[i].Cells[a].Value.ToString()) < cell)
                    {
                        cell = int.Parse(maxmaxdg.Rows[i].Cells[a].Value.ToString());

                    }
                }
                mylist.Add(cell);
            }
            maxmaxlbl.Text = mylist.Min().ToString();
        }
    }
}
