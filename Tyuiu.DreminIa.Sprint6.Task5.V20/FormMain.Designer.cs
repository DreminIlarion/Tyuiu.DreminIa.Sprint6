
namespace Tyuiu.SheludkovAA.Sprint6.Task5.V20
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTask_SAA = new System.Windows.Forms.Panel();
            this.buttonHelp_SAA = new System.Windows.Forms.Button();
            this.buttonOpen_SAA = new System.Windows.Forms.Button();
            this.buttonDone_SAA = new System.Windows.Forms.Button();
            this.groupBoxTask_SAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SAA = new System.Windows.Forms.TextBox();
            this.PanelResult_SAA = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxResult_SAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_SAA = new System.Windows.Forms.DataGridView();
            this.panelFIll_SAA = new System.Windows.Forms.Panel();
            this.chartResult_SAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTask_SAA.SuspendLayout();
            this.groupBoxTask_SAA.SuspendLayout();
            this.PanelResult_SAA.SuspendLayout();
            this.groupBoxResult_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAA)).BeginInit();
            this.panelFIll_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask_SAA
            // 
            this.panelTask_SAA.Controls.Add(this.buttonHelp_SAA);
            this.panelTask_SAA.Controls.Add(this.buttonOpen_SAA);
            this.panelTask_SAA.Controls.Add(this.buttonDone_SAA);
            this.panelTask_SAA.Controls.Add(this.groupBoxTask_SAA);
            this.panelTask_SAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_SAA.Location = new System.Drawing.Point(0, 0);
            this.panelTask_SAA.Name = "panelTask_SAA";
            this.panelTask_SAA.Size = new System.Drawing.Size(840, 99);
            this.panelTask_SAA.TabIndex = 0;
            // 
            // buttonHelp_SAA
            // 
            this.buttonHelp_SAA.Location = new System.Drawing.Point(708, 21);
            this.buttonHelp_SAA.Name = "buttonHelp_SAA";
            this.buttonHelp_SAA.Size = new System.Drawing.Size(121, 63);
            this.buttonHelp_SAA.TabIndex = 0;
            this.buttonHelp_SAA.Text = "Справка";
            this.buttonHelp_SAA.UseVisualStyleBackColor = true;
            this.buttonHelp_SAA.Click += new System.EventHandler(this.buttonHelp_SAA_Click);
            // 
            // buttonOpen_SAA
            // 
            this.buttonOpen_SAA.Location = new System.Drawing.Point(581, 21);
            this.buttonOpen_SAA.Name = "buttonOpen_SAA";
            this.buttonOpen_SAA.Size = new System.Drawing.Size(121, 63);
            this.buttonOpen_SAA.TabIndex = 0;
            this.buttonOpen_SAA.Text = "Открыть файл";
            this.buttonOpen_SAA.UseVisualStyleBackColor = true;
            this.buttonOpen_SAA.Click += new System.EventHandler(this.buttonOpen_SAA_Click);
            // 
            // buttonDone_SAA
            // 
            this.buttonDone_SAA.Location = new System.Drawing.Point(443, 21);
            this.buttonDone_SAA.Name = "buttonDone_SAA";
            this.buttonDone_SAA.Size = new System.Drawing.Size(121, 63);
            this.buttonDone_SAA.TabIndex = 1;
            this.buttonDone_SAA.Text = "Выполнить";
            this.buttonDone_SAA.UseVisualStyleBackColor = true;
            this.buttonDone_SAA.Click += new System.EventHandler(this.buttonDone_SAA_Click);
            // 
            // groupBoxTask_SAA
            // 
            this.groupBoxTask_SAA.Controls.Add(this.textBoxTask_SAA);
            this.groupBoxTask_SAA.Location = new System.Drawing.Point(7, 8);
            this.groupBoxTask_SAA.Name = "groupBoxTask_SAA";
            this.groupBoxTask_SAA.Size = new System.Drawing.Size(419, 85);
            this.groupBoxTask_SAA.TabIndex = 0;
            this.groupBoxTask_SAA.TabStop = false;
            this.groupBoxTask_SAA.Text = "Условие";
            // 
            // textBoxTask_SAA
            // 
            this.textBoxTask_SAA.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_SAA.Multiline = true;
            this.textBoxTask_SAA.Name = "textBoxTask_SAA";
            this.textBoxTask_SAA.ReadOnly = true;
            this.textBoxTask_SAA.Size = new System.Drawing.Size(407, 57);
            this.textBoxTask_SAA.TabIndex = 0;
            this.textBoxTask_SAA.Text = "Прочитать данные из файла InPutFileTask5.txt и вывести данные в dataGridView все " +
    "чётные значения, построить диаграмму по этим значениям";
            // 
            // PanelResult_SAA
            // 
            this.PanelResult_SAA.Controls.Add(this.groupBoxResult_SAA);
            this.PanelResult_SAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelResult_SAA.Location = new System.Drawing.Point(0, 99);
            this.PanelResult_SAA.Name = "PanelResult_SAA";
            this.PanelResult_SAA.Size = new System.Drawing.Size(167, 351);
            this.PanelResult_SAA.TabIndex = 1;
            // 
            // groupBoxResult_SAA
            // 
            this.groupBoxResult_SAA.Controls.Add(this.dataGridViewResult_SAA);
            this.groupBoxResult_SAA.Location = new System.Drawing.Point(3, 3);
            this.groupBoxResult_SAA.Name = "groupBoxResult_SAA";
            this.groupBoxResult_SAA.Size = new System.Drawing.Size(153, 335);
            this.groupBoxResult_SAA.TabIndex = 0;
            this.groupBoxResult_SAA.TabStop = false;
            this.groupBoxResult_SAA.Text = "Результат";
            // 
            // dataGridViewResult_SAA
            // 
            this.dataGridViewResult_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResult_SAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SAA.ColumnHeadersVisible = false;
            this.dataGridViewResult_SAA.Location = new System.Drawing.Point(9, 19);
            this.dataGridViewResult_SAA.Name = "dataGridViewResult_SAA";
            this.dataGridViewResult_SAA.RowHeadersVisible = false;
            this.dataGridViewResult_SAA.Size = new System.Drawing.Size(132, 303);
            this.dataGridViewResult_SAA.TabIndex = 0;
            // 
            // panelFIll_SAA
            // 
            this.panelFIll_SAA.Controls.Add(this.chartResult_SAA);
            this.panelFIll_SAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFIll_SAA.Location = new System.Drawing.Point(167, 99);
            this.panelFIll_SAA.Name = "panelFIll_SAA";
            this.panelFIll_SAA.Size = new System.Drawing.Size(673, 351);
            this.panelFIll_SAA.TabIndex = 2;
            // 
            // chartResult_SAA
            // 
            this.chartResult_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartResult_SAA.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartResult_SAA.Legends.Add(legend2);
            this.chartResult_SAA.Location = new System.Drawing.Point(9, 9);
            this.chartResult_SAA.Name = "chartResult_SAA";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartResult_SAA.Series.Add(series2);
            this.chartResult_SAA.Size = new System.Drawing.Size(652, 328);
            this.chartResult_SAA.TabIndex = 0;
            this.chartResult_SAA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.panelFIll_SAA);
            this.Controls.Add(this.PanelResult_SAA);
            this.Controls.Add(this.panelTask_SAA);
            this.MinimumSize = new System.Drawing.Size(856, 489);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTask_SAA.ResumeLayout(false);
            this.groupBoxTask_SAA.ResumeLayout(false);
            this.groupBoxTask_SAA.PerformLayout();
            this.PanelResult_SAA.ResumeLayout(false);
            this.groupBoxResult_SAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAA)).EndInit();
            this.panelFIll_SAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask_SAA;
        private System.Windows.Forms.Button buttonHelp_SAA;
        private System.Windows.Forms.Button buttonOpen_SAA;
        private System.Windows.Forms.Button buttonDone_SAA;
        private System.Windows.Forms.GroupBox groupBoxTask_SAA;
        private System.Windows.Forms.FlowLayoutPanel PanelResult_SAA;
        private System.Windows.Forms.GroupBox groupBoxResult_SAA;
        private System.Windows.Forms.Panel panelFIll_SAA;
        private System.Windows.Forms.TextBox textBoxTask_SAA;
        private System.Windows.Forms.DataGridView dataGridViewResult_SAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_SAA;
    }
}

