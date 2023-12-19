
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
            this.buttonHelp_SAN = new System.Windows.Forms.Button();
            this.panelLeft_SAN = new System.Windows.Forms.Panel();
            this.groupBoxAddProduct_SAN = new System.Windows.Forms.GroupBox();
            this.textBoxPrice_SAN = new System.Windows.Forms.TextBox();
            this.textBoxCompanyName_SAN = new System.Windows.Forms.TextBox();
            this.textBoxAmountUpak_SAN = new System.Windows.Forms.TextBox();
            this.textBoxAmountSklad_SAN = new System.Windows.Forms.TextBox();
            this.textBoxNameAddProduct_SAN = new System.Windows.Forms.TextBox();
            this.textBoxOtdel_SAN = new System.Windows.Forms.TextBox();
            this.textBoxArticul_SAN = new System.Windows.Forms.TextBox();
            this.labelAmountUpak_SAN = new System.Windows.Forms.Label();
            this.labelAmountSklad_SAN = new System.Windows.Forms.Label();
            this.labelOtdel_SAN = new System.Windows.Forms.Label();
            this.labelArticul_SAN = new System.Windows.Forms.Label();
            this.labelPrice_SAN = new System.Windows.Forms.Label();
            this.labelCompanyName_SAN = new System.Windows.Forms.Label();
            this.labelNameAddProduct_SAN = new System.Windows.Forms.Label();
            this.splitterPanel_SAN = new System.Windows.Forms.Splitter();
            this.panelFill_SAN = new System.Windows.Forms.Panel();
            this.groupBoxRedact_SAN = new System.Windows.Forms.GroupBox();
            this.openFileDialogButton_SAN = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_SAN = new System.Windows.Forms.ToolTip(this.components);
            this.buttonDone_SAN = new System.Windows.Forms.Button();
            this.labelNameRedact_SAN = new System.Windows.Forms.Label();
            this.labelPriceRedact_SAN = new System.Windows.Forms.Label();
            this.buttonRedact_SAN = new System.Windows.Forms.Button();
            this.textBoxName_SAN = new System.Windows.Forms.TextBox();
            this.textBoxPriceRedact_SAN = new System.Windows.Forms.TextBox();
            this.textBoxColichestvoSklad_SAN = new System.Windows.Forms.TextBox();
            this.labelCountSklad_SAN = new System.Windows.Forms.Label();
            this.buttonOProgramme_SAN = new System.Windows.Forms.Button();
            this.comboBoxSearch_SAN = new System.Windows.Forms.ComboBox();
            this.dataGridViewOutput_SAN = new System.Windows.Forms.DataGridView();
            this.panelTop_SAN.SuspendLayout();
            this.panelLeft_SAN.SuspendLayout();
            this.groupBoxAddProduct_SAN.SuspendLayout();
            this.panelFill_SAN.SuspendLayout();
            this.groupBoxRedact_SAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_SAN)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_SAN
            // 
            this.panelTop_SAN.Controls.Add(this.buttonOProgramme_SAN);
            this.panelTop_SAN.Controls.Add(this.buttonHelp_SAN);
            this.panelTop_SAN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_SAN.Location = new System.Drawing.Point(0, 0);
            this.panelTop_SAN.Name = "panelTop_SAN";
            this.panelTop_SAN.Size = new System.Drawing.Size(1271, 103);
            this.panelTop_SAN.TabIndex = 0;
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
            this.panelLeft_SAN.Controls.Add(this.groupBoxRedact_SAN);
            this.panelLeft_SAN.Controls.Add(this.groupBoxAddProduct_SAN);
            this.panelLeft_SAN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_SAN.Location = new System.Drawing.Point(0, 103);
            this.panelLeft_SAN.Name = "panelLeft_SAN";
            this.panelLeft_SAN.Size = new System.Drawing.Size(432, 574);
            this.panelLeft_SAN.TabIndex = 1;
            // 
            // groupBoxAddProduct_SAN
            // 
            this.groupBoxAddProduct_SAN.Controls.Add(this.buttonDone_SAN);
            this.groupBoxAddProduct_SAN.Controls.Add(this.textBoxPrice_SAN);
            this.groupBoxAddProduct_SAN.Controls.Add(this.textBoxCompanyName_SAN);
            this.groupBoxAddProduct_SAN.Controls.Add(this.textBoxAmountUpak_SAN);
            this.groupBoxAddProduct_SAN.Controls.Add(this.textBoxAmountSklad_SAN);
            this.groupBoxAddProduct_SAN.Controls.Add(this.textBoxNameAddProduct_SAN);
            this.groupBoxAddProduct_SAN.Controls.Add(this.textBoxOtdel_SAN);
            this.groupBoxAddProduct_SAN.Controls.Add(this.textBoxArticul_SAN);
            this.groupBoxAddProduct_SAN.Controls.Add(this.labelAmountUpak_SAN);
            this.groupBoxAddProduct_SAN.Controls.Add(this.labelAmountSklad_SAN);
            this.groupBoxAddProduct_SAN.Controls.Add(this.labelOtdel_SAN);
            this.groupBoxAddProduct_SAN.Controls.Add(this.labelArticul_SAN);
            this.groupBoxAddProduct_SAN.Controls.Add(this.labelPrice_SAN);
            this.groupBoxAddProduct_SAN.Controls.Add(this.labelCompanyName_SAN);
            this.groupBoxAddProduct_SAN.Controls.Add(this.labelNameAddProduct_SAN);
            this.groupBoxAddProduct_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAddProduct_SAN.Location = new System.Drawing.Point(12, 6);
            this.groupBoxAddProduct_SAN.Name = "groupBoxAddProduct_SAN";
            this.groupBoxAddProduct_SAN.Size = new System.Drawing.Size(409, 347);
            this.groupBoxAddProduct_SAN.TabIndex = 1;
            this.groupBoxAddProduct_SAN.TabStop = false;
            this.groupBoxAddProduct_SAN.Text = "Добавить  товар";
            // 
            // textBoxPrice_SAN
            // 
            this.textBoxPrice_SAN.Location = new System.Drawing.Point(190, 247);
            this.textBoxPrice_SAN.Name = "textBoxPrice_SAN";
            this.textBoxPrice_SAN.Size = new System.Drawing.Size(205, 24);
            this.textBoxPrice_SAN.TabIndex = 13;
            // 
            // textBoxCompanyName_SAN
            // 
            this.textBoxCompanyName_SAN.Location = new System.Drawing.Point(190, 211);
            this.textBoxCompanyName_SAN.Name = "textBoxCompanyName_SAN";
            this.textBoxCompanyName_SAN.Size = new System.Drawing.Size(205, 24);
            this.textBoxCompanyName_SAN.TabIndex = 12;
            // 
            // textBoxAmountUpak_SAN
            // 
            this.textBoxAmountUpak_SAN.Location = new System.Drawing.Point(190, 174);
            this.textBoxAmountUpak_SAN.Name = "textBoxAmountUpak_SAN";
            this.textBoxAmountUpak_SAN.Size = new System.Drawing.Size(205, 24);
            this.textBoxAmountUpak_SAN.TabIndex = 11;
            // 
            // textBoxAmountSklad_SAN
            // 
            this.textBoxAmountSklad_SAN.Location = new System.Drawing.Point(190, 138);
            this.textBoxAmountSklad_SAN.Name = "textBoxAmountSklad_SAN";
            this.textBoxAmountSklad_SAN.Size = new System.Drawing.Size(205, 24);
            this.textBoxAmountSklad_SAN.TabIndex = 10;
            // 
            // textBoxNameAddProduct_SAN
            // 
            this.textBoxNameAddProduct_SAN.Location = new System.Drawing.Point(190, 101);
            this.textBoxNameAddProduct_SAN.Name = "textBoxNameAddProduct_SAN";
            this.textBoxNameAddProduct_SAN.Size = new System.Drawing.Size(205, 24);
            this.textBoxNameAddProduct_SAN.TabIndex = 9;
            // 
            // textBoxOtdel_SAN
            // 
            this.textBoxOtdel_SAN.Location = new System.Drawing.Point(190, 66);
            this.textBoxOtdel_SAN.Name = "textBoxOtdel_SAN";
            this.textBoxOtdel_SAN.Size = new System.Drawing.Size(205, 24);
            this.textBoxOtdel_SAN.TabIndex = 8;
            // 
            // textBoxArticul_SAN
            // 
            this.textBoxArticul_SAN.Location = new System.Drawing.Point(190, 29);
            this.textBoxArticul_SAN.Name = "textBoxArticul_SAN";
            this.textBoxArticul_SAN.Size = new System.Drawing.Size(205, 24);
            this.textBoxArticul_SAN.TabIndex = 7;
            // 
            // labelAmountUpak_SAN
            // 
            this.labelAmountUpak_SAN.AutoSize = true;
            this.labelAmountUpak_SAN.Location = new System.Drawing.Point(6, 174);
            this.labelAmountUpak_SAN.Name = "labelAmountUpak_SAN";
            this.labelAmountUpak_SAN.Size = new System.Drawing.Size(176, 18);
            this.labelAmountUpak_SAN.TabIndex = 6;
            this.labelAmountUpak_SAN.Text = "Количество в упаковке:";
            // 
            // labelAmountSklad_SAN
            // 
            this.labelAmountSklad_SAN.AutoSize = true;
            this.labelAmountSklad_SAN.Location = new System.Drawing.Point(6, 137);
            this.labelAmountSklad_SAN.Name = "labelAmountSklad_SAN";
            this.labelAmountSklad_SAN.Size = new System.Drawing.Size(170, 18);
            this.labelAmountSklad_SAN.TabIndex = 5;
            this.labelAmountSklad_SAN.Text = "Количество на складе:";
            // 
            // labelOtdel_SAN
            // 
            this.labelOtdel_SAN.AutoSize = true;
            this.labelOtdel_SAN.Location = new System.Drawing.Point(6, 66);
            this.labelOtdel_SAN.Name = "labelOtdel_SAN";
            this.labelOtdel_SAN.Size = new System.Drawing.Size(57, 18);
            this.labelOtdel_SAN.TabIndex = 4;
            this.labelOtdel_SAN.Text = "Отдел:";
            // 
            // labelArticul_SAN
            // 
            this.labelArticul_SAN.AutoSize = true;
            this.labelArticul_SAN.Location = new System.Drawing.Point(6, 32);
            this.labelArticul_SAN.Name = "labelArticul_SAN";
            this.labelArticul_SAN.Size = new System.Drawing.Size(68, 18);
            this.labelArticul_SAN.TabIndex = 3;
            this.labelArticul_SAN.Text = "Артикул:";
            // 
            // labelPrice_SAN
            // 
            this.labelPrice_SAN.AutoSize = true;
            this.labelPrice_SAN.Location = new System.Drawing.Point(6, 247);
            this.labelPrice_SAN.Name = "labelPrice_SAN";
            this.labelPrice_SAN.Size = new System.Drawing.Size(105, 18);
            this.labelPrice_SAN.TabIndex = 2;
            this.labelPrice_SAN.Text = "Цена руб/шт  :";
            // 
            // labelCompanyName_SAN
            // 
            this.labelCompanyName_SAN.AutoSize = true;
            this.labelCompanyName_SAN.Location = new System.Drawing.Point(6, 211);
            this.labelCompanyName_SAN.Name = "labelCompanyName_SAN";
            this.labelCompanyName_SAN.Size = new System.Drawing.Size(90, 18);
            this.labelCompanyName_SAN.TabIndex = 1;
            this.labelCompanyName_SAN.Text = "Поставщик:";
            // 
            // labelNameAddProduct_SAN
            // 
            this.labelNameAddProduct_SAN.AutoSize = true;
            this.labelNameAddProduct_SAN.Location = new System.Drawing.Point(6, 101);
            this.labelNameAddProduct_SAN.Name = "labelNameAddProduct_SAN";
            this.labelNameAddProduct_SAN.Size = new System.Drawing.Size(79, 18);
            this.labelNameAddProduct_SAN.TabIndex = 0;
            this.labelNameAddProduct_SAN.Text = "Название:";
            // 
            // splitterPanel_SAN
            // 
            this.splitterPanel_SAN.Location = new System.Drawing.Point(432, 103);
            this.splitterPanel_SAN.Name = "splitterPanel_SAN";
            this.splitterPanel_SAN.Size = new System.Drawing.Size(10, 574);
            this.splitterPanel_SAN.TabIndex = 2;
            this.splitterPanel_SAN.TabStop = false;
            // 
            // panelFill_SAN
            // 
            this.panelFill_SAN.BackColor = System.Drawing.SystemColors.Control;
            this.panelFill_SAN.Controls.Add(this.dataGridViewOutput_SAN);
            this.panelFill_SAN.Controls.Add(this.comboBoxSearch_SAN);
            this.panelFill_SAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_SAN.Location = new System.Drawing.Point(442, 103);
            this.panelFill_SAN.Name = "panelFill_SAN";
            this.panelFill_SAN.Size = new System.Drawing.Size(829, 574);
            this.panelFill_SAN.TabIndex = 3;
            // 
            // groupBoxRedact_SAN
            // 
            this.groupBoxRedact_SAN.Controls.Add(this.labelCountSklad_SAN);
            this.groupBoxRedact_SAN.Controls.Add(this.textBoxColichestvoSklad_SAN);
            this.groupBoxRedact_SAN.Controls.Add(this.textBoxPriceRedact_SAN);
            this.groupBoxRedact_SAN.Controls.Add(this.textBoxName_SAN);
            this.groupBoxRedact_SAN.Controls.Add(this.buttonRedact_SAN);
            this.groupBoxRedact_SAN.Controls.Add(this.labelPriceRedact_SAN);
            this.groupBoxRedact_SAN.Controls.Add(this.labelNameRedact_SAN);
            this.groupBoxRedact_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxRedact_SAN.Location = new System.Drawing.Point(12, 371);
            this.groupBoxRedact_SAN.Name = "groupBoxRedact_SAN";
            this.groupBoxRedact_SAN.Size = new System.Drawing.Size(409, 189);
            this.groupBoxRedact_SAN.TabIndex = 2;
            this.groupBoxRedact_SAN.TabStop = false;
            this.groupBoxRedact_SAN.Text = "Редактировать товар";
            // 
            // openFileDialogButton_SAN
            // 
            this.openFileDialogButton_SAN.FileName = "openFileDialog1";
            // 
            // toolTipButton_SAN
            // 
            this.toolTipButton_SAN.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // buttonDone_SAN
            // 
            this.buttonDone_SAN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDone_SAN.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SAN.Image")));
            this.buttonDone_SAN.Location = new System.Drawing.Point(321, 291);
            this.buttonDone_SAN.Name = "buttonDone_SAN";
            this.buttonDone_SAN.Size = new System.Drawing.Size(74, 50);
            this.buttonDone_SAN.TabIndex = 14;
            this.toolTipButton_SAN.SetToolTip(this.buttonDone_SAN, "Сохранить данные о товаре в таблице");
            this.buttonDone_SAN.UseVisualStyleBackColor = false;
            // 
            // labelNameRedact_SAN
            // 
            this.labelNameRedact_SAN.AutoSize = true;
            this.labelNameRedact_SAN.Location = new System.Drawing.Point(6, 29);
            this.labelNameRedact_SAN.Name = "labelNameRedact_SAN";
            this.labelNameRedact_SAN.Size = new System.Drawing.Size(79, 18);
            this.labelNameRedact_SAN.TabIndex = 0;
            this.labelNameRedact_SAN.Text = "Название:";
            // 
            // labelPriceRedact_SAN
            // 
            this.labelPriceRedact_SAN.AutoSize = true;
            this.labelPriceRedact_SAN.Location = new System.Drawing.Point(6, 66);
            this.labelPriceRedact_SAN.Name = "labelPriceRedact_SAN";
            this.labelPriceRedact_SAN.Size = new System.Drawing.Size(47, 18);
            this.labelPriceRedact_SAN.TabIndex = 1;
            this.labelPriceRedact_SAN.Text = "Цена:";
            // 
            // buttonRedact_SAN
            // 
            this.buttonRedact_SAN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRedact_SAN.Image = ((System.Drawing.Image)(resources.GetObject("buttonRedact_SAN.Image")));
            this.buttonRedact_SAN.Location = new System.Drawing.Point(321, 128);
            this.buttonRedact_SAN.Name = "buttonRedact_SAN";
            this.buttonRedact_SAN.Size = new System.Drawing.Size(74, 55);
            this.buttonRedact_SAN.TabIndex = 2;
            this.buttonRedact_SAN.UseVisualStyleBackColor = false;
            // 
            // textBoxName_SAN
            // 
            this.textBoxName_SAN.Location = new System.Drawing.Point(190, 26);
            this.textBoxName_SAN.Name = "textBoxName_SAN";
            this.textBoxName_SAN.Size = new System.Drawing.Size(205, 24);
            this.textBoxName_SAN.TabIndex = 3;
            // 
            // textBoxPriceRedact_SAN
            // 
            this.textBoxPriceRedact_SAN.Location = new System.Drawing.Point(190, 60);
            this.textBoxPriceRedact_SAN.Name = "textBoxPriceRedact_SAN";
            this.textBoxPriceRedact_SAN.Size = new System.Drawing.Size(205, 24);
            this.textBoxPriceRedact_SAN.TabIndex = 4;
            // 
            // textBoxColichestvoSklad_SAN
            // 
            this.textBoxColichestvoSklad_SAN.Location = new System.Drawing.Point(190, 98);
            this.textBoxColichestvoSklad_SAN.Name = "textBoxColichestvoSklad_SAN";
            this.textBoxColichestvoSklad_SAN.Size = new System.Drawing.Size(205, 24);
            this.textBoxColichestvoSklad_SAN.TabIndex = 5;
            // 
            // labelCountSklad_SAN
            // 
            this.labelCountSklad_SAN.AutoSize = true;
            this.labelCountSklad_SAN.Location = new System.Drawing.Point(6, 101);
            this.labelCountSklad_SAN.Name = "labelCountSklad_SAN";
            this.labelCountSklad_SAN.Size = new System.Drawing.Size(170, 18);
            this.labelCountSklad_SAN.TabIndex = 7;
            this.labelCountSklad_SAN.Text = "Количество на складе:";
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
            // comboBoxSearch_SAN
            // 
            this.comboBoxSearch_SAN.FormattingEnabled = true;
            this.comboBoxSearch_SAN.Location = new System.Drawing.Point(20, 6);
            this.comboBoxSearch_SAN.Name = "comboBoxSearch_SAN";
            this.comboBoxSearch_SAN.Size = new System.Drawing.Size(797, 21);
            this.comboBoxSearch_SAN.TabIndex = 0;
            // 
            // dataGridViewOutput_SAN
            // 
            this.dataGridViewOutput_SAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_SAN.Location = new System.Drawing.Point(20, 48);
            this.dataGridViewOutput_SAN.Name = "dataGridViewOutput_SAN";
            this.dataGridViewOutput_SAN.Size = new System.Drawing.Size(797, 512);
            this.dataGridViewOutput_SAN.TabIndex = 1;
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
            this.panelLeft_SAN.ResumeLayout(false);
            this.groupBoxAddProduct_SAN.ResumeLayout(false);
            this.groupBoxAddProduct_SAN.PerformLayout();
            this.panelFill_SAN.ResumeLayout(false);
            this.groupBoxRedact_SAN.ResumeLayout(false);
            this.groupBoxRedact_SAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_SAN)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBoxAddProduct_SAN;
        private System.Windows.Forms.TextBox textBoxPrice_SAN;
        private System.Windows.Forms.TextBox textBoxCompanyName_SAN;
        private System.Windows.Forms.TextBox textBoxAmountUpak_SAN;
        private System.Windows.Forms.TextBox textBoxAmountSklad_SAN;
        private System.Windows.Forms.TextBox textBoxNameAddProduct_SAN;
        private System.Windows.Forms.TextBox textBoxOtdel_SAN;
        private System.Windows.Forms.TextBox textBoxArticul_SAN;
        private System.Windows.Forms.Label labelAmountUpak_SAN;
        private System.Windows.Forms.Label labelAmountSklad_SAN;
        private System.Windows.Forms.Label labelOtdel_SAN;
        private System.Windows.Forms.Label labelArticul_SAN;
        private System.Windows.Forms.Label labelPrice_SAN;
        private System.Windows.Forms.Label labelCompanyName_SAN;
        private System.Windows.Forms.Label labelNameAddProduct_SAN;
        private System.Windows.Forms.GroupBox groupBoxRedact_SAN;
        private System.Windows.Forms.Button buttonDone_SAN;
        private System.Windows.Forms.TextBox textBoxColichestvoSklad_SAN;
        private System.Windows.Forms.TextBox textBoxPriceRedact_SAN;
        private System.Windows.Forms.TextBox textBoxName_SAN;
        private System.Windows.Forms.Button buttonRedact_SAN;
        private System.Windows.Forms.Label labelPriceRedact_SAN;
        private System.Windows.Forms.Label labelNameRedact_SAN;
        private System.Windows.Forms.Label labelCountSklad_SAN;
        private System.Windows.Forms.Button buttonOProgramme_SAN;
        private System.Windows.Forms.DataGridView dataGridViewOutput_SAN;
        private System.Windows.Forms.ComboBox comboBoxSearch_SAN;
    }
}

