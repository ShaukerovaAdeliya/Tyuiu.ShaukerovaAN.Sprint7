
namespace Tyuiu.ShaukerovaAN.Sprint7.Project.V5
{
    partial class FormMain_SAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SAN));
            this.panelTop_SAN = new System.Windows.Forms.Panel();
            this.buttonHelp_SAN = new System.Windows.Forms.Button();
            this.panelLeft_SAN = new System.Windows.Forms.Panel();
            this.splitterPanel_SAN = new System.Windows.Forms.Splitter();
            this.panelRight_SAN = new System.Windows.Forms.Panel();
            this.panelTop_SAN.SuspendLayout();
            this.panelLeft_SAN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_SAN
            // 
            this.panelTop_SAN.Controls.Add(this.buttonHelp_SAN);
            this.panelTop_SAN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_SAN.Location = new System.Drawing.Point(0, 0);
            this.panelTop_SAN.Name = "panelTop_SAN";
            this.panelTop_SAN.Size = new System.Drawing.Size(1149, 200);
            this.panelTop_SAN.TabIndex = 0;
            // 
            // buttonHelp_SAN
            // 
            this.buttonHelp_SAN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHelp_SAN.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SAN.Image")));
            this.buttonHelp_SAN.Location = new System.Drawing.Point(1044, 12);
            this.buttonHelp_SAN.Name = "buttonHelp_SAN";
            this.buttonHelp_SAN.Size = new System.Drawing.Size(85, 78);
            this.buttonHelp_SAN.TabIndex = 0;
            this.buttonHelp_SAN.UseVisualStyleBackColor = false;
            this.buttonHelp_SAN.Click += new System.EventHandler(this.buttonHelp_SAN_MouseEnter);
            this.buttonHelp_SAN.MouseEnter += new System.EventHandler(this.buttonHelp_SAN_MouseEnter);
            // 
            // panelLeft_SAN
            // 
            this.panelLeft_SAN.Controls.Add(this.splitterPanel_SAN);
            this.panelLeft_SAN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_SAN.Location = new System.Drawing.Point(0, 200);
            this.panelLeft_SAN.Name = "panelLeft_SAN";
            this.panelLeft_SAN.Size = new System.Drawing.Size(572, 400);
            this.panelLeft_SAN.TabIndex = 1;
            // 
            // splitterPanel_SAN
            // 
            this.splitterPanel_SAN.Location = new System.Drawing.Point(0, 0);
            this.splitterPanel_SAN.Name = "splitterPanel_SAN";
            this.splitterPanel_SAN.Size = new System.Drawing.Size(3, 400);
            this.splitterPanel_SAN.TabIndex = 0;
            this.splitterPanel_SAN.TabStop = false;
            // 
            // panelRight_SAN
            // 
            this.panelRight_SAN.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight_SAN.Location = new System.Drawing.Point(578, 200);
            this.panelRight_SAN.Name = "panelRight_SAN";
            this.panelRight_SAN.Size = new System.Drawing.Size(571, 400);
            this.panelRight_SAN.TabIndex = 2;
            // 
            // FormMain_SAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 600);
            this.Controls.Add(this.panelRight_SAN);
            this.Controls.Add(this.panelLeft_SAN);
            this.Controls.Add(this.panelTop_SAN);
            this.Name = "FormMain_SAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оптовая база";
            this.panelTop_SAN.ResumeLayout(false);
            this.panelLeft_SAN.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_SAN;
        private System.Windows.Forms.Panel panelLeft_SAN;
        private System.Windows.Forms.Splitter splitterPanel_SAN;
        private System.Windows.Forms.Panel panelRight_SAN;
        private System.Windows.Forms.Button buttonHelp_SAN;
    }
}

