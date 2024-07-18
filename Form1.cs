namespace taskadonet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                var usersDB = new UsersDB();
                var users = usersDB.GetUsers();
                User required_user = new User();
                bool flag = true;
                foreach (var user in users)
                {
                    if (user.Login.ToLower() == textBox1.Text.ToLower())
                    {
                        required_user = user;
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    MessageBox.Show("There is no user with this login.");
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                }
                else
                {
                    if (required_user.Password == textBox2.Text)
                    {
                        MessageBox.Show("Successful authorization. Welcome!");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password.");
                        textBox1.Text = string.Empty;
                        textBox2.Text = string.Empty;
                    }
                }
            }
            else
            {
                MessageBox.Show("Fill all boxes.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sign_up_form = new Form2();
            sign_up_form.ShowDialog();
            Close();
        }
    }
}
