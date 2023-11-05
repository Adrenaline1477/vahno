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
    public partial class MainForm : Form
    {
        public bool guest1;

        public MainForm(bool guest)
        {
            InitializeComponent();
            this.guest1 = guest;

        }
        private void MainForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            openFileDialog1.FileName = @"data\Text2.txt";
            openFileDialog1.Filter =
                     "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Filter =
                     "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteForm addForm = new DeleteForm();
            addForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchForm addForm = new SearchForm();
            addForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CalculatingForm addForm = new CalculatingForm();
            addForm.Show();
            this.Hide();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            string dataFilePath = @"C:\user\medicine_parts.txt";

            if (File.Exists(dataFilePath))
            {
                string[] documentLines = File.ReadAllLines(dataFilePath);
                listBox1.Items.AddRange(documentLines);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load_2(object sender, EventArgs e)
        {
            string dataFilePath = @"C:\user\medicine_parts.txt";

            if (File.Exists(dataFilePath))
            {
                string[] documentLines = File.ReadAllLines(dataFilePath);
                listBox1.Items.AddRange(documentLines);
            }
        }
    }
}