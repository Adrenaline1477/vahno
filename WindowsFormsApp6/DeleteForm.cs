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

namespace WindowsFormsApp6
{
    public partial class DeleteForm : Form
    {
        private bool guest;

        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            string dataFilePath = @"C:\user\medicine_parts.txt";

            if (File.Exists(dataFilePath))
            {
                listBox1.Items.AddRange(File.ReadAllLines(dataFilePath));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int selectedIndex = listBox1.SelectedIndex;

                string selectedDocument = listBox1.SelectedItem.ToString();
                listBox1.Items.RemoveAt(selectedIndex);

                // Удалите выбранный документ из файла
                string dataFilePath = @"C:\user\medicine_parts.txt";
                List<string> lines = new List<string>(File.ReadAllLines(dataFilePath));
                lines.RemoveAt(selectedIndex);
                File.WriteAllLines(dataFilePath, lines);
            }
            else
            {
                MessageBox.Show("Выберите документ для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MainForm addForm = new MainForm(guest);
            addForm.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
