using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SheludkovAA.Sprint6.Task5.V20.Lib;

namespace Tyuiu.SheludkovAA.Sprint6.Task5.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        DataService ds = new DataService();
        string path = @"C:\Users\Hines\source\repos\Tyuiu.DreminIa.Sprint66\Solution6\Tyuiu.DreminIa.Sprint6.Task5.V20\bin\Debug\InPutFileTask5V20.txt";

        private void buttonHelp_SAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУб-23-1 Шелудков Алексей Андреевич", "Сведения о работе");
        }

        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
            dataGridViewResult_SAA.ColumnCount = 2;
            dataGridViewResult_SAA.Columns[0].Width = 20;
            dataGridViewResult_SAA.Columns[1].Width = 50;

            this.chartResult_SAA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_SAA.ChartAreas[0].AxisY.Title = "Ось Y";
            chartResult_SAA.Series[0].Points.Clear();
            double[] arr = new double[ds.len];
            arr = ds.LoadFromDataFile(path);
            for (int i = 0; i < arr.Length; i++)
            {
                dataGridViewResult_SAA.Rows.Add(Convert.ToString(i), Convert.ToString(arr[i]));
                chartResult_SAA.Series[0].Points.AddXY(i, arr[i]);
            }
        }

        private void buttonOpen_SAA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
