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
using Tyuiu.LachuginAV.Sprint6.Task7.V26.Lib;

namespace Tyuiu.LachuginAV.Sprint6.Task7.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_LAV.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_LAV.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
        }

        static string openFilePath;
        static int rows;
        static int columns;
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpen_LAV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_LAV.ShowDialog();
            openFilePath = openFileDialogTask_LAV.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewVar_LAV.ColumnCount = columns;
            dataGridViewVar_LAV.RowCount = rows;
            dataGridViewResult_LAV.ColumnCount = columns;
            dataGridViewResult_LAV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewVar_LAV.Columns[i].Width = 25;
                dataGridViewResult_LAV.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewVar_LAV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
            buttonDone_LAV.Enabled = true;
        }

        private void buttonDone_LAV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewResult_LAV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_LAV.Enabled = true;
        }

        private void buttonSave_LAV_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_LAV.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_LAV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_LAV.ShowDialog();

            string path = saveFileDialogMatrix_LAV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewResult_LAV.RowCount;
            int columns = dataGridViewResult_LAV.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewResult_LAV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewResult_LAV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonInfo_LAV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}