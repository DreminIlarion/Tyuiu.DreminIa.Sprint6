using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.BelovaEA.Sprint6.Task4.V20.Lib;
using System.IO;

namespace Tyuiu.BelovaEA.Sprint6.Task4.V20
{
    public partial class FormMain_BEA : Form
    {
        public FormMain_BEA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonHelp_BEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы ИИПб-23-1 Белова Екатерина Андреевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDo_BEA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_BEA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_BEA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_BEA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_BEA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_BEA.Text = "";

                chartFunction_BEA.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chartFunction_BEA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_BEA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }

                
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSave_BEA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V20.txt";
                File.WriteAllText(path, textBoxResult_BEA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
               
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDo_BEA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonDo_BEA.Cursor = System.Windows.Forms.Cursors.Hand;
        }
        private void buttonSave_BEA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonSave_BEA.Cursor = System.Windows.Forms.Cursors.Hand;
        }
        private void buttonHelp_BEA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonHelp_BEA.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void FormMain_BEA_Load(object sender, EventArgs e)
        {

        }
    }
}
