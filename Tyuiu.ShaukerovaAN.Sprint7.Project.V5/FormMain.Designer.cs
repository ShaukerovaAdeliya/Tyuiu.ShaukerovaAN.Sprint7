
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SAN));
            this.panelTop_SAN = new System.Windows.Forms.Panel();
            this.buttonOProgramme_SAN = new System.Windows.Forms.Button();
            this.buttonHelp_SAN = new System.Windows.Forms.Button();
            this.panelLeft_SAN = new System.Windows.Forms.Panel();
            this.splitterPanel_SAN = new System.Windows.Forms.Splitter();
            this.panelFill_SAN = new System.Windows.Forms.Panel();
            this.openFileDialogButton_SAN = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_SAN = new System.Windows.Forms.ToolTip(this.components);
            this.labelOptovayaBasa_SAN = new System.Windows.Forms.Label();
            this.buttonOpenFile_SAN = new System.Windows.Forms.Button();
            this.buttonSaveFile_SAN = new System.Windows.Forms.Button();
            this.buttonAdd_SAN = new System.Windows.Forms.Button();
            this.panelTop_SAN.SuspendLayout();
            this.panelFill_SAN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_SAN
            // 
            this.panelTop_SAN.BackColor = System.Drawing.Color.Brown;
            this.panelTop_SAN.Controls.Add(this.labelOptovayaBasa_SAN);
            this.panelTop_SAN.Controls.Add(this.buttonOProgramme_SAN);
            this.panelTop_SAN.Controls.Add(this.buttonHelp_SAN);
            this.panelTop_SAN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_SAN.Location = new System.Drawing.Point(0, 0);
            this.panelTop_SAN.Name = "panelTop_SAN";
            this.panelTop_SAN.Size = new System.Drawing.Size(1271, 103);
            this.panelTop_SAN.TabIndex = 0;
            // 
            // buttonOProgramme_SAN
            // 
            this.buttonOProgramme_SAN.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOProgramme_SAN.Image = ((System.Drawing.Image)(resources.GetObject("buttonOProgramme_SAN.Image")));
            this.buttonOProgramme_SAN.Location = new System.Drawing.Point(1097, 12);
            this.buttonOProgramme_SAN.Name = "buttonOProgramme_SAN";
            this.buttonOProgramme_SAN.Size = new System.Drawing.Size(69, 66);
            this.buttonOProgramme_SAN.TabIndex = 1;
            this.buttonOProgramme_SAN.UseVisualStyleBackColor = false;
            this.buttonOProgramme_SAN.Click += new System.EventHandler(this.buttonOProgramme_SAN_Click);
            this.buttonOProgramme_SAN.MouseEnter += new System.EventHandler(this.buttonOProgramme_SAN_MouseEnter);
            this.buttonOProgramme_SAN.MouseLeave += new System.EventHandler(this.buttonOProgramme_SAN_MouseLeave);
            // 
            // buttonHelp_SAN
            // 
            this.buttonHelp_SAN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SAN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHelp_SAN.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SAN.Image")));
            this.buttonHelp_SAN.Location = new System.Drawing.Point(1183, 12);
            this.buttonHelp_SAN.Name = "buttonHelp_SAN";
            this.buttonHelp_SAN.Size = new System.Drawing.Size(68, 66);
            this.buttonHelp_SAN.TabIndex = 0;
            this.toolTipButton_SAN.SetToolTip(this.buttonHelp_SAN, "Сведение о программе");
            this.buttonHelp_SAN.UseVisualStyleBackColor = false;
            this.buttonHelp_SAN.Click += new System.EventHandler(this.buttonHelp_SAN_MouseEnter);
            this.buttonHelp_SAN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonHelp_SAN_MouseClick);
            this.buttonHelp_SAN.MouseEnter += new System.EventHandler(this.buttonHelp_SAN_MouseEnter);
            // 
            // panelLeft_SAN
            // 
            this.panelLeft_SAN.BackColor = System.Drawing.SystemColors.Control;
            this.panelLeft_SAN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_SAN.Location = new System.Drawing.Point(0, 103);
            this.panelLeft_SAN.Name = "panelLeft_SAN";
            this.panelLeft_SAN.Size = new System.Drawing.Size(440, 574);
            this.panelLeft_SAN.TabIndex = 1;
            // 
            // splitterPanel_SAN
            // 
            this.splitterPanel_SAN.Location = new System.Drawing.Point(440, 103);
            this.splitterPanel_SAN.Name = "splitterPanel_SAN";
            this.splitterPanel_SAN.Size = new System.Drawing.Size(10, 574);
            this.splitterPanel_SAN.TabIndex = 2;
            this.splitterPanel_SAN.TabStop = false;
            // 
            // panelFill_SAN
            // 
            this.panelFill_SAN.BackColor = System.Drawing.SystemColors.Control;
            this.panelFill_SAN.Controls.Add(this.buttonAdd_SAN);
            this.panelFill_SAN.Controls.Add(this.buttonSaveFile_SAN);
            this.panelFill_SAN.Controls.Add(this.buttonOpenFile_SAN);
            this.panelFill_SAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_SAN.Location = new System.Drawing.Point(450, 103);
            this.panelFill_SAN.Name = "panelFill_SAN";
            this.panelFill_SAN.Size = new System.Drawing.Size(821, 574);
            this.panelFill_SAN.TabIndex = 3;
            // 
            // openFileDialogButton_SAN
            // 
            this.openFileDialogButton_SAN.FileName = "openFileDialog1";
            // 
            // toolTipButton_SAN
            // 
            this.toolTipButton_SAN.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // labelOptovayaBasa_SAN
            // 
            this.labelOptovayaBasa_SAN.AutoSize = true;
            this.labelOptovayaBasa_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOptovayaBasa_SAN.Location = new System.Drawing.Point(21, 23);
            this.labelOptovayaBasa_SAN.Name = "labelOptovayaBasa_SAN";
            this.labelOptovayaBasa_SAN.Size = new System.Drawing.Size(411, 55);
            this.labelOptovayaBasa_SAN.TabIndex = 2;
            this.labelOptovayaBasa_SAN.Text = "ОПТОВАЯ БАЗА";
            // 
            // buttonOpenFile_SAN
            // 
            this.buttonOpenFile_SAN.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SAN.Image")));
            this.buttonOpenFile_SAN.Location = new System.Drawing.Point(6, 136);
            this.buttonOpenFile_SAN.Name = "buttonOpenFile_SAN";
            this.buttonOpenFile_SAN.Size = new System.Drawing.Size(74, 71);
            this.buttonOpenFile_SAN.TabIndex = 0;
            this.buttonOpenFile_SAN.UseVisualStyleBackColor = true;
            // 
            // buttonSaveFile_SAN
            // 
            this.buttonSaveFile_SAN.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_SAN.Image")));
            this.buttonSaveFile_SAN.Location = new System.Drawing.Point(6, 213);
            this.buttonSaveFile_SAN.Name = "buttonSaveFile_SAN";
            this.buttonSaveFile_SAN.Size = new System.Drawing.Size(74, 71);
            this.buttonSaveFile_SAN.TabIndex = 1;
            this.buttonSaveFile_SAN.UseVisualStyleBackColor = true;
            // 
            // buttonAdd_SAN
            // 
            this.buttonAdd_SAN.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd_SAN.Image")));
            this.buttonAdd_SAN.Location = new System.Drawing.Point(6, 290);
            this.buttonAdd_SAN.Name = "buttonAdd_SAN";
            this.buttonAdd_SAN.Size = new System.Drawing.Size(74, 71);
            this.buttonAdd_SAN.TabIndex = 2;
            this.buttonAdd_SAN.UseVisualStyleBackColor = true;
            // 
            // FormMain_SAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 677);
            this.Controls.Add(this.panelFill_SAN);
            this.Controls.Add(this.splitterPanel_SAN);
            this.Controls.Add(this.panelLeft_SAN);
            this.Controls.Add(this.panelTop_SAN);
            this.Name = "FormMain_SAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оптовая база";
            this.panelTop_SAN.ResumeLayout(false);
            this.panelTop_SAN.PerformLayout();
            this.panelFill_SAN.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_SAN;
        private System.Windows.Forms.Button buttonHelp_SAN;
        private System.Windows.Forms.Panel panelLeft_SAN;
        private System.Windows.Forms.Splitter splitterPanel_SAN;
        private System.Windows.Forms.Panel panelFill_SAN;
        private System.Windows.Forms.ToolTip toolTipButton_SAN;
        private System.Windows.Forms.OpenFileDialog openFileDialogButton_SAN;
        private System.Windows.Forms.Button buttonOProgramme_SAN;
        private System.Windows.Forms.Label labelOptovayaBasa_SAN;
        private System.Windows.Forms.Button buttonAdd_SAN;
        private System.Windows.Forms.Button buttonSaveFile_SAN;
        private System.Windows.Forms.Button buttonOpenFile_SAN;
    }
}

