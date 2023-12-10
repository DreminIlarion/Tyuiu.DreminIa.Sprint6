using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.MartysevichAD.Sprint6.Task6.V17.Lib;

namespace Tyuiu.MartysevichAD.Sprint6.Task6.V17
{
    public partial class FormMain : Form
    {
        string openFilePath;
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonOpenFileDialog_MAD_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MAD.ShowDialog();
            openFilePath = openFileDialogTask_MAD.FileName;
            textBoxIn_MAD.Text = File.ReadAllText(openFilePath);
            groupBoxOut_MAD.Text = groupBoxOut_MAD.Text + " " + openFileDialogTask_MAD.FileName;
            buttonUp_MAD.Enabled = true;
        }

        private void buttonUp_MAD_Click(object sender, EventArgs e)
        {
            textBoxOut_MAD.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonInfo_MAD_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
