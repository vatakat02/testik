using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sign_in
{
    public partial class SignIN : Form
    {
        public SignIN()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            SignUP a = new SignUP();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Заполните пустые поля");
                    }
             else
                {
                if (textBox1.Text == "123" & textBox2.Text == "123")
                {
                    MessageBox.Show("Добро пожаловать");
                }
                else
                {
                    MessageBox.Show("Неверный Логин или пароль");
                }
             }
        }

    }
}
