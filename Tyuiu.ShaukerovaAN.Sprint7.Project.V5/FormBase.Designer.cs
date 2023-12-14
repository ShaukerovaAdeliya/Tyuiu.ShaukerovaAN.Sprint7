
namespace Tyuiu.ShaukerovaAN.Sprint7.Project.V5
{
    partial class FormBase_SAN
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
            this.dataGridViewDataBase_SAN = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBase_SAN)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDataBase_SAN
            // 
            this.dataGridViewDataBase_SAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataBase_SAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDataBase_SAN.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDataBase_SAN.Name = "dataGridViewDataBase_SAN";
            this.dataGridViewDataBase_SAN.Size = new System.Drawing.Size(998, 534);
            this.dataGridViewDataBase_SAN.TabIndex = 0;
            // 
            // FormBase_SAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(998, 534);
            this.Controls.Add(this.dataGridViewDataBase_SAN);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormBase_SAN";
            this.Text = "База данных оптовых баз";
            this.Load += new System.EventHandler(this.FormBase_SAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBase_SAN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDataBase_SAN;
    }
}