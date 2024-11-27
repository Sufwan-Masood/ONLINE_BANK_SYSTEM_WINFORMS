using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_bank
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            label8.Text = $"Welcome {SessionManager.CurrentUser.FirstName} {SessionManager.CurrentUser.LastName}.";
            label1.Text = $"Your Current Balance is: {SessionManager.CurrentUser.Balance}.";
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Money add_Money = new Add_Money();
            add_Money.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Send_Money send_Money = new Send_Money();
            send_Money.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payments payments = new Payments();
            payments.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            My_Account my_Account = new My_Account();
            my_Account.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("T");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login_from = new Form1();
            login_from.Show();
        }
    }
}
