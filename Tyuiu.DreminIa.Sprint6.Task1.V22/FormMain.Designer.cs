
namespace Tyuiu.ZargarovAA.Sprint6.Task1.V22
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
            this.TextBoxСondition = new System.Windows.Forms.GroupBox();
            this.labelTask = new System.Windows.Forms.Label();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.labelStepEnd = new System.Windows.Forms.Label();
            this.labelStepBegin = new System.Windows.Forms.Label();
            this.textBoxStopStep = new System.Windows.Forms.TextBox();
            this.textBoxStartStep = new System.Windows.Forms.TextBox();
            this.buttonHelp_Click = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.TextBoxСondition.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxСondition
            // 
            this.TextBoxСondition.Controls.Add(this.labelTask);
            this.TextBoxСondition.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextBoxСondition.Location = new System.Drawing.Point(12, 12);
            this.TextBoxСondition.Name = "TextBoxСondition";
            this.TextBoxСondition.Size = new System.Drawing.Size(494, 350);
            this.TextBoxСondition.TabIndex = 0;
            this.TextBoxСondition.TabStop = false;
            this.TextBoxСondition.Text = "Условие";
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(6, 16);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(241, 78);
            this.labelTask.TabIndex = 2;
            this.labelTask.Text = "Протабулировать f(x) на заданном диапазоне \r\nРезультат вывести в виде таблицы\r\n\r\n" +
    "\r\n\r\n\r\n";
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.labelResult);
            this.groupBoxOutput.Controls.Add(this.textBoxResult);
            this.groupBoxOutput.Location = new System.Drawing.Point(512, 12);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(276, 426);
            this.groupBoxOutput.TabIndex = 0;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод данных";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(6, 22);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(59, 13);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "Результат";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(9, 38);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(261, 382);
            this.textBoxResult.TabIndex = 0;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.labelStepEnd);
            this.groupBoxInput.Controls.Add(this.labelStepBegin);
            this.groupBoxInput.Controls.Add(this.textBoxStopStep);
            this.groupBoxInput.Controls.Add(this.textBoxStartStep);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 368);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(304, 70);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных";
            // 
            // labelStepEnd
            // 
            this.labelStepEnd.AutoSize = true;
            this.labelStepEnd.Location = new System.Drawing.Point(142, 25);
            this.labelStepEnd.Name = "labelStepEnd";
            this.labelStepEnd.Size = new System.Drawing.Size(70, 13);
            this.labelStepEnd.TabIndex = 1;
            this.labelStepEnd.Text = "Конец Шага:";
            // 
            // labelStepBegin
            // 
            this.labelStepBegin.AutoSize = true;
            this.labelStepBegin.Location = new System.Drawing.Point(9, 25);
            this.labelStepBegin.Name = "labelStepBegin";
            this.labelStepBegin.Size = new System.Drawing.Size(68, 13);
            this.labelStepBegin.TabIndex = 1;
            this.labelStepBegin.Text = "Старт Шага:";
            // 
            // textBoxStopStep
            // 
            this.textBoxStopStep.Location = new System.Drawing.Point(145, 44);
            this.textBoxStopStep.Name = "textBoxStopStep";
            this.textBoxStopStep.Size = new System.Drawing.Size(133, 20);
            this.textBoxStopStep.TabIndex = 0;
            // 
            // textBoxStartStep
            // 
            this.textBoxStartStep.Location = new System.Drawing.Point(6, 44);
            this.textBoxStartStep.Name = "textBoxStartStep";
            this.textBoxStartStep.Size = new System.Drawing.Size(133, 20);
            this.textBoxStartStep.TabIndex = 0;
            // 
            // buttonHelp_Click
            // 
            this.buttonHelp_Click.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonHelp_Click.Location = new System.Drawing.Point(322, 373);
            this.buttonHelp_Click.Name = "buttonHelp_Click";
            this.buttonHelp_Click.Size = new System.Drawing.Size(65, 59);
            this.buttonHelp_Click.TabIndex = 2;
            this.buttonHelp_Click.Text = "Справка";
            this.buttonHelp_Click.UseVisualStyleBackColor = false;
            this.buttonHelp_Click.Click += new System.EventHandler(this.buttonHelp_Click_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.Green;
            this.buttonDone.Location = new System.Drawing.Point(393, 373);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(113, 59);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonHelp_Click);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.TextBoxСondition);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 22 | Дремин И.А";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.TextBoxСondition.ResumeLayout(false);
            this.TextBoxСondition.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TextBoxСondition;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label labelStepEnd;
        private System.Windows.Forms.Label labelStepBegin;
        private System.Windows.Forms.TextBox textBoxStopStep;
        private System.Windows.Forms.TextBox textBoxStartStep;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonHelp_Click;
        private System.Windows.Forms.Button buttonDone;
    }
}

