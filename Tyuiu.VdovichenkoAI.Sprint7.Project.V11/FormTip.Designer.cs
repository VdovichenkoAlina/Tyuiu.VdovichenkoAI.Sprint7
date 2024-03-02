
namespace Tyuiu.VdovichenkoAI.Sprint7.Project.V11
{
    partial class FormTip_VAI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTip_VAI));
            this.textBoxTip_VAI = new System.Windows.Forms.TextBox();
            this.buttonOK_VAI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTip_VAI
            // 
            this.textBoxTip_VAI.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTip_VAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTip_VAI.Location = new System.Drawing.Point(14, 12);
            this.textBoxTip_VAI.Multiline = true;
            this.textBoxTip_VAI.Name = "textBoxTip_VAI";
            this.textBoxTip_VAI.ReadOnly = true;
            this.textBoxTip_VAI.Size = new System.Drawing.Size(1064, 190);
            this.textBoxTip_VAI.TabIndex = 0;
            this.textBoxTip_VAI.Text = resources.GetString("textBoxTip_VAI.Text");
            // 
            // buttonOK_VAI
            // 
            this.buttonOK_VAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK_VAI.Location = new System.Drawing.Point(974, 208);
            this.buttonOK_VAI.Name = "buttonOK_VAI";
            this.buttonOK_VAI.Size = new System.Drawing.Size(104, 37);
            this.buttonOK_VAI.TabIndex = 1;
            this.buttonOK_VAI.Text = "OK";
            this.buttonOK_VAI.UseVisualStyleBackColor = true;
            this.buttonOK_VAI.Click += new System.EventHandler(this.buttonOK_VAI_Click);
            // 
            // FormTip_VAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 257);
            this.Controls.Add(this.buttonOK_VAI);
            this.Controls.Add(this.textBoxTip_VAI);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.Name = "FormTip_VAI";
            this.Text = "Подсказка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTip_VAI;
        private System.Windows.Forms.Button buttonOK_VAI;
    }
}