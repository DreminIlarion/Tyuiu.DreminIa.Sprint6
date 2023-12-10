
namespace Tyuiu.LachuginAV.Sprint6.Task7.V26
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTopButton_LAV = new System.Windows.Forms.Panel();
            this.buttonInfo_LAV = new System.Windows.Forms.Button();
            this.buttonSave_LAV = new System.Windows.Forms.Button();
            this.buttonDone_LAV = new System.Windows.Forms.Button();
            this.buttonOpen_LAV = new System.Windows.Forms.Button();
            this.panelTopTask_LAV = new System.Windows.Forms.Panel();
            this.groupBoxTask_LAV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_LAV = new System.Windows.Forms.TextBox();
            this.panelLeft_LAV = new System.Windows.Forms.Panel();
            this.groupBoxVar_LAV = new System.Windows.Forms.GroupBox();
            this.dataGridViewVar_LAV = new System.Windows.Forms.DataGridView();
            this.panelFill_LAV = new System.Windows.Forms.Panel();
            this.groupBoxResult_LAV = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_LAV = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_LAV = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_LAV = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_LAV = new System.Windows.Forms.SaveFileDialog();
            this.panelTopButton_LAV.SuspendLayout();
            this.panelTopTask_LAV.SuspendLayout();
            this.groupBoxTask_LAV.SuspendLayout();
            this.panelLeft_LAV.SuspendLayout();
            this.groupBoxVar_LAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVar_LAV)).BeginInit();
            this.panelFill_LAV.SuspendLayout();
            this.groupBoxResult_LAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_LAV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopButton_LAV
            // 
            this.panelTopButton_LAV.BackColor = System.Drawing.SystemColors.Control;
            this.panelTopButton_LAV.Controls.Add(this.buttonInfo_LAV);
            this.panelTopButton_LAV.Controls.Add(this.buttonSave_LAV);
            this.panelTopButton_LAV.Controls.Add(this.buttonDone_LAV);
            this.panelTopButton_LAV.Controls.Add(this.buttonOpen_LAV);
            this.panelTopButton_LAV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopButton_LAV.Location = new System.Drawing.Point(0, 0);
            this.panelTopButton_LAV.Name = "panelTopButton_LAV";
            this.panelTopButton_LAV.Size = new System.Drawing.Size(884, 82);
            this.panelTopButton_LAV.TabIndex = 0;
            // 
            // buttonInfo_LAV
            // 
            this.buttonInfo_LAV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_LAV.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonInfo_LAV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_LAV.Location = new System.Drawing.Point(782, 9);
            this.buttonInfo_LAV.Name = "buttonInfo_LAV";
            this.buttonInfo_LAV.Size = new System.Drawing.Size(90, 63);
            this.buttonInfo_LAV.TabIndex = 0;
            this.buttonInfo_LAV.Text = "Справка";
            this.toolTipButton_LAV.SetToolTip(this.buttonInfo_LAV, "Сведение о программе.");
            this.buttonInfo_LAV.UseVisualStyleBackColor = false;
            this.buttonInfo_LAV.Click += new System.EventHandler(this.buttonInfo_LAV_Click);
            // 
            // buttonSave_LAV
            // 
            this.buttonSave_LAV.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSave_LAV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_LAV.Location = new System.Drawing.Point(204, 9);
            this.buttonSave_LAV.Name = "buttonSave_LAV";
            this.buttonSave_LAV.Size = new System.Drawing.Size(90, 63);
            this.buttonSave_LAV.TabIndex = 0;
            this.buttonSave_LAV.Text = "Сохранить";
            this.toolTipButton_LAV.SetToolTip(this.buttonSave_LAV, "Сохраняет матрицу.");
            this.buttonSave_LAV.UseVisualStyleBackColor = false;
            this.buttonSave_LAV.Click += new System.EventHandler(this.buttonSave_LAV_Click);
            // 
            // buttonDone_LAV
            // 
            this.buttonDone_LAV.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonDone_LAV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_LAV.Location = new System.Drawing.Point(108, 9);
            this.buttonDone_LAV.Name = "buttonDone_LAV";
            this.buttonDone_LAV.Size = new System.Drawing.Size(90, 63);
            this.buttonDone_LAV.TabIndex = 0;
            this.buttonDone_LAV.Text = "Выполнить";
            this.toolTipButton_LAV.SetToolTip(this.buttonDone_LAV, "Производит поиск в матрице положительных значений больше 5 и заменяет на значение" +
        " 222");
            this.buttonDone_LAV.UseVisualStyleBackColor = false;
            this.buttonDone_LAV.Click += new System.EventHandler(this.buttonDone_LAV_Click);
            // 
            // buttonOpen_LAV
            // 
            this.buttonOpen_LAV.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonOpen_LAV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen_LAV.Location = new System.Drawing.Point(12, 9);
            this.buttonOpen_LAV.Name = "buttonOpen_LAV";
            this.buttonOpen_LAV.Size = new System.Drawing.Size(90, 63);
            this.buttonOpen_LAV.TabIndex = 0;
            this.buttonOpen_LAV.Text = "Открыть";
            this.toolTipButton_LAV.SetToolTip(this.buttonOpen_LAV, "Открыть файл\r\nВыберите нужный файл для обработки.\r\n");
            this.buttonOpen_LAV.UseVisualStyleBackColor = false;
            this.buttonOpen_LAV.Click += new System.EventHandler(this.buttonOpen_LAV_Click);
            // 
            // panelTopTask_LAV
            // 
            this.panelTopTask_LAV.Controls.Add(this.groupBoxTask_LAV);
            this.panelTopTask_LAV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopTask_LAV.Location = new System.Drawing.Point(0, 82);
            this.panelTopTask_LAV.Name = "panelTopTask_LAV";
            this.panelTopTask_LAV.Size = new System.Drawing.Size(884, 74);
            this.panelTopTask_LAV.TabIndex = 1;
            // 
            // groupBoxTask_LAV
            // 
            this.groupBoxTask_LAV.Controls.Add(this.textBoxTask_LAV);
            this.groupBoxTask_LAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_LAV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_LAV.Name = "groupBoxTask_LAV";
            this.groupBoxTask_LAV.Size = new System.Drawing.Size(884, 74);
            this.groupBoxTask_LAV.TabIndex = 0;
            this.groupBoxTask_LAV.TabStop = false;
            this.groupBoxTask_LAV.Text = "Условие";
            // 
            // textBoxTask_LAV
            // 
            this.textBoxTask_LAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_LAV.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxTask_LAV.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_LAV.Multiline = true;
            this.textBoxTask_LAV.Name = "textBoxTask_LAV";
            this.textBoxTask_LAV.ReadOnly = true;
            this.textBoxTask_LAV.Size = new System.Drawing.Size(878, 55);
            this.textBoxTask_LAV.TabIndex = 0;
            // 
            // panelLeft_LAV
            // 
            this.panelLeft_LAV.Controls.Add(this.groupBoxVar_LAV);
            this.panelLeft_LAV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_LAV.Location = new System.Drawing.Point(0, 156);
            this.panelLeft_LAV.Name = "panelLeft_LAV";
            this.panelLeft_LAV.Size = new System.Drawing.Size(425, 405);
            this.panelLeft_LAV.TabIndex = 1;
            // 
            // groupBoxVar_LAV
            // 
            this.groupBoxVar_LAV.Controls.Add(this.dataGridViewVar_LAV);
            this.groupBoxVar_LAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxVar_LAV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxVar_LAV.Name = "groupBoxVar_LAV";
            this.groupBoxVar_LAV.Size = new System.Drawing.Size(425, 405);
            this.groupBoxVar_LAV.TabIndex = 0;
            this.groupBoxVar_LAV.TabStop = false;
            this.groupBoxVar_LAV.Text = "Ввод:";
            // 
            // dataGridViewVar_LAV
            // 
            this.dataGridViewVar_LAV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVar_LAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVar_LAV.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewVar_LAV.Name = "dataGridViewVar_LAV";
            this.dataGridViewVar_LAV.Size = new System.Drawing.Size(419, 386);
            this.dataGridViewVar_LAV.TabIndex = 0;
            // 
            // panelFill_LAV
            // 
            this.panelFill_LAV.Controls.Add(this.groupBoxResult_LAV);
            this.panelFill_LAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_LAV.Location = new System.Drawing.Point(425, 156);
            this.panelFill_LAV.Name = "panelFill_LAV";
            this.panelFill_LAV.Size = new System.Drawing.Size(459, 405);
            this.panelFill_LAV.TabIndex = 1;
            // 
            // groupBoxResult_LAV
            // 
            this.groupBoxResult_LAV.Controls.Add(this.dataGridViewResult_LAV);
            this.groupBoxResult_LAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_LAV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_LAV.Name = "groupBoxResult_LAV";
            this.groupBoxResult_LAV.Size = new System.Drawing.Size(459, 405);
            this.groupBoxResult_LAV.TabIndex = 0;
            this.groupBoxResult_LAV.TabStop = false;
            this.groupBoxResult_LAV.Text = "Вывод:";
            // 
            // dataGridViewResult_LAV
            // 
            this.dataGridViewResult_LAV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_LAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_LAV.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult_LAV.Name = "dataGridViewResult_LAV";
            this.dataGridViewResult_LAV.Size = new System.Drawing.Size(453, 386);
            this.dataGridViewResult_LAV.TabIndex = 0;
            // 
            // openFileDialogTask_LAV
            // 
            this.openFileDialogTask_LAV.FileName = "openFileDialog1";
            // 
            // toolTipButton_LAV
            // 
            this.toolTipButton_LAV.IsBalloon = true;
            this.toolTipButton_LAV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_LAV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panelFill_LAV);
            this.Controls.Add(this.panelLeft_LAV);
            this.Controls.Add(this.panelTopTask_LAV);
            this.Controls.Add(this.panelTopButton_LAV);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 26 | Дремин ИА";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTopButton_LAV.ResumeLayout(false);
            this.panelTopTask_LAV.ResumeLayout(false);
            this.groupBoxTask_LAV.ResumeLayout(false);
            this.groupBoxTask_LAV.PerformLayout();
            this.panelLeft_LAV.ResumeLayout(false);
            this.groupBoxVar_LAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVar_LAV)).EndInit();
            this.panelFill_LAV.ResumeLayout(false);
            this.groupBoxResult_LAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_LAV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopButton_LAV;
        private System.Windows.Forms.Button buttonSave_LAV;
        private System.Windows.Forms.Button buttonDone_LAV;
        private System.Windows.Forms.Button buttonOpen_LAV;
        private System.Windows.Forms.Panel panelTopTask_LAV;
        private System.Windows.Forms.Panel panelLeft_LAV;
        private System.Windows.Forms.Panel panelFill_LAV;
        private System.Windows.Forms.Button buttonInfo_LAV;
        private System.Windows.Forms.GroupBox groupBoxTask_LAV;
        private System.Windows.Forms.TextBox textBoxTask_LAV;
        private System.Windows.Forms.GroupBox groupBoxVar_LAV;
        private System.Windows.Forms.DataGridView dataGridViewVar_LAV;
        private System.Windows.Forms.GroupBox groupBoxResult_LAV;
        private System.Windows.Forms.DataGridView dataGridViewResult_LAV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_LAV;
        private System.Windows.Forms.ToolTip toolTipButton_LAV;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_LAV;
    }
}