
namespace Tyuiu.VdovichenkoAI.Sprint7.Project.V11
{
    partial class FormAboutProgram_VAI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutProgram_VAI));
            this.pictureBoxImagine_VAI = new System.Windows.Forms.PictureBox();
            this.textBoxDescription_VAI = new System.Windows.Forms.TextBox();
            this.buttonOK_VAI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagine_VAI)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImagine_VAI
            // 
            this.pictureBoxImagine_VAI.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImagine_VAI.Image")));
            this.pictureBoxImagine_VAI.Location = new System.Drawing.Point(12, 1);
            this.pictureBoxImagine_VAI.Name = "pictureBoxImagine_VAI";
            this.pictureBoxImagine_VAI.Size = new System.Drawing.Size(211, 204);
            this.pictureBoxImagine_VAI.TabIndex = 1;
            this.pictureBoxImagine_VAI.TabStop = false;
            // 
            // textBoxDescription_VAI
            // 
            this.textBoxDescription_VAI.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDescription_VAI.Location = new System.Drawing.Point(229, 1);
            this.textBoxDescription_VAI.Multiline = true;
            this.textBoxDescription_VAI.Name = "textBoxDescription_VAI";
            this.textBoxDescription_VAI.ReadOnly = true;
            this.textBoxDescription_VAI.Size = new System.Drawing.Size(262, 204);
            this.textBoxDescription_VAI.TabIndex = 2;
            this.textBoxDescription_VAI.Text = "Разработчик: Вдовиченко А. И.\r\nгруппа ИИПБ-23-1\r\n\r\nПрограмма разработана в рамках" +
    " изучения C#\r\n\r\nТюменски индустриальный университет (с) 2023\r\nВысшая школа цифро" +
    "вых технологий (с) 2023";
            // 
            // buttonOK_VAI
            // 
            this.buttonOK_VAI.Location = new System.Drawing.Point(416, 224);
            this.buttonOK_VAI.Name = "buttonOK_VAI";
            this.buttonOK_VAI.Size = new System.Drawing.Size(75, 29);
            this.buttonOK_VAI.TabIndex = 3;
            this.buttonOK_VAI.Text = "OK";
            this.buttonOK_VAI.UseVisualStyleBackColor = true;
            this.buttonOK_VAI.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAboutProgram_VAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 265);
            this.Controls.Add(this.buttonOK_VAI);
            this.Controls.Add(this.textBoxDescription_VAI);
            this.Controls.Add(this.pictureBoxImagine_VAI);
            this.Name = "FormAboutProgram_VAI";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagine_VAI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImagine_VAI;
        private System.Windows.Forms.TextBox textBoxDescription_VAI;
        private System.Windows.Forms.Button buttonOK_VAI;
    }
}