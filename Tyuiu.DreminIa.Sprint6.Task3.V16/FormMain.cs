using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SafronovVV.Sprint6.Task3.V16.Lib;

namespace Tyuiu.SafronovVV.Sprint6.Task3.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        
        int[,] matrix = new int[5, 5] { { 14, 1, -3, 1, 10 },
                                           { 7, -3, 5, -4, 0 },
                                           { -10, -19, -18, -9, 19 },
                                           { -2, -2, -16, 2, -17 },
                                           { -16, 9, 5, 10, 16 } };


        private void FormMain_Load(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewMatrix_SVV.ColumnCount = columns;
            dataGridViewMatrix_SVV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_SVV.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_SVV.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDone_VSS_Click(object sender, EventArgs e)
        {
            textBoxResult_SVV.Text = Convert.ToString(ds.Calculate(matrix));
            int[,] matrixres = ds.Calculate(matrix);

            int rows = matrixres.GetUpperBound(0) + 1;
            int columns = matrixres.Length / rows;

            dataGridViewMatrix_SVV.ColumnCount = columns;
            dataGridViewMatrix_SVV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_SVV.Columns[i].Width = 50;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_SVV.Rows[i].Cells[j].Value = Convert.ToString(matrixres[i, j]);
                }
            }

        }
        private void buttonHelp_VSS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУБ 23-3 Дремин И.А", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
