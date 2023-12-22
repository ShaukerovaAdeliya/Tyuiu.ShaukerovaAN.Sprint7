
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
            this.labelOptovayaBasa_SAN = new System.Windows.Forms.Label();
            this.buttonOProgramme_SAN = new System.Windows.Forms.Button();
            this.buttonHelp_SAN = new System.Windows.Forms.Button();
            this.panelLeft_SAN = new System.Windows.Forms.Panel();
            this.groupBoxFilter_SAN = new System.Windows.Forms.GroupBox();
            this.buttonFilter_SAN = new System.Windows.Forms.Button();
            this.comboBoxFilter_SAN = new System.Windows.Forms.ComboBox();
            this.splitterPanel_SAN = new System.Windows.Forms.Splitter();
            this.panelFill_SAN = new System.Windows.Forms.Panel();
            this.buttonDeleteRow_SAN = new System.Windows.Forms.Button();
            this.dataGridViewMatrix_SAN = new System.Windows.Forms.DataGridView();
            this.buttonAddRow_SAN = new System.Windows.Forms.Button();
            this.buttonSaveFile_SAN = new System.Windows.Forms.Button();
            this.buttonOpenFile_SAN = new System.Windows.Forms.Button();
            this.openFileDialogButton_SAN = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_SAN = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMain_SAN = new System.Windows.Forms.SaveFileDialog();
            this.panelTop_SAN.SuspendLayout();
            this.panelLeft_SAN.SuspendLayout();
            this.groupBoxFilter_SAN.SuspendLayout();
            this.panelFill_SAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SAN)).BeginInit();
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
            // buttonOProgramme_SAN
            // 
            this.buttonOProgramme_SAN.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOProgramme_SAN.Image = ((System.Drawing.Image)(resources.GetObject("buttonOProgramme_SAN.Image")));
            this.buttonOProgramme_SAN.Location = new System.Drawing.Point(1097, 12);
            this.buttonOProgramme_SAN.Name = "buttonOProgramme_SAN";
            this.buttonOProgramme_SAN.Size = new System.Drawing.Size(69, 66);
            this.buttonOProgramme_SAN.TabIndex = 1;
            this.toolTipButton_SAN.SetToolTip(this.buttonOProgramme_SAN, "Информация о программе");
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
            this.panelLeft_SAN.Controls.Add(this.groupBoxFilter_SAN);
            this.panelLeft_SAN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_SAN.Location = new System.Drawing.Point(0, 103);
            this.panelLeft_SAN.Name = "panelLeft_SAN";
            this.panelLeft_SAN.Size = new System.Drawing.Size(440, 574);
            this.panelLeft_SAN.TabIndex = 1;
            // 
            // groupBoxFilter_SAN
            // 
            this.groupBoxFilter_SAN.Controls.Add(this.buttonFilter_SAN);
            this.groupBoxFilter_SAN.Controls.Add(this.comboBoxFilter_SAN);
            this.groupBoxFilter_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFilter_SAN.Location = new System.Drawing.Point(12, 83);
            this.groupBoxFilter_SAN.Name = "groupBoxFilter_SAN";
            this.groupBoxFilter_SAN.Size = new System.Drawing.Size(221, 107);
            this.groupBoxFilter_SAN.TabIndex = 0;
            this.groupBoxFilter_SAN.TabStop = false;
            this.groupBoxFilter_SAN.Text = "Сортировка";
            // 
            // buttonFilter_SAN
            // 
            this.buttonFilter_SAN.Location = new System.Drawing.Point(93, 69);
            this.buttonFilter_SAN.Name = "buttonFilter_SAN";
            this.buttonFilter_SAN.Size = new System.Drawing.Size(122, 32);
            this.buttonFilter_SAN.TabIndex = 1;
            this.buttonFilter_SAN.Text = "Сортировать";
            this.buttonFilter_SAN.UseVisualStyleBackColor = true;
            this.buttonFilter_SAN.Click += new System.EventHandler(this.buttonFilter_SAN_Click);
            // 
            // comboBoxFilter_SAN
            // 
            this.comboBoxFilter_SAN.Items.AddRange(new object[] {
            "По алфавиту",
            "По артикулу",
            "По отделу"});
            this.comboBoxFilter_SAN.Location = new System.Drawing.Point(6, 23);
            this.comboBoxFilter_SAN.Name = "comboBoxFilter_SAN";
            this.comboBoxFilter_SAN.Size = new System.Drawing.Size(151, 26);
            this.comboBoxFilter_SAN.TabIndex = 2;
            this.comboBoxFilter_SAN.Text = "Сортировать по:";
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
            this.panelFill_SAN.Controls.Add(this.buttonDeleteRow_SAN);
            this.panelFill_SAN.Controls.Add(this.dataGridViewMatrix_SAN);
            this.panelFill_SAN.Controls.Add(this.buttonAddRow_SAN);
            this.panelFill_SAN.Controls.Add(this.buttonSaveFile_SAN);
            this.panelFill_SAN.Controls.Add(this.buttonOpenFile_SAN);
            this.panelFill_SAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_SAN.Location = new System.Drawing.Point(450, 103);
            this.panelFill_SAN.Name = "panelFill_SAN";
            this.panelFill_SAN.Size = new System.Drawing.Size(821, 574);
            this.panelFill_SAN.TabIndex = 3;
            // 
            // buttonDeleteRow_SAN
            // 
            this.buttonDeleteRow_SAN.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteRow_SAN.Image")));
            this.buttonDeleteRow_SAN.Location = new System.Drawing.Point(293, 6);
            this.buttonDeleteRow_SAN.Name = "buttonDeleteRow_SAN";
            this.buttonDeleteRow_SAN.Size = new System.Drawing.Size(74, 71);
            this.buttonDeleteRow_SAN.TabIndex = 4;
            this.toolTipButton_SAN.SetToolTip(this.buttonDeleteRow_SAN, "Удалить информацию");
            this.buttonDeleteRow_SAN.UseVisualStyleBackColor = true;
            this.buttonDeleteRow_SAN.Click += new System.EventHandler(this.buttonDeleteRow_SAN_Click);
            this.buttonDeleteRow_SAN.MouseEnter += new System.EventHandler(this.buttonDeleteRow_SAN_MouseEnter);
            this.buttonDeleteRow_SAN.MouseLeave += new System.EventHandler(this.buttonDeleteRow_SAN_MouseLeave);
            // 
            // dataGridViewMatrix_SAN
            // 
            this.dataGridViewMatrix_SAN.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMatrix_SAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_SAN.Location = new System.Drawing.Point(14, 83);
            this.dataGridViewMatrix_SAN.Name = "dataGridViewMatrix_SAN";
            this.dataGridViewMatrix_SAN.RowHeadersVisible = false;
            this.dataGridViewMatrix_SAN.Size = new System.Drawing.Size(795, 479);
            this.dataGridViewMatrix_SAN.TabIndex = 3;
            // 
            // buttonAddRow_SAN
            // 
            this.buttonAddRow_SAN.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddRow_SAN.Image")));
            this.buttonAddRow_SAN.Location = new System.Drawing.Point(152, 6);
            this.buttonAddRow_SAN.Name = "buttonAddRow_SAN";
            this.buttonAddRow_SAN.Size = new System.Drawing.Size(74, 71);
            this.buttonAddRow_SAN.TabIndex = 2;
            this.toolTipButton_SAN.SetToolTip(this.buttonAddRow_SAN, "Добавить информацию");
            this.buttonAddRow_SAN.UseVisualStyleBackColor = true;
            this.buttonAddRow_SAN.Click += new System.EventHandler(this.buttonAddRow_SAN_Click);
            this.buttonAddRow_SAN.MouseEnter += new System.EventHandler(this.buttonAddRow_SAN_MouseEnter);
            this.buttonAddRow_SAN.MouseLeave += new System.EventHandler(this.buttonAddRow_SAN_MouseLeave);
            // 
            // buttonSaveFile_SAN
            // 
            this.buttonSaveFile_SAN.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_SAN.Image")));
            this.buttonSaveFile_SAN.Location = new System.Drawing.Point(433, 6);
            this.buttonSaveFile_SAN.Name = "buttonSaveFile_SAN";
            this.buttonSaveFile_SAN.Size = new System.Drawing.Size(74, 71);
            this.buttonSaveFile_SAN.TabIndex = 1;
            this.toolTipButton_SAN.SetToolTip(this.buttonSaveFile_SAN, "Сохранить измененный файл");
            this.buttonSaveFile_SAN.UseVisualStyleBackColor = true;
            this.buttonSaveFile_SAN.Click += new System.EventHandler(this.buttonSaveFile_SAN_Click);
            this.buttonSaveFile_SAN.MouseEnter += new System.EventHandler(this.buttonSaveFile_SAN_MouseEnter);
            this.buttonSaveFile_SAN.MouseLeave += new System.EventHandler(this.buttonSaveFile_SAN_MouseLeave);
            // 
            // buttonOpenFile_SAN
            // 
            this.buttonOpenFile_SAN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_SAN.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SAN.Image")));
            this.buttonOpenFile_SAN.Location = new System.Drawing.Point(15, 6);
            this.buttonOpenFile_SAN.Name = "buttonOpenFile_SAN";
            this.buttonOpenFile_SAN.Size = new System.Drawing.Size(74, 71);
            this.buttonOpenFile_SAN.TabIndex = 0;
            this.toolTipButton_SAN.SetToolTip(this.buttonOpenFile_SAN, "Добавить файл\r\n");
            this.buttonOpenFile_SAN.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SAN.Click += new System.EventHandler(this.buttonOpenFile_SAN_Click);
            this.buttonOpenFile_SAN.MouseEnter += new System.EventHandler(this.buttonOpenFile_SAN_MouseEnter);
            this.buttonOpenFile_SAN.MouseLeave += new System.EventHandler(this.buttonOpenFile_SAN_MouseLeave);
            // 
            // openFileDialogButton_SAN
            // 
            this.openFileDialogButton_SAN.FileName = "openFileDialog1";
            // 
            // toolTipButton_SAN
            // 
            this.toolTipButton_SAN.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_SAN.ToolTipTitle = "Подсказка";
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
            this.panelLeft_SAN.ResumeLayout(false);
            this.groupBoxFilter_SAN.ResumeLayout(false);
            this.panelFill_SAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SAN)).EndInit();
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
        private System.Windows.Forms.Button buttonAddRow_SAN;
        private System.Windows.Forms.Button buttonSaveFile_SAN;
        private System.Windows.Forms.Button buttonOpenFile_SAN;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_SAN;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMain_SAN;
        private System.Windows.Forms.Button buttonDeleteRow_SAN;
        private System.Windows.Forms.GroupBox groupBoxFilter_SAN;
        private System.Windows.Forms.ComboBox comboBoxFilter_SAN;
        private System.Windows.Forms.Button buttonFilter_SAN;
    }
}

