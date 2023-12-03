using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GurevskayaVE.Sprint6.Task2.V11.Lib;

namespace Tyuiu.GurevskayaVE.Sprint6.Task2.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonInfo_GVE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студент группы АСОиУБ 23-3 Дремин И.А", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_GVE_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxVarA_GVE.Text);
                int stopStep = Convert.ToInt32(textBoxVarB_GVE.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartRes_GVE.Titles.Add("График функции cos(x)");
                this.chartRes_GVE.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartRes_GVE.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.DataGridViewRes_GVE.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartRes_GVE.Series[0].Points.AddXY(startStep, valueArray[i]); ;
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void buttonDone_GVE_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_GVE.BackColor = Color.Red;
        }

        private void buttonDone_GVE_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_GVE.BackColor = Color.Green;
        }

        private void buttonDone_GVE_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_GVE.BackColor = Color.Blue;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
