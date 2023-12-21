
namespace Tyuiu.ShaukerovaAN.Sprint7.Project.V5
{
    partial class FormAbout_SAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_SAN));
            this.buttonOk_SAN = new System.Windows.Forms.Button();
            this.labelInfo_SAN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOk_SAN
            // 
            this.buttonOk_SAN.Location = new System.Drawing.Point(288, 222);
            this.buttonOk_SAN.Name = "buttonOk_SAN";
            this.buttonOk_SAN.Size = new System.Drawing.Size(119, 37);
            this.buttonOk_SAN.TabIndex = 0;
            this.buttonOk_SAN.Text = "ОК";
            this.buttonOk_SAN.UseVisualStyleBackColor = true;
            this.buttonOk_SAN.Click += new System.EventHandler(this.buttonOK_SAN_Click);
            // 
            // labelInfo_SAN
            // 
            this.labelInfo_SAN.AutoSize = true;
            this.labelInfo_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo_SAN.Location = new System.Drawing.Point(12, 9);
            this.labelInfo_SAN.Name = "labelInfo_SAN";
            this.labelInfo_SAN.Size = new System.Drawing.Size(384, 198);
            this.labelInfo_SAN.TabIndex = 1;
            this.labelInfo_SAN.Text = resources.GetString("labelInfo_SAN.Text");
            // 
            // FormAbout_SAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 271);
            this.Controls.Add(this.labelInfo_SAN);
            this.Controls.Add(this.buttonOk_SAN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(436, 310);
            this.Name = "FormAbout_SAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о разработчике ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk_SAN;
        private System.Windows.Forms.Label labelInfo_SAN;
    }
}