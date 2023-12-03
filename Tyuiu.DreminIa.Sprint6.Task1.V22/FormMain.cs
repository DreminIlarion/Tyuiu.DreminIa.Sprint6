using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZargarovAA.Sprint6.Task1.V22.Lib;
namespace Tyuiu.ZargarovAA.Sprint6.Task1.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startstep = Convert.ToInt32(textBoxStartStep.Text);
                int stopstep = Convert.ToInt32(textBoxStopStep.Text);


                string str;

                int len = ds.GetMassFunction(startstep, stopstep).Length;
                double[] func = new double[len];
                func = ds.GetMassFunction(startstep, stopstep);
                textBoxResult.Text = "";
                textBoxResult.AppendText("+-----------------------+" + Environment.NewLine);
                textBoxResult.AppendText("|     x    |    f(x)    |" + Environment.NewLine);
                textBoxResult.AppendText("+-----------------------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    str = String.Format("| {0, 6:d}   | {1, 7:f2}    |", startstep, func[i]);
                    textBoxResult.AppendText(str + Environment.NewLine);
                    startstep++;
                }
                textBoxResult.AppendText("+-----------------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonHelp_Click_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУБ 23-3 Дремин И.А", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }

}
