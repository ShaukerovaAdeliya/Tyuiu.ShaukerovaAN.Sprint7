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

        private bool IsValidDateFormat(string dateText)
        {
            DateTime result;
            return DateTime.TryParseExact(dateText, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out result);
        }
       

        private void buttonFilter_SAN_Click(object sender, EventArgs e)
        {
            // Проверяем, выбрана ли сортировка по алфавиту
            if (comboBoxFilter_SAN.SelectedItem != null && comboBoxFilter_SAN.SelectedItem.ToString() == "По алфавиту")
            {
                // Проводим сортировку по алфавиту
                SortDataTableAlphabetically();
            }
            // Проверяем, выбрана ли сортировка по артикулу
            else if (comboBoxFilter_SAN.SelectedItem != null && comboBoxFilter_SAN.SelectedItem.ToString() == "По артикулу")
            {
                // Проводим сортировку по артикулу
                SortDataTableByArticule();
            }
            // Проверяем, выбрана ли сортировка по отделу
            else if (comboBoxFilter_SAN.SelectedItem != null && comboBoxFilter_SAN.SelectedItem.ToString() == "По отделу")
            {
                // Проводим сортировку по отделу
                SortDataTableByOtdel();
            }
            else
            {
                // Другие варианты фильтрации, если необходимо

            }
        }
        private void SortByAlphabet() 
        {
            // Получаем столбец DataGridView, который нужно отсортировать
            DataGridViewColumn column = dataGridViewMatrix_SAN.Columns[2];

            // Проверка, была ли уже выполнена сортировка по этому столбцу
            if (dataGridViewMatrix_SAN.SortOrder == SortOrder.Ascending)
            {
                // Если была выполнена сортировка по возрастанию, выполнить сортировку по убыванию
                dataGridViewMatrix_SAN.Sort(column, ListSortDirection.Descending);
            }
            else
            {
                // Если не было выполнено сортировки или была выполнена сортировка по убыванию, выполнить сортировку по возрастанию
                dataGridViewMatrix_SAN.Sort(column, ListSortDirection.Ascending);
            }
        }

        private void SortDataTableAlphabetically()
        {
            // Проверяем, есть ли у DataGridView связанный источник данных
            if (dataGridViewMatrix_SAN.DataSource is DataTable dataTable)
            {
                // Получаем представление данных
                DataView dataView = dataTable.DefaultView;

                // Проводим сортировку по первому столбцу
                dataView.Sort = $"{dataTable.Columns[2].ColumnName} ASC";

                // Применяем изменения к DataGridView
                dataGridViewMatrix_SAN.DataSource = dataView.ToTable();
            }
            else
            {
                // Если DataGridView не связан с DataTable, нечего сортировать
                MessageBox.Show("Сначала загрузите данные в DataGridView.");
            }
        }

        private void SortDataTableByArticule()
        {
            if (dataGridViewMatrix_SAN.DataSource is DataTable dataTable)
            {
                // Конвертируем строки с датами в объекты DateTime
                foreach (DataRow row in dataTable.Rows)
                {
                    if (DateTime.TryParseExact(row[1].ToString(), "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
                    {
                        row[1] = date;
                    }
                }

                // Создаем представление данных
                DataView dataView = dataTable.DefaultView;

                // Сортируем данные по дате в порядке убывания
                dataView.Sort = $"{dataTable.Columns[1].ColumnName} DESC";

                // Применяем изменения к DataGridView
                dataGridViewMatrix_SAN.DataSource = dataView.ToTable();


            }
            else
            {
                MessageBox.Show("Сначала загрузите данные в DataGridView.");
            }
        }
        private void SortDataTableByOtdel()
        {
            // Проверяем, что в DataGridView есть связанный источник данных и это DataTable
            if (dataGridViewMatrix_SAN.DataSource is DataTable dataTable)
            {
                // Конвертируем строки с окладами в числовой формат
                foreach (DataRow row in dataTable.Rows)
                {
                    // Получаем текущее значение оклада в строке
                    string salaryString = row["Артикул"].ToString();

                    // Удаляем все символы, кроме цифр и точки
                    string numericString = new string(salaryString.Where(c => char.IsDigit(c) || c == '.').ToArray());

                    // Пытаемся преобразовать в число
                    if (decimal.TryParse(numericString, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal salary))
                    {
                        // Записываем числовое значение обратно в ячейку
                        row["Артикул"] = salary;
                    }
                }

                // Сортируем данные по числовому столбцу "Оклад" в порядке возрастания
                dataTable.DefaultView.Sort = "Артикул ASC";

                // Применяем изменения к DataGridView
                dataGridViewMatrix_SAN.DataSource = dataTable;

                // Отображение данных на графике (если нужно)
                // DisplayChart(dataTable);
            }
            else
            {
                MessageBox.Show("Сначала загрузите данные в DataGridView.");
            }
        }

       
    }

}
