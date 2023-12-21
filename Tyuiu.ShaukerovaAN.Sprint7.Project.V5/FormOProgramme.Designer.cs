
namespace Tyuiu.ShaukerovaAN.Sprint7.Project.V5
{
    partial class FormOProgramme_SAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOProgramme_SAN));
            this.textBoxOProgramme_SAN = new System.Windows.Forms.TextBox();
            this.buttonClose_SAN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxOProgramme_SAN
            // 
            this.textBoxOProgramme_SAN.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxOProgramme_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOProgramme_SAN.Location = new System.Drawing.Point(12, 12);
            this.textBoxOProgramme_SAN.Multiline = true;
            this.textBoxOProgramme_SAN.Name = "textBoxOProgramme_SAN";
            this.textBoxOProgramme_SAN.ReadOnly = true;
            this.textBoxOProgramme_SAN.Size = new System.Drawing.Size(864, 631);
            this.textBoxOProgramme_SAN.TabIndex = 0;
            this.textBoxOProgramme_SAN.Text = resources.GetString("textBoxOProgramme_SAN.Text");
            // 
            // buttonClose_SAN
            // 
            this.buttonClose_SAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClose_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose_SAN.Location = new System.Drawing.Point(742, 649);
            this.buttonClose_SAN.Name = "buttonClose_SAN";
            this.buttonClose_SAN.Size = new System.Drawing.Size(134, 31);
            this.buttonClose_SAN.TabIndex = 1;
            this.buttonClose_SAN.Text = "Закрыть";
            this.buttonClose_SAN.UseVisualStyleBackColor = false;
            this.buttonClose_SAN.Click += new System.EventHandler(this.buttonClose_SAN_Click);
            // 
            // FormOProgramme_SAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(888, 693);
            this.Controls.Add(this.buttonClose_SAN);
            this.Controls.Add(this.textBoxOProgramme_SAN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(904, 732);
            this.Name = "FormOProgramme_SAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О нас";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOProgramme_SAN;
        private System.Windows.Forms.Button buttonClose_SAN;
    }
}