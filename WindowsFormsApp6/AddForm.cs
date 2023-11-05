using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class AddForm : Form
    {
        private bool guest;

        public AddForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем значения полей ввода
            string partName = textBox1.Text;
            string quantity = textBox2.Text;
            string description = textBox3.Text;
            string manufacturer = textBox4.Text;

            // Генерация случайной себестоимости
            double partCost = GenerateRandomCost();

            // Формируем строку с данными о части лекарства
            string partData = $"{partName};{quantity};{description};{manufacturer};{partCost}";

            try
            {
                // Задайте путь к файлу для сохранения данных
                string dataFilePath = @"C:\user\medicine_parts.txt";

                // Записываем данные в файл
                using (StreamWriter writer = new StreamWriter(dataFilePath, true))
                {
                    writer.WriteLine(partData);
                    writer.Flush();
                }

                // Очищаем поля ввода после добавления
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                // Оповещаем пользователя об успешном добавлении
                MessageBox.Show("Части лекарств успешно добавлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при добавлении части лекарств: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double GenerateRandomCost()
        {
            Random random = new Random();
            double minCost = 1; // Минимальная себестоимость
            double maxCost = 100; // Максимальная себестоимость
            return random.NextDouble() * (maxCost - minCost) + minCost;
        }

        private void AddMedicinePartForm_Load(object sender, EventArgs e)
        {

        }

        private void AddMedicinePartForm_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(guest);
            mainForm.Show();
            this.Hide();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}