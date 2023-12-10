
namespace Tyuiu.MartysevichAD.Sprint6.Task6.V17
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.textBoxInfo_MAD = new System.Windows.Forms.TextBox();
            this.buttonOk_MAD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInfo_MAD
            // 
            this.textBoxInfo_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_MAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInfo_MAD.Location = new System.Drawing.Point(13, 13);
            this.textBoxInfo_MAD.Multiline = true;
            this.textBoxInfo_MAD.Name = "textBoxInfo_MAD";
            this.textBoxInfo_MAD.ReadOnly = true;
            this.textBoxInfo_MAD.Size = new System.Drawing.Size(544, 221);
            this.textBoxInfo_MAD.TabIndex = 0;
            this.textBoxInfo_MAD.Text = resources.GetString("textBoxInfo_MAD.Text");
            // 
            // buttonOk_MAD
            // 
            this.buttonOk_MAD.Location = new System.Drawing.Point(462, 240);
            this.buttonOk_MAD.Name = "buttonOk_MAD";
            this.buttonOk_MAD.Size = new System.Drawing.Size(85, 32);
            this.buttonOk_MAD.TabIndex = 1;
            this.buttonOk_MAD.Text = "OK";
            this.buttonOk_MAD.UseVisualStyleBackColor = true;
            this.buttonOk_MAD.Click += new System.EventHandler(this.buttonOk_MAD_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 284);
            this.Controls.Add(this.buttonOk_MAD);
            this.Controls.Add(this.textBoxInfo_MAD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(587, 331);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(587, 331);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInfo_MAD;
        private System.Windows.Forms.Button buttonOk_MAD;
    }
}