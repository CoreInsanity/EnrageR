using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrageR
{
    public partial class Login : Form
    {
        private bool LoggedIn;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!LoggedIn) Environment.Exit(0);
        }
        private string ComputeHash(string email)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(String.Format("{0}-{1}", email.ToLower(), DateTime.UtcNow.Month)));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                    builder.Append(bytes[i].ToString("x2"));
                return builder.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ComputeHash(textBox2.Text).ToLower() == textBox1.Text.ToLower())
            {
                if (DateTime.Now >= DateTime.Parse("04/07/2020"))
                {
                    MessageBox.Show("Outdated client, please update");
                    Environment.Exit(0);
                }
                try
                {
                    var regKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\EnrageR");
                    regKey.SetValue("Email", textBox2.Text);
                    regKey.SetValue("Key", textBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong while saving your key\n\n" + ex.Message);
                }

                LoggedIn = true;
                this.Close();
            }
            else MessageBox.Show("Incorrect key");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                RegistryKey regKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\EnrageR");
                if (regKey != null)
                {
                    var email = regKey.GetValue("Email").ToString();
                    var key = regKey.GetValue("Key").ToString();
                    regKey.Close();
                    if (ComputeHash(email) == key.ToLower())
                    {
                        LoggedIn = true;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while fetching your key\n\n" + ex.Message);
            }
        }
    }
}
