using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskadonet
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text))
            {
                var usersDB = new UsersDB();
                var users = usersDB.GetUsers();
                bool flag = false;
                foreach (var user in users)
                {
                    if (textBox2.Text.ToLower() == user.Login.ToLower())
                    {
                        flag = true; 
                        break;
                    }
                }
                if (flag)
                {
                    MessageBox.Show("User with this login already exists.");
                    textBox1.Text = string.Empty;
                    numericUpDown1.Value = 18;
                    textBox2.Text = string.Empty;
                    textBox3.Text = string.Empty;
                }
                else
                {
                    var new_user = new User() { Age = (int)numericUpDown1.Value, Login = textBox2.Text, Name = textBox1.Text, Password = textBox3.Text };
                    usersDB.AddUser(new_user);
                    MessageBox.Show("Successful registration. Welcome!");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Fill all boxes.");
            }
        }
    }
}
