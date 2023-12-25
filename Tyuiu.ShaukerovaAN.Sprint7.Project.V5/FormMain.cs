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
using System.Windows.Forms.DataVisualization.Charting;
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
        static int rows;
        static int columns;
        static string openFilePath;
        

        DataService ds = new DataService();      
        private void buttonOpenFile_SAN_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogButton_SAN.ShowDialog();
                openFilePath = openFileDialogButton_SAN.FileName;

                string[,] matrix = ds.LoadFromDataFile(openFilePath);

                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridViewMatrix_SAN.RowCount = rows + 1;
                dataGridViewMatrix_SAN.ColumnCount = columns;

                //добавление данных
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewMatrix_SAN.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                dataGridViewMatrix_SAN.AutoResizeColumns();
                dataGridViewMatrix_SAN.ScrollBars = ScrollBars.Both;
                for (int i = 0; i < dataGridViewMatrix_SAN.RowCount - 1; i++)
                {

                    if (dataGridViewMatrix_SAN.Rows[i].Cells[3].Value.ToString() == "")
                    {
                        dataGridViewMatrix_SAN.Rows.RemoveAt(i);
                        i--;
                    }
                }

                buttonSaveFile_SAN.Enabled = true;
                buttonDeleteRow_SAN.Enabled = true;
                buttonSum_SAN.Enabled = true;
                buttonSumPrice_SAN.Enabled = true;
                buttonSrZnach_SAN.Enabled = true;
                buttonDone_SAN.Enabled = true;

            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_SAN_Click(object sender, EventArgs e)
        {
            saveFileDialogMain_SAN.FileName = openFilePath;
            saveFileDialogMain_SAN.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMain_SAN.ShowDialog();

            string path = saveFileDialogMain_SAN.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewMatrix_SAN.RowCount;
            int columns = dataGridViewMatrix_SAN.ColumnCount;

            string str = "";



            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewMatrix_SAN.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewMatrix_SAN.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonAddRow_SAN_Click(object sender, EventArgs e)
        {
            string Articule_SAN = textBoxArticuleAdd_SAN.Text;
            string otdel_SAN = textBoxOtdelAdd_SAN.Text;
            string name_SAN = textBoxNameAdd_SAN.Text;
            string CountSklad_SAN = textBoxCountSkadAdd_SAN.Text;
            string CountUpakovka_SAN = textBoxCountUpaAdd_SAN.Text;
            string CountUpakovok_SAN = textBoxCountUpakovokadd_SAN.Text;
            string postavshik_SAN = textBoxPostavshikAdd_SAN.Text;
            string price_SAN = textBoxPriceAdd_SAN.Text;
            

            // заполнение
            dataGridViewMatrix_SAN.Rows.Add(Articule_SAN, otdel_SAN, name_SAN, CountSklad_SAN, CountUpakovka_SAN, CountUpakovok_SAN, postavshik_SAN, price_SAN);
            textBoxArticuleAdd_SAN.Text = "";
            textBoxOtdelAdd_SAN.Text = "";
            textBoxNameAdd_SAN.Text = "";
            textBoxCountSkadAdd_SAN.Text = "";
            textBoxCountUpaAdd_SAN.Text = "";
            textBoxCountUpakovokadd_SAN.Text = "";
            textBoxPostavshikAdd_SAN.Text = "";
            textBoxPriceAdd_SAN.Text = "";
            dataGridViewMatrix_SAN.CurrentCell = dataGridViewMatrix_SAN.Rows[dataGridViewMatrix_SAN.Rows.Count - 1].Cells[0];
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
            if (comboBoxSort_SAN.SelectedItem != null)
            {
                int columnIndex = 7;
                string selectedItem = comboBoxSort_SAN.SelectedItem.ToString();
                foreach (DataGridViewRow row in dataGridViewMatrix_SAN.Rows)
                {
                    double cellValue;
                    if (row.Cells[columnIndex].Value != null && double.TryParse(row.Cells[columnIndex].Value.ToString(), out cellValue))
                    {
                        row.Cells[columnIndex].Value = cellValue;
                    }
                }
                try
                {

                    string[,] matrix = ds.LoadFromDataFile(openFilePath);

                    rows = matrix.GetLength(0);
                    columns = matrix.GetLength(1);

                    dataGridViewMatrix_SAN.RowCount = rows + 1;
                    dataGridViewMatrix_SAN.ColumnCount = columns;

                    DataGridViewColumn column = dataGridViewMatrix_SAN.Columns[7];

                    if (selectedItem == "Дороже")
                    {
                        dataGridViewMatrix_SAN.Sort(column, ListSortDirection.Descending);
                        
                    }
                    if (selectedItem == "Дешевле")
                    {
                        dataGridViewMatrix_SAN.Sort(column, ListSortDirection.Ascending);
                    }
                    if (selectedItem == "Сбросить сортировку")
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                dataGridViewMatrix_SAN.Rows[i].Cells[j].Value = matrix[i, j];
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Невозможно выполнить сортировку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBoxSort_SAN_SelectedIndexChanged(object sender, EventArgs e)
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
       
        private void buttonSum_SAN_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridViewMatrix_SAN.Rows.Count ; i++)
            {
                sum += Convert.ToInt32(dataGridViewMatrix_SAN.Rows[i].Cells[3].Value);
            }
            textBoxSum_SAN.Text = sum.ToString();
        }

        private void buttonSumPrice_SAN_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridViewMatrix_SAN.Rows.Count; ++i)
            {
                //sum += Convert.ToInt32(dataGridViewMatrix_SAN.Rows[i].Cells[7].Value);
                sum += Convert.ToInt32(dataGridViewMatrix_SAN.Rows[i].Cells[7].Value) * Convert.ToInt32(dataGridViewMatrix_SAN.Rows[i].Cells[5].Value);
            }
            textBoxSumPrice_SAN.Text = sum.ToString();
    
        }
        private void textBoxPoiskPostavshik_SAN_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonDone_SAN_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = dataGridViewMatrix_SAN.RowCount;
                int columns = dataGridViewMatrix_SAN.ColumnCount;
                string str;
                string[,] matrix = new string[rows, columns];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        str = "";
                        str += dataGridViewMatrix_SAN.Rows[i].Cells[j].Value;
                        matrix[i, j] = str;
                    }

                }

                int summ = 0;
                int sumb = 0;
                int summg = 0;
                for (int i = 0; i < rows - 1; i++)
                {
                    if (matrix[i, 1] == "Молоко")
                    {
                        summ += Convert.ToInt32(dataGridViewMatrix_SAN.Rows[i].Cells[3].Value);
                    }
                    if (matrix[i, 1] == "Бакалея")
                    {
                        sumb += Convert.ToInt32(dataGridViewMatrix_SAN.Rows[i].Cells[3].Value);
                    }
                    if (matrix[i, 1] == "Мясная гастрономия")
                    {
                        summg += Convert.ToInt32(dataGridViewMatrix_SAN.Rows[i].Cells[3].Value);
                    }
                }
                textBoxSumMoloko_SAN.Text = summ.ToString();
                textBoxSumBakaleya_SAN.Text = sumb.ToString();
                textBoxSumGastronomiya_SAN.Text = summg.ToString();

                string[] seriesArray = { "Молоко", "Бакалея", "Мясная гастрономия" };
                int[] pointsArray = { summ, sumb, summg }; 

                // выбрать цвет
                this.chart_SAN.Palette = ChartColorPalette.Fire;
                // добавить название
                this.chart_SAN.Titles.Add("Количество-отдел, шт.");

                // Add series.
                for (int i = 0; i < seriesArray.Length; i++)
                {
                    // Add series.
                    Series series = this.chart_SAN.Series.Add(seriesArray[i]);

                    // Add point.
                    series.Points.Add(pointsArray[i]);
                }
            }            
            catch
            {
                MessageBox.Show("Невозможно повторно построить график", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSum_SAN_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonSum_SAN_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonSumPrice_SAN_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonSumPrice_SAN_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonDone_SAN_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonDone_SAN_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void textBoxPoiskName_SAN_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxPoiskName_SAN.Text.ToLower(); //приведение к нижнему регистру
            foreach (DataGridViewRow row in dataGridViewMatrix_SAN.Rows)
            {
                if (row.Cells["name_SAN"].Value != null)
                {
                    string column2Text = row.Cells["name_SAN"].Value.ToString().ToLower();
                    if (column2Text.Contains(searchText))
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

        private void textBoxPoiskPostavshik_SAN_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = textBoxPoiskPostavshik_SAN.Text.ToLower(); //приведение к нижнему регистру
            foreach (DataGridViewRow row in dataGridViewMatrix_SAN.Rows)
            {
                if (row.Cells["postavshik_SAN"].Value != null)
                {
                    string column6Text = row.Cells["postavshik_SAN"].Value.ToString().ToLower();
                    if (column6Text.Contains(searchText))
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

        private void buttonSrZnach_SAN_Click(object sender, EventArgs e)
        {
            //заведение и заполнение матрицы
            int rows = dataGridViewMatrix_SAN.RowCount;
            int columns = dataGridViewMatrix_SAN.ColumnCount;
            string str;
            string[,] matrix = new string[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    str = "";
                    str += dataGridViewMatrix_SAN.Rows[i].Cells[j].Value;
                    matrix[i, j] = str;
                }

            }

            double sum = 0;
            int k = 0;
            double srzn = 0;
            // количество 
            for (int i = 0; i < rows - 1; i++)
            {
                k++;
            }
            // сумма 
            for (int i = 0; i < dataGridViewMatrix_SAN.RowCount; i++)
            {
                sum += Convert.ToDouble(dataGridViewMatrix_SAN[7, i].Value);
            }
            srzn = (sum / k);
            srzn = Math.Round(srzn, 3);
            textBoxSrZnach_SAN.Text = srzn.ToString();
        }
    }  
}
