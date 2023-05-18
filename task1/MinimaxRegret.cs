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
    public partial class MinimaxRegret : UserControl
    {
        public MinimaxRegret(int row,int column)
        {
            InitializeComponent();
            maxmaxdg.RowCount = row;
            maxmaxdg.ColumnCount = column;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            int rowCount = maxmaxdg.Rows.Count;
            int columnCount = maxmaxdg.Columns.Count;
            double[,] newArray = new double[rowCount, columnCount];

            for (int j = 0; j < columnCount; j++)
            {
                double max = double.MinValue;
                for (int i = 0; i < rowCount; i++)
                {
                    double cellValue = Convert.ToDouble(maxmaxdg.Rows[i].Cells[j].Value);
                    if (cellValue > max)
                    {
                        max = cellValue;
                    }
                }

                for (int i = 0; i < rowCount; i++)
                {
                    double cellValue = Convert.ToDouble(maxmaxdg.Rows[i].Cells[j].Value);
                    newArray[i, j] = max - cellValue;
                }
            }
            List<double> maxValues = new List<double>();
            for (int i = 0; i < rowCount; i++)
            {
                double max = double.MinValue;
                for (int j = 0; j < columnCount; j++)
                {
                    double cellValue = newArray[i, j];
                    if (cellValue > max)
                    {
                        max = cellValue;
                    }
                }
                maxValues.Add(max);
            }
            double Miniregret = maxValues[0];
            for (int i = 0; i < maxValues.Count; i++)
            {
                if (maxValues[i] < Miniregret)
                {
                    Miniregret = maxValues[i];
                }
            }
            Minimaxregret_lbl.Text = Miniregret.ToString();

        }

    }
}

