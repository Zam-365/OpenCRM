﻿using System.Windows;
using System.Windows.Input;
using OpenCRM.Models.Login;

namespace OpenCRM.Views.Login
{
    /// <summary>
    /// Controller del Login.xaml
    /// </summary>
    public partial class Login
    {
        private LoginModel loginM;
        public Login()
        {
            InitializeComponent();
            loginM = new LoginModel(ErrorLabel);
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            loginM.ValidateFields(tbxUsername.Text, tbxPassword.Password);
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            tbxUsername.Text = "";
            tbxPassword.Password = "";
        }

        private void LoginKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                loginM.ValidateFields(tbxUsername.Text, tbxPassword.Password);
        }
        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            LoginKeyDown(sender, e);
        }

        private void tbxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            LoginKeyDown(sender, e);
        }

    }
}
