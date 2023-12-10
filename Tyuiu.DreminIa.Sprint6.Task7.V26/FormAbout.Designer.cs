
namespace Tyuiu.LachuginAV.Sprint6.Task7.V26
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
            this.pictureBoxAvatar_LAV = new System.Windows.Forms.PictureBox();
            this.LabelInfo_LAV = new System.Windows.Forms.Label();
            this.buttonOk_LAV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_LAV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_LAV
            // 
            this.pictureBoxAvatar_LAV.ErrorImage = null;
            this.pictureBoxAvatar_LAV.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_LAV.Name = "pictureBoxAvatar_LAV";
            this.pictureBoxAvatar_LAV.Size = new System.Drawing.Size(141, 185);
            this.pictureBoxAvatar_LAV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_LAV.TabIndex = 1;
            this.pictureBoxAvatar_LAV.TabStop = false;
            // 
            // LabelInfo_LAV
            // 
            this.LabelInfo_LAV.AutoSize = true;
            this.LabelInfo_LAV.Location = new System.Drawing.Point(169, 12);
            this.LabelInfo_LAV.Name = "LabelInfo_LAV";
            this.LabelInfo_LAV.Size = new System.Drawing.Size(0, 13);
            this.LabelInfo_LAV.TabIndex = 2;
            // 
            // buttonOk_LAV
            // 
            this.buttonOk_LAV.Location = new System.Drawing.Point(385, 172);
            this.buttonOk_LAV.Name = "buttonOk_LAV";
            this.buttonOk_LAV.Size = new System.Drawing.Size(84, 25);
            this.buttonOk_LAV.TabIndex = 3;
            this.buttonOk_LAV.Text = "Ок";
            this.buttonOk_LAV.UseVisualStyleBackColor = true;
            this.buttonOk_LAV.Click += new System.EventHandler(this.buttonOk_LAV_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 209);
            this.Controls.Add(this.buttonOk_LAV);
            this.Controls.Add(this.LabelInfo_LAV);
            this.Controls.Add(this.pictureBoxAvatar_LAV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_LAV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_LAV;
        private System.Windows.Forms.Label LabelInfo_LAV;
        private System.Windows.Forms.Button buttonOk_LAV;
    }
}