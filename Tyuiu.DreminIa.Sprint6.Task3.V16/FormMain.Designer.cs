
namespace Tyuiu.SafronovVV.Sprint6.Task3.V16
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_SVV = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResult_SVV = new System.Windows.Forms.TextBox();
            this.buttonDone_VSS = new System.Windows.Forms.Button();
            this.buttonHelp_VSS = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SVV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dataGridViewMatrix_SVV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 347);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridViewMatrix_SVV
            // 
            this.dataGridViewMatrix_SVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_SVV.Location = new System.Drawing.Point(289, 19);
            this.dataGridViewMatrix_SVV.Name = "dataGridViewMatrix_SVV";
            this.dataGridViewMatrix_SVV.RowHeadersVisible = false;
            this.dataGridViewMatrix_SVV.Size = new System.Drawing.Size(335, 310);
            this.dataGridViewMatrix_SVV.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxResult_SVV);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox2.Location = new System.Drawing.Point(657, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 286);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод данных";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Результат";
            // 
            // textBoxResult_SVV
            // 
            this.textBoxResult_SVV.Location = new System.Drawing.Point(17, 59);
            this.textBoxResult_SVV.Name = "textBoxResult_SVV";
            this.textBoxResult_SVV.Size = new System.Drawing.Size(236, 24);
            this.textBoxResult_SVV.TabIndex = 2;
            // 
            // buttonDone_VSS
            // 
            this.buttonDone_VSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonDone_VSS.Location = new System.Drawing.Point(802, 318);
            this.buttonDone_VSS.Name = "buttonDone_VSS";
            this.buttonDone_VSS.Size = new System.Drawing.Size(126, 41);
            this.buttonDone_VSS.TabIndex = 2;
            this.buttonDone_VSS.Text = "Выполнить";
            this.buttonDone_VSS.UseVisualStyleBackColor = true;
            this.buttonDone_VSS.Click += new System.EventHandler(this.buttonDone_VSS_Click);
            // 
            // buttonHelp_VSS
            // 
            this.buttonHelp_VSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonHelp_VSS.Location = new System.Drawing.Point(670, 318);
            this.buttonHelp_VSS.Name = "buttonHelp_VSS";
            this.buttonHelp_VSS.Size = new System.Drawing.Size(126, 41);
            this.buttonHelp_VSS.TabIndex = 3;
            this.buttonHelp_VSS.Text = "Сведенье";
            this.buttonHelp_VSS.UseVisualStyleBackColor = true;
            this.buttonHelp_VSS.Click += new System.EventHandler(this.buttonHelp_VSS_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(277, 306);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Дана матрица 5 на 5\r\n14   1  -3   1  10\r\n 7  -3   5  -4   0\r\n-10 -19 -18  -9  19\r" +
    "\n -2  -2 -16   2 -17\r\n -16   9   5 -10  16\r\nЗаменить четные значения в третьей с" +
    "троке на 0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 369);
            this.Controls.Add(this.buttonHelp_VSS);
            this.Controls.Add(this.buttonDone_VSS);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 16 | Дремин И.А ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SVV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_SVV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResult_SVV;
        private System.Windows.Forms.Button buttonDone_VSS;
        private System.Windows.Forms.Button buttonHelp_VSS;
        private System.Windows.Forms.TextBox textBox1;
    }
}

