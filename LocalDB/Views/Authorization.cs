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
using LocalDB.Models;
using LocalDB.Services;

namespace LocalDB.Views
{
    public partial class Authorization : Form
    {
        public StaffModel Staff { get; set; }

        private readonly SqlService _sqlService;

        public Authorization()
        {
            InitializeComponent();
            _sqlService = new SqlService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userName = textBox1.Text.Trim().ToLower();
            var password = textBox2.Text;
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Логин и пароль должны быть введены!", "Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            var hashedPassword = CreateMD5(password).ToLower();
            Staff = _sqlService.Authorize(userName, hashedPassword);
            if (Staff == null)
            {
                MessageBox.Show("Введены неверный логин и/или пароль!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static string CreateMD5(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
