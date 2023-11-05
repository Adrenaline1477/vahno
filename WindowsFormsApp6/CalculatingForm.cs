using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace WindowsFormsApp6
{
    public partial class CalculatingForm : Form
    {
        private bool guest;
        private Dictionary<string, double> medicineCosts = new Dictionary<string, double>();


        public CalculatingForm()
        {
            InitializeComponent();
            string dataFilePath = @"C:\user\medicine_parts.txt";

            if (File.Exists(dataFilePath))
            {
                string[] lines = File.ReadAllLines(dataFilePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 5)
                    {
                        string medicineName = parts[0];
                        double partCost = double.Parse(parts[4]);

                        // Создаем объект, чтобы хранить данные о лекарстве
                        var medicineInfo = new MedicineInfo { Name = medicineName, Cost = partCost };

                        // Добавляем лекарство в listBox1
                        listBox1.Items.Add(medicineInfo);
                    }
                }
                listBox1.DisplayMember = "Name";

            }
            else
            {
                MessageBox.Show("Файл с информацией о частях лекарств не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateCostButton_Click(object sender, EventArgs e)
        {
            MedicineInfo selectedMedicine = listBox1.SelectedItem as MedicineInfo;

            if (selectedMedicine != null)
            {
                double totalCost = selectedMedicine.Cost;
                string message = $"Себестоимость для лекарства '{selectedMedicine.Name}' составляет: ${totalCost:F2}";
                MessageBox.Show(message, "Результат расчета", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Выберите лекарство из списка.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MainForm addForm = new MainForm(guest);
            addForm.Show();
            this.Hide();
        }
        private void CalculatingForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    // Создаем класс для хранения информации о лекарстве
    public class MedicineInfo
    {
        public string Name { get; set; }
        public double Cost { get; set; }
    }
}
