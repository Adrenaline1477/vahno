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
    public partial class LoginForm : Form
    {
        public bool guest = false;

        public LoginForm()
        {
            InitializeComponent();
            passField.UseSystemPasswordChar = true;
        }

        private void buttonShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonShowPass.Checked)
            {
                passField.UseSystemPasswordChar = false;
            }
            else
            {
                passField.UseSystemPasswordChar = true;
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            RegistrationForm regiterForm = new RegistrationForm();
            regiterForm.Show();
            this.Hide();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {

            string login = loginField.Text;
            string password = passField.Text;

            if (IsUserValid(login, password))
            {
                this.Hide();

                MainForm main = new MainForm(guest);
                main.Show();
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль.");
            }
        }

        private bool IsUserValid(string login, string password)
        {
            string[] lines = File.ReadAllLines(@"C:\user\loginPass.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                if (parts[0] == login && parts[1] == password)
                {
                    return true;
                }
            }
            return false;
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void passField_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
