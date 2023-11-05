using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp6
{
    public partial class SearchForm : Form
    {
        private bool guest;

        public SearchForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.Trim();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                try
                {
                    string dataFilePath = @"C:\user\medicine_parts.txt";
                    List<string> searchResults = new List<string>();

                    // Считываем строки из файла и проверяем, содержат ли они поисковый запрос
                    foreach (string line in File.ReadLines(dataFilePath))
                    {
                        if (line.Contains(searchTerm))
                        {
                            searchResults.Add(line);
                        }
                    }

                    // Очищаем список результатов и добавляем найденные строки
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(searchResults.ToArray());

                    if (searchResults.Count == 0)
                    {
                        MessageBox.Show("Ничего не найдено.", "Результаты поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка при поиске: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите поисковый запрос.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm addForm = new MainForm(guest);
            addForm.Show();
            this.Hide();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MainForm addForm = new MainForm(guest);
            addForm.Show();
            this.Hide();
        }
    }
}
