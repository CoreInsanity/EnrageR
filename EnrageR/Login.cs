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
            if(!LoggedIn) Environment.Exit(0);
        }
        private string ComputeHash(string email)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(String.Format("{0}-{1}", email, DateTime.UtcNow.Month)));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ComputeHash(textBox2.Text).ToLower() == textBox1.Text.ToLower())
            {
                LoggedIn = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect hash");
            }
        }
    }
}
