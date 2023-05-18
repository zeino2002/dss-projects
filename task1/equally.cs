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
    public partial class equally : UserControl
    {
        public equally(int row,int column)
        {
            InitializeComponent();
            maxmaxdg.RowCount = row;
            maxmaxdg.ColumnCount = column;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            List<int> rowSums = new List<int>();
            List<double> rowAverages = new List<double>();

            foreach (DataGridViewRow row in maxmaxdg.Rows)
            {
                int sum = 0;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString() != "")
                    {
                        sum += Convert.ToInt32(cell.Value);
                    }
                }
                rowSums.Add(sum);
                rowAverages.Add((double)sum / row.Cells.Count);
            }
            double maxAverage = rowAverages[0];
            foreach (double item in rowAverages)
            {
                if (item > maxAverage)
                {
                    maxAverage = item;
                }
            }
            maxmaxlbl.Text = maxAverage.ToString();

        }
    }
}
