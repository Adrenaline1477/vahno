using System.Windows.Forms;

namespace WindowsFormsApp6
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonShowPass = new System.Windows.Forms.CheckBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.LabelGuest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(18, 62);
            this.loginField.Margin = new System.Windows.Forms.Padding(2);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(216, 20);
            this.loginField.TabIndex = 1;
            // 
            // passField
            // 
            this.passField.Location = new System.Drawing.Point(18, 99);
            this.passField.Margin = new System.Windows.Forms.Padding(2);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(216, 20);
            this.passField.TabIndex = 2;
            this.passField.TextChanged += new System.EventHandler(this.passField_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label3.Location = new System.Drawing.Point(18, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль";
            // 
            // buttonShowPass
            // 
            this.buttonShowPass.AutoSize = true;
            this.buttonShowPass.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.buttonShowPass.Location = new System.Drawing.Point(239, 102);
            this.buttonShowPass.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShowPass.Name = "buttonShowPass";
            this.buttonShowPass.Size = new System.Drawing.Size(117, 17);
            this.buttonShowPass.TabIndex = 5;
            this.buttonShowPass.Text = "Показать пароль";
            this.buttonShowPass.UseVisualStyleBackColor = true;
            this.buttonShowPass.CheckedChanged += new System.EventHandler(this.buttonShowPass_CheckedChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.buttonCancel.Location = new System.Drawing.Point(18, 136);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 32);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.buttonRegistration.Location = new System.Drawing.Point(128, 136);
            this.buttonRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(90, 32);
            this.buttonRegistration.TabIndex = 7;
            this.buttonRegistration.Text = "Регистрация";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.buttonEnter.Location = new System.Drawing.Point(239, 136);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(90, 32);
            this.buttonEnter.TabIndex = 8;
            this.buttonEnter.Text = "Вход";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // LabelGuest
            // 
            this.LabelGuest.Location = new System.Drawing.Point(0, 0);
            this.LabelGuest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelGuest.Name = "LabelGuest";
            this.LabelGuest.Size = new System.Drawing.Size(75, 15);
            this.LabelGuest.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 179);
            this.Controls.Add(this.LabelGuest);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonShowPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(379, 218);
            this.MinimumSize = new System.Drawing.Size(379, 218);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox loginField;
        private TextBox passField;
        private Label label2;
        private Label label3;
        private CheckBox buttonShowPass;
        private Button buttonCancel;
        private Button buttonRegistration;
        private Button buttonEnter;
        private Label LabelGuest;
    }
}