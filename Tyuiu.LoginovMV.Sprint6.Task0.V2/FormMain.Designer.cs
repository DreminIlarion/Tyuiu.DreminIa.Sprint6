
namespace Tyuiu.LoginovMV.Sprint6.Task0.V2
{
    partial class FormMain_LMV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_LMV));
            this.groupBoxCondition_LMV = new System.Windows.Forms.GroupBox();
            this.pictureBoxEquation_LMV = new System.Windows.Forms.PictureBox();
            this.textBoxCondition_LMV = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_LMV = new System.Windows.Forms.GroupBox();
            this.textBoxInPut_LMV = new System.Windows.Forms.TextBox();
            this.labelX_LMV = new System.Windows.Forms.Label();
            this.groupBoxOutPut_LMV = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult_LMV = new System.Windows.Forms.Label();
            this.buttonHelp_LMV = new System.Windows.Forms.Button();
            this.buttonDone_LMV = new System.Windows.Forms.Button();
            this.groupBoxCondition_LMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquation_LMV)).BeginInit();
            this.groupBoxInPut_LMV.SuspendLayout();
            this.groupBoxOutPut_LMV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_LMV
            // 
            this.groupBoxCondition_LMV.Controls.Add(this.pictureBoxEquation_LMV);
            this.groupBoxCondition_LMV.Controls.Add(this.textBoxCondition_LMV);
            this.groupBoxCondition_LMV.Location = new System.Drawing.Point(9, 8);
            this.groupBoxCondition_LMV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCondition_LMV.Name = "groupBoxCondition_LMV";
            this.groupBoxCondition_LMV.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCondition_LMV.Size = new System.Drawing.Size(517, 105);
            this.groupBoxCondition_LMV.TabIndex = 0;
            this.groupBoxCondition_LMV.TabStop = false;
            this.groupBoxCondition_LMV.Text = "Условие";
            // 
            // pictureBoxEquation_LMV
            // 
            this.pictureBoxEquation_LMV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEquation_LMV.Image")));
            this.pictureBoxEquation_LMV.Location = new System.Drawing.Point(322, 17);
            this.pictureBoxEquation_LMV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxEquation_LMV.Name = "pictureBoxEquation_LMV";
            this.pictureBoxEquation_LMV.Size = new System.Drawing.Size(159, 75);
            this.pictureBoxEquation_LMV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEquation_LMV.TabIndex = 1;
            this.pictureBoxEquation_LMV.TabStop = false;
            // 
            // textBoxCondition_LMV
            // 
            this.textBoxCondition_LMV.Location = new System.Drawing.Point(5, 17);
            this.textBoxCondition_LMV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCondition_LMV.Multiline = true;
            this.textBoxCondition_LMV.Name = "textBoxCondition_LMV";
            this.textBoxCondition_LMV.ReadOnly = true;
            this.textBoxCondition_LMV.Size = new System.Drawing.Size(273, 86);
            this.textBoxCondition_LMV.TabIndex = 0;
            this.textBoxCondition_LMV.Text = "Дано выражение вычислить его значение при x = 3.\r\nОкруглить до трёх знаков после " +
    "запятой.";
            // 
            // groupBoxInPut_LMV
            // 
            this.groupBoxInPut_LMV.Controls.Add(this.textBoxInPut_LMV);
            this.groupBoxInPut_LMV.Controls.Add(this.labelX_LMV);
            this.groupBoxInPut_LMV.Location = new System.Drawing.Point(8, 129);
            this.groupBoxInPut_LMV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInPut_LMV.Name = "groupBoxInPut_LMV";
            this.groupBoxInPut_LMV.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInPut_LMV.Size = new System.Drawing.Size(323, 103);
            this.groupBoxInPut_LMV.TabIndex = 1;
            this.groupBoxInPut_LMV.TabStop = false;
            this.groupBoxInPut_LMV.Text = "Ввод данных";
            // 
            // textBoxInPut_LMV
            // 
            this.textBoxInPut_LMV.Location = new System.Drawing.Point(8, 48);
            this.textBoxInPut_LMV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxInPut_LMV.Name = "textBoxInPut_LMV";
            this.textBoxInPut_LMV.Size = new System.Drawing.Size(81, 20);
            this.textBoxInPut_LMV.TabIndex = 1;
            this.textBoxInPut_LMV.TextChanged += new System.EventHandler(this.textBoxInPut_LMV_TextChanged);
            this.textBoxInPut_LMV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInPut_LMV_KeyPress);
            // 
            // labelX_LMV
            // 
            this.labelX_LMV.AutoSize = true;
            this.labelX_LMV.Location = new System.Drawing.Point(5, 26);
            this.labelX_LMV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX_LMV.Name = "labelX_LMV";
            this.labelX_LMV.Size = new System.Drawing.Size(84, 13);
            this.labelX_LMV.TabIndex = 0;
            this.labelX_LMV.Text = "Переменная Х:";
            // 
            // groupBoxOutPut_LMV
            // 
            this.groupBoxOutPut_LMV.Controls.Add(this.textBoxResult);
            this.groupBoxOutPut_LMV.Controls.Add(this.labelResult_LMV);
            this.groupBoxOutPut_LMV.Location = new System.Drawing.Point(345, 135);
            this.groupBoxOutPut_LMV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOutPut_LMV.Name = "groupBoxOutPut_LMV";
            this.groupBoxOutPut_LMV.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOutPut_LMV.Size = new System.Drawing.Size(181, 97);
            this.groupBoxOutPut_LMV.TabIndex = 2;
            this.groupBoxOutPut_LMV.TabStop = false;
            this.groupBoxOutPut_LMV.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(7, 42);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(61, 20);
            this.textBoxResult.TabIndex = 1;
            // 
            // labelResult_LMV
            // 
            this.labelResult_LMV.AutoSize = true;
            this.labelResult_LMV.Location = new System.Drawing.Point(5, 20);
            this.labelResult_LMV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult_LMV.Name = "labelResult_LMV";
            this.labelResult_LMV.Size = new System.Drawing.Size(62, 13);
            this.labelResult_LMV.TabIndex = 0;
            this.labelResult_LMV.Text = "Результат:";
            // 
            // buttonHelp_LMV
            // 
            this.buttonHelp_LMV.Location = new System.Drawing.Point(345, 245);
            this.buttonHelp_LMV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonHelp_LMV.Name = "buttonHelp_LMV";
            this.buttonHelp_LMV.Size = new System.Drawing.Size(45, 40);
            this.buttonHelp_LMV.TabIndex = 3;
            this.buttonHelp_LMV.Text = "?";
            this.buttonHelp_LMV.UseVisualStyleBackColor = true;
            this.buttonHelp_LMV.Click += new System.EventHandler(this.buttonHelp_LMV_Click);
            // 
            // buttonDone_LMV
            // 
            this.buttonDone_LMV.Location = new System.Drawing.Point(403, 245);
            this.buttonDone_LMV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDone_LMV.Name = "buttonDone_LMV";
            this.buttonDone_LMV.Size = new System.Drawing.Size(123, 40);
            this.buttonDone_LMV.TabIndex = 4;
            this.buttonDone_LMV.Text = "Выполнить";
            this.buttonDone_LMV.UseVisualStyleBackColor = true;
            this.buttonDone_LMV.Click += new System.EventHandler(this.buttonDone_LMV_Click);
            // 
            // FormMain_LMV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.buttonDone_LMV);
            this.Controls.Add(this.buttonHelp_LMV);
            this.Controls.Add(this.groupBoxOutPut_LMV);
            this.Controls.Add(this.groupBoxInPut_LMV);
            this.Controls.Add(this.groupBoxCondition_LMV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormMain_LMV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 2 | Дремин И.А";
            this.Load += new System.EventHandler(this.FormMain_LMV_Load);
            this.groupBoxCondition_LMV.ResumeLayout(false);
            this.groupBoxCondition_LMV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquation_LMV)).EndInit();
            this.groupBoxInPut_LMV.ResumeLayout(false);
            this.groupBoxInPut_LMV.PerformLayout();
            this.groupBoxOutPut_LMV.ResumeLayout(false);
            this.groupBoxOutPut_LMV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_LMV;
        private System.Windows.Forms.PictureBox pictureBoxEquation_LMV;
        private System.Windows.Forms.TextBox textBoxCondition_LMV;
        private System.Windows.Forms.GroupBox groupBoxInPut_LMV;
        private System.Windows.Forms.TextBox textBoxInPut_LMV;
        private System.Windows.Forms.Label labelX_LMV;
        private System.Windows.Forms.GroupBox groupBoxOutPut_LMV;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult_LMV;
        private System.Windows.Forms.Button buttonHelp_LMV;
        private System.Windows.Forms.Button buttonDone_LMV;
    }
}

