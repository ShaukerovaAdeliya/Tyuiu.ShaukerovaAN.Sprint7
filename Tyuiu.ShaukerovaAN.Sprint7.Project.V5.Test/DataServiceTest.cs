using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShaukerovaAN.Sprint7.Project.V5.Lib;
using System.IO;

namespace Tyuiu.ShaukerovaAN.Sprint7.Project.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string filePath = @"C:\Users\shauk\source\repos\Tyuiu.ShaukerovaAN.Sprint7\Tyuiu.ShaukerovaAN.Sprint7.Project.V5\bin\Debug\base.csv";

            AddDataToCSV(filePath);
        }

        private void AddDataToCSV(string filePath)
        {
            try
            {
                using (var writer = new StreamWriter(filePath, true)) // открытие файла для записи
                {
                    // Пример добавления строчки 
                   writer.WriteLine("Артикул; Отдел");
                }
            }
            catch (Exception ex)
            {
                // Проверка на ошибки
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        [TestMethod]
        public void CheckCalculateSrZnach()
        {
            DataService ds = new DataService();
            double[] valuesSrZnachTest = { 20, 30, 40, 50, 60 };
            int RowCount = 5;
            double wait = 40;

            double res = ds.CalculateSrZnach(valuesSrZnachTest, RowCount);

            Assert.AreEqual(wait, res);
        }
    }
}




