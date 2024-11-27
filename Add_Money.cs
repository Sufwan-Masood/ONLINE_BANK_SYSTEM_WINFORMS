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
    public partial class Add_Money : Form
    {
        public Add_Money()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please Fill All Mandatory Fields");
                return;

            }
            else if (decimal.Parse(textBox2.Text) <= 0)
            {
                MessageBox.Show("Please enter a valid amount to add", "-ve Transaction!", MessageBoxButtons.OK);
                return;
            }
            else if (textBox1.Text != "jazzcash" && textBox1.Text != "easypaisa")
            {
                MessageBox.Show("Money can only be added from 'jazzcash' or 'easypaisa'", "Error", MessageBoxButtons.OK);
                return;
            }
            else if (!checkPassword(textBox3.Text)) // password authentication
            {
                MessageBox.Show("Please Enter Correct Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (SessionManager.CurrentUser.addMoney(decimal.Parse(textBox2.Text))) // Added money in database
                {
                    SessionManager.CurrentUser.Balance = SessionManager.CurrentUser.Balance + decimal.Parse(textBox2.Text); // now adding in program
                    Console.WriteLine($"Updated balance: {SessionManager.CurrentUser.Balance}");
                    MessageBox.Show($"Transaction Successful \n Details:\nAmount Added: {textBox2.Text}\n Added From Account#: {textBox1.Text}\nTimestamp: {DateTime.Now.ToString("F")} \n Your Current Balance is now: {SessionManager.CurrentUser.Balance}", "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // adding transaction data (only deposits ,no withdraw in this case)
                    Transaction transaction = new Transaction(new DatabaseHelper());                                          // jazzcash or easypaisa
                    transaction.CreateTransaction(SessionManager.CurrentUser.ID, decimal.Parse(textBox2.Text), "deposit", textBox1.Text);

                }

            }
        }
        public bool checkPassword(string password)
        {
            if (password == SessionManager.CurrentUser.Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
