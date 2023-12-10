
namespace Tyuiu.MartysevichAD.Sprint6.Task6.V17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTopOne_MAD = new System.Windows.Forms.Panel();
            this.buttonInfo_MAD = new System.Windows.Forms.Button();
            this.buttonUp_MAD = new System.Windows.Forms.Button();
            this.buttonOpenFile_MAD = new System.Windows.Forms.Button();
            this.panelTopTwo_MAD = new System.Windows.Forms.Panel();
            this.groupBoxOne_MAD = new System.Windows.Forms.GroupBox();
            this.textBoxOne_MAD = new System.Windows.Forms.TextBox();
            this.panelLeft_MAD = new System.Windows.Forms.Panel();
            this.groupBoxIn_MAD = new System.Windows.Forms.GroupBox();
            this.textBoxIn_MAD = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelBase_MAD = new System.Windows.Forms.Panel();
            this.groupBoxOut_MAD = new System.Windows.Forms.GroupBox();
            this.textBoxOut_MAD = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_MAD = new System.Windows.Forms.OpenFileDialog();
            this.toolTipOne_MAD = new System.Windows.Forms.ToolTip(this.components);
            this.panelTopOne_MAD.SuspendLayout();
            this.panelTopTwo_MAD.SuspendLayout();
            this.groupBoxOne_MAD.SuspendLayout();
            this.panelLeft_MAD.SuspendLayout();
            this.groupBoxIn_MAD.SuspendLayout();
            this.panelBase_MAD.SuspendLayout();
            this.groupBoxOut_MAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopOne_MAD
            // 
            this.panelTopOne_MAD.Controls.Add(this.buttonInfo_MAD);
            this.panelTopOne_MAD.Controls.Add(this.buttonUp_MAD);
            this.panelTopOne_MAD.Controls.Add(this.buttonOpenFile_MAD);
            this.panelTopOne_MAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopOne_MAD.Location = new System.Drawing.Point(0, 0);
            this.panelTopOne_MAD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTopOne_MAD.Name = "panelTopOne_MAD";
            this.panelTopOne_MAD.Size = new System.Drawing.Size(664, 59);
            this.panelTopOne_MAD.TabIndex = 0;
            // 
            // buttonInfo_MAD
            // 
            this.buttonInfo_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_MAD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonInfo_MAD.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_MAD.Image")));
            this.buttonInfo_MAD.Location = new System.Drawing.Point(599, 3);
            this.buttonInfo_MAD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInfo_MAD.Name = "buttonInfo_MAD";
            this.buttonInfo_MAD.Size = new System.Drawing.Size(56, 51);
            this.buttonInfo_MAD.TabIndex = 0;
            this.buttonInfo_MAD.UseVisualStyleBackColor = false;
            this.buttonInfo_MAD.Click += new System.EventHandler(this.buttonInfo_MAD_Click);
            // 
            // buttonUp_MAD
            // 
            this.buttonUp_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUp_MAD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonUp_MAD.Image = ((System.Drawing.Image)(resources.GetObject("buttonUp_MAD.Image")));
            this.buttonUp_MAD.Location = new System.Drawing.Point(82, 2);
            this.buttonUp_MAD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUp_MAD.Name = "buttonUp_MAD";
            this.buttonUp_MAD.Size = new System.Drawing.Size(56, 51);
            this.buttonUp_MAD.TabIndex = 0;
            this.toolTipOne_MAD.SetToolTip(this.buttonUp_MAD, "Выводится третье слово каждой строки ");
            this.buttonUp_MAD.UseVisualStyleBackColor = false;
            this.buttonUp_MAD.Click += new System.EventHandler(this.buttonUp_MAD_Click);
            // 
            // buttonOpenFile_MAD
            // 
            this.buttonOpenFile_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpenFile_MAD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonOpenFile_MAD.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_MAD.Image")));
            this.buttonOpenFile_MAD.Location = new System.Drawing.Point(10, 3);
            this.buttonOpenFile_MAD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOpenFile_MAD.Name = "buttonOpenFile_MAD";
            this.buttonOpenFile_MAD.Size = new System.Drawing.Size(56, 51);
            this.buttonOpenFile_MAD.TabIndex = 0;
            this.toolTipOne_MAD.SetToolTip(this.buttonOpenFile_MAD, "Открыть файл.\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_MAD.UseVisualStyleBackColor = false;
            this.buttonOpenFile_MAD.Click += new System.EventHandler(this.buttonOpenFileDialog_MAD_Click);
            // 
            // panelTopTwo_MAD
            // 
            this.panelTopTwo_MAD.Controls.Add(this.groupBoxOne_MAD);
            this.panelTopTwo_MAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopTwo_MAD.Location = new System.Drawing.Point(0, 59);
            this.panelTopTwo_MAD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTopTwo_MAD.Name = "panelTopTwo_MAD";
            this.panelTopTwo_MAD.Size = new System.Drawing.Size(664, 78);
            this.panelTopTwo_MAD.TabIndex = 1;
            // 
            // groupBoxOne_MAD
            // 
            this.groupBoxOne_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOne_MAD.Controls.Add(this.textBoxOne_MAD);
            this.groupBoxOne_MAD.Location = new System.Drawing.Point(10, 3);
            this.groupBoxOne_MAD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOne_MAD.Name = "groupBoxOne_MAD";
            this.groupBoxOne_MAD.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOne_MAD.Size = new System.Drawing.Size(645, 70);
            this.groupBoxOne_MAD.TabIndex = 0;
            this.groupBoxOne_MAD.TabStop = false;
            this.groupBoxOne_MAD.Text = "Условие";
            // 
            // textBoxOne_MAD
            // 
            this.textBoxOne_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOne_MAD.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxOne_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOne_MAD.Location = new System.Drawing.Point(5, 18);
            this.textBoxOne_MAD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxOne_MAD.Multiline = true;
            this.textBoxOne_MAD.Name = "textBoxOne_MAD";
            this.textBoxOne_MAD.ReadOnly = true;
            this.textBoxOne_MAD.Size = new System.Drawing.Size(635, 47);
            this.textBoxOne_MAD.TabIndex = 0;
            this.textBoxOne_MAD.Text = resources.GetString("textBoxOne_MAD.Text");
            // 
            // panelLeft_MAD
            // 
            this.panelLeft_MAD.Controls.Add(this.groupBoxIn_MAD);
            this.panelLeft_MAD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_MAD.Location = new System.Drawing.Point(0, 137);
            this.panelLeft_MAD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLeft_MAD.Name = "panelLeft_MAD";
            this.panelLeft_MAD.Size = new System.Drawing.Size(334, 325);
            this.panelLeft_MAD.TabIndex = 2;
            // 
            // groupBoxIn_MAD
            // 
            this.groupBoxIn_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxIn_MAD.Controls.Add(this.textBoxIn_MAD);
            this.groupBoxIn_MAD.Location = new System.Drawing.Point(10, 6);
            this.groupBoxIn_MAD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxIn_MAD.Name = "groupBoxIn_MAD";
            this.groupBoxIn_MAD.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxIn_MAD.Size = new System.Drawing.Size(320, 310);
            this.groupBoxIn_MAD.TabIndex = 0;
            this.groupBoxIn_MAD.TabStop = false;
            this.groupBoxIn_MAD.Text = "Ввод";
            // 
            // textBoxIn_MAD
            // 
            this.textBoxIn_MAD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxIn_MAD.Location = new System.Drawing.Point(5, 18);
            this.textBoxIn_MAD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIn_MAD.Multiline = true;
            this.textBoxIn_MAD.Name = "textBoxIn_MAD";
            this.textBoxIn_MAD.ReadOnly = true;
            this.textBoxIn_MAD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIn_MAD.Size = new System.Drawing.Size(305, 281);
            this.textBoxIn_MAD.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(334, 137);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 325);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // panelBase_MAD
            // 
            this.panelBase_MAD.Controls.Add(this.groupBoxOut_MAD);
            this.panelBase_MAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase_MAD.Location = new System.Drawing.Point(336, 137);
            this.panelBase_MAD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBase_MAD.Name = "panelBase_MAD";
            this.panelBase_MAD.Size = new System.Drawing.Size(328, 325);
            this.panelBase_MAD.TabIndex = 4;
            // 
            // groupBoxOut_MAD
            // 
            this.groupBoxOut_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOut_MAD.Controls.Add(this.textBoxOut_MAD);
            this.groupBoxOut_MAD.Location = new System.Drawing.Point(6, 6);
            this.groupBoxOut_MAD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOut_MAD.Name = "groupBoxOut_MAD";
            this.groupBoxOut_MAD.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOut_MAD.Size = new System.Drawing.Size(313, 310);
            this.groupBoxOut_MAD.TabIndex = 0;
            this.groupBoxOut_MAD.TabStop = false;
            this.groupBoxOut_MAD.Text = "Вывод";
            // 
            // textBoxOut_MAD
            // 
            this.textBoxOut_MAD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxOut_MAD.Location = new System.Drawing.Point(4, 18);
            this.textBoxOut_MAD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxOut_MAD.Multiline = true;
            this.textBoxOut_MAD.Name = "textBoxOut_MAD";
            this.textBoxOut_MAD.ReadOnly = true;
            this.textBoxOut_MAD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut_MAD.Size = new System.Drawing.Size(305, 281);
            this.textBoxOut_MAD.TabIndex = 0;
            // 
            // openFileDialogTask_MAD
            // 
            this.openFileDialogTask_MAD.FileName = "openFileDialog1";
            // 
            // toolTipOne_MAD
            // 
            this.toolTipOne_MAD.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipOne_MAD.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 462);
            this.Controls.Add(this.panelBase_MAD);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelLeft_MAD);
            this.Controls.Add(this.panelTopTwo_MAD);
            this.Controls.Add(this.panelTopOne_MAD);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(680, 501);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск6 | Вариант 17 | Дремин ИА";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTopOne_MAD.ResumeLayout(false);
            this.panelTopTwo_MAD.ResumeLayout(false);
            this.groupBoxOne_MAD.ResumeLayout(false);
            this.groupBoxOne_MAD.PerformLayout();
            this.panelLeft_MAD.ResumeLayout(false);
            this.groupBoxIn_MAD.ResumeLayout(false);
            this.groupBoxIn_MAD.PerformLayout();
            this.panelBase_MAD.ResumeLayout(false);
            this.groupBoxOut_MAD.ResumeLayout(false);
            this.groupBoxOut_MAD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopOne_MAD;
        private System.Windows.Forms.Button buttonInfo_MAD;
        private System.Windows.Forms.Button buttonUp_MAD;
        private System.Windows.Forms.Button buttonOpenFile_MAD;
        private System.Windows.Forms.Panel panelTopTwo_MAD;
        private System.Windows.Forms.GroupBox groupBoxOne_MAD;
        private System.Windows.Forms.TextBox textBoxOne_MAD;
        private System.Windows.Forms.Panel panelLeft_MAD;
        private System.Windows.Forms.GroupBox groupBoxIn_MAD;
        private System.Windows.Forms.TextBox textBoxIn_MAD;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelBase_MAD;
        private System.Windows.Forms.GroupBox groupBoxOut_MAD;
        private System.Windows.Forms.TextBox textBoxOut_MAD;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_MAD;
        private System.Windows.Forms.ToolTip toolTipOne_MAD;
    }
}

