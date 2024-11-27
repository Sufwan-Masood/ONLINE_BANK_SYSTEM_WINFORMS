namespace SE_bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Fill All Fields", "Error", MessageBoxButtons.OK);
            }
            else
            {
                //string query = $"Select * from Users where Email= {textBox1.Text} AND Password = {textBox1.Text}";

                if (User.Authenticate(textBox1.Text, textBox2.Text) == true)
                {
                    if (SessionManager.CurrentUser.IsAdmin == true) // for admin panel
                    {

                        MessageBox.Show($"Logged IN Successfully as a Admin: {SessionManager.CurrentUser.FirstName} {SessionManager.CurrentUser.LastName}.", "Success", MessageBoxButtons.OK);
                        this.Hide();
                        Admin_dashboard admin_dash = new Admin_dashboard();
                        admin_dash.Show();
                    }
                    else // for user dashboard
                    {
                        MessageBox.Show($"Logged IN Successfully as a User: {SessionManager.CurrentUser.FirstName} {SessionManager.CurrentUser.LastName}.", "Success", MessageBoxButtons.OK);
                        this.Hide();
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Error in LogIn, Make sure you have already signed up");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }
    }
}