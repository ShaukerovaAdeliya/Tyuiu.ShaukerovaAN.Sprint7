using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using Tyuiu.ShaukerovaAN.Sprint7.Project.V5.Lib;
using Tyuiu.ShaukerovaAN.Sprint7.Project.V5.Test;


namespace Tyuiu.ShaukerovaAN.Sprint7.Project.V5
{
    public partial class FormMain_SAN : Form
    {
        public FormMain_SAN()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        
        
        private void buttonOpenFile_SAN_Click(object sender, EventArgs e)
        {
            // задаем столбцы
            dataGridViewMatrix_SAN.ColumnCount = 8;

            // выгружаем данные из цсв файла
            using (var reader = new StreamReader("base.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';'); // празделитель это точка с запятой

                    dataGridViewMatrix_SAN.Rows.Add(values);
                }
            }
        }

        private void buttonSaveFile_SAN_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogMain_SAN.FileName = ".csv";
                saveFileDialogMain_SAN.InitialDirectory = @":L";
                if (saveFileDialogMain_SAN.ShowDialog() == DialogResult.OK)
                {
                    string savepath = saveFileDialogMain_SAN.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = dataGridViewMatrix_SAN.RowCount;
                    int columns = dataGridViewMatrix_SAN.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(dataGridViewMatrix_SAN.Rows[i].Cells[j].Value);

                            if (j != columns - 1) strBuilder.Append(";"); // ???
                        }
                        strBuilder.AppendLine();
                    }
                    File.WriteAllText(savepath, strBuilder.ToString(), Encoding.GetEncoding(1251));
                    MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddRow_SAN_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewMatrix_SAN.Rows.Add();
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteRow_SAN_Click(object sender, EventArgs e)
        {
            if (dataGridViewMatrix_SAN.RowCount != 0)
            {
                int del = 0;
                var result = MessageBox.Show($"{"Удалить данную строку?\rЕё невозможно будет восстановить"}", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    del = 1;
                }
                if (del == 1)
                {
                    int a = dataGridViewMatrix_SAN.CurrentCell.RowIndex;
                    dataGridViewMatrix_SAN.Rows.RemoveAt(a);
                }
            }
            else
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonHelp_SAN_MouseClick(object sender, MouseEventArgs e)
        {
            FormAbout_SAN formAbout = new FormAbout_SAN();
            formAbout.ShowDialog();
        }

        private void buttonOProgramme_SAN_Click(object sender, EventArgs e)
        {
            FormOProgramme_SAN formOProgramme = new FormOProgramme_SAN();
            formOProgramme.ShowDialog();
        }

        private void buttonHelp_SAN_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void buttonHelp_SAN_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonOProgramme_SAN_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonOProgramme_SAN_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonOpenFile_SAN_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonAddRow_SAN_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonDeleteRow_SAN_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonSaveFile_SAN_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonOpenFile_SAN_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonAddRow_SAN_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonDeleteRow_SAN_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonSaveFile_SAN_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void comboBoxFilter_SAN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valueFilt = comboBoxFilter_SAN.SelectedItem.ToString(); //извлечение строкового значения выбранного элемента ComboBox
            if (!string.IsNullOrEmpty(valueFilt))
            {
                foreach (DataGridViewRow row in dataGridViewMatrix_SAN.Rows)
                {
                    if (!row.IsNewRow) // проверка новая ли строка
                    {
                        if (row.Cells["otdel_SAN"].Value != null && row.Cells["otdel_SAN"].Value.ToString() == valueFilt)
                        {
                            row.Visible = true;
                        }
                        else
                        {
                            row.Visible = false;
                        }
                    }
                }
            }
        }

        private void comboBoxSort_SAN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSort_SAN.SelectedItem != null)
            {
                int columnIndex = 7;
                string selectedItem = comboBoxSort_SAN.SelectedItem.ToString();
                foreach (DataGridViewRow row in dataGridViewMatrix_SAN.Rows)
                {
                    int cellValue;
                    if (row.Cells[columnIndex].Value != null && int.TryParse(row.Cells[columnIndex].Value.ToString(), out cellValue))
                    {
                        row.Cells[columnIndex].Value = cellValue;
                    }
                }
                try
                {
                    DataGridViewColumn column = dataGridViewMatrix_SAN.Columns[7];

                    if (selectedItem == "Дороже")
                    {
                        dataGridViewMatrix_SAN.Sort(column, ListSortDirection.Ascending);
                    }
                    if (selectedItem == "Дешевле")
                    {
                        dataGridViewMatrix_SAN.Sort(column, ListSortDirection.Descending);
                    }
                }
                catch
                {
                    MessageBox.Show("Невозможно выполнить сортировку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void comboBoxArticule_SAN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSort_SAN.SelectedItem != null)
            {
                int columnIndex = 0;
                string selectedItem = comboBoxSort_SAN.SelectedItem.ToString();
                foreach (DataGridViewRow row in dataGridViewMatrix_SAN.Rows)
                {
                    int cellValue;
                    if (row.Cells[columnIndex].Value != null && int.TryParse(row.Cells[columnIndex].Value.ToString(), out cellValue))
                    {
                        row.Cells[columnIndex].Value = cellValue;
                    }
                }
                try
                {
                    DataGridViewColumn column = dataGridViewMatrix_SAN.Columns[0];

                    if (selectedItem == "По возрастанию")
                    {
                        dataGridViewMatrix_SAN.Sort(column, ListSortDirection.Ascending);
                    }
                    if (selectedItem == "По убыванию")
                    {
                        dataGridViewMatrix_SAN.Sort(column, ListSortDirection.Descending);
                    }
                }
                catch
                {
                    MessageBox.Show("Невозможно выполнить сортировку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSum_SAN_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridViewMatrix_SAN.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridViewMatrix_SAN.Rows[i].Cells[3].Value);
            }
            textBoxSum_SAN.Text = sum.ToString();
        }

        private void buttonFloat_SAN_Click(object sender, EventArgs e)
        {
            //int sr = 0;
            //for (int i = 0; i < dataGridViewMatrix_SAN.Rows.Count; i++)
            //{
            //sr += Convert.ToInt32(dataGridViewMatrix_SAN.Rows[i].Cells[3].Value);
            //sr = (sr / dataGridViewMatrix_SAN.RowCount);
            //}
            //textBoxfloat_SAN.Text = sr.ToString();
            int sum = 0;
            for (int i = 0; i < dataGridViewMatrix_SAN.RowCount-1; i++) //-1 нужен, если AlloyUserToAddRows=true
            {                
                //for (int j = 0; j < dataGridViewMatrix_SAN.Rows[i].Cells.Count; j++)
                {
                    sum += Convert.ToInt32(dataGridViewMatrix_SAN.Rows[i].Cells[7].Value);
                }
                double mid = sum / dataGridViewMatrix_SAN.Rows[i].Cells.Count;
                textBoxfloat_SAN.Text = mid.ToString();
            }


        }

        private void buttonSumPrice_SAN_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridViewMatrix_SAN.Rows.Count; ++i)
            {
            sum += Convert.ToInt32(dataGridViewMatrix_SAN.Rows[i].Cells[7].Value);
            }
            textBoxSumPrice_SAN.Text = sum.ToString();
    
        }

        private void textBoxPoisk_SAN_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxPoisk_SAN.Text.ToLower(); //приведение к нижнему регистру
            foreach (DataGridViewRow row in dataGridViewMatrix_SAN.Rows)
            {
                if (row.Cells["ColumnF"].Value != null && row.Cells["ColumnI"].Value != null)
                {
                    string column2Text = row.Cells["ColumnF"].Value.ToString().ToLower();
                    string column3Text = row.Cells["ColumnO"].Value.ToString().ToLower();

                    if (column2Text.Contains(searchText) || column3Text.Contains(searchText))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }
    }

}
