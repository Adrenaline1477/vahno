using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            userPassField.UseSystemPasswordChar = true;
            userPassField2.UseSystemPasswordChar = true;
        }
        private void buttonСontinue_Click(object sender, EventArgs e)
        {

            string login = userLoginField.Text;
            string password = userPassField.Text;
            string password2 = userPassField2.Text;

            if (userLoginField.Text == "" || userPassField.Text == "" || userPassField2.Text == "")
            {
                MessageBox.Show("Поле не должно быть пустым");
                return;
            }
            if (PasswordSecurity())
            {
                return;
            }

            if (IsUserRegistered(login))
            {
                MessageBox.Show("Пользователь с таким именем уже существует. Попробуйте другое имя пользователя.");
                return;
            }

            SaveUserCredentials(login, password);

            MessageBox.Show("Вы зарегестрировали аккаунт");
            this.Hide();

            LoginForm lg = new LoginForm();
            lg.Show();

        }

        private void SaveUserCredentials(string login, string password)
        {
            string line = login + ";" + password;
            File.AppendAllText(@"C:\user\loginPass.txt", line + Environment.NewLine);
        }
        private bool IsUserRegistered(string login)
        {
            string[] lines = File.ReadAllLines(@"C:\user\loginPass.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                if (parts[0] == login)
                {
                    return true;
                }
            }
            return false;
        }
        public Boolean PasswordSecurity()
        {

            Regex nymber = new Regex(@"[0-9]");
            Regex symbol = new Regex(@"[!@#$%^.]");
            Regex letter = new Regex(@"[A-Z]");

            if (userPassField.Text != userPassField2.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return true;
            }
            if (nymber.IsMatch(userPassField.Text) && symbol.IsMatch(userPassField.Text) && letter.IsMatch(userPassField.Text))
            {
                return false;
            }
            else
            {
                MessageBox.Show("Пароль не соответствует требованиям,должен содержать заглавную букву, хотя бы одно число и знак");
                return true;
            }
        }

        private void buttonAuthorization_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void buttonShowPass_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (buttonShowPass.Checked)
                {
                    userPassField.UseSystemPasswordChar = false;
                }
                else
                {
                    userPassField.UseSystemPasswordChar = true;
                }

                if (buttonShowPass.Checked)
                {
                    userPassField2.UseSystemPasswordChar = false;
                }
                else
                {
                    userPassField2.UseSystemPasswordChar = true;
                }
            }
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void userLoginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
