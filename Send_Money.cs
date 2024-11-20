using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SE_bank
{
    public partial class Send_Money : Form
    {
        public Send_Money()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "") // all fields are filled
            {
                MessageBox.Show("Please Fill All Mandatory Fields", "Error", MessageBoxButtons.OK);
            }
            if (!checkPassword(textBox3.Text)) // password authentication
            {
                MessageBox.Show("Please Enter Correct Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (textBox1.Text == SessionManager.CurrentUser.IBAN) //Self transactions are not allowed
            {
                MessageBox.Show("\nSelf transactions are not allowed, Please Enter other IBAN number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (decimal.Parse(textBox2.Text) > SessionManager.CurrentUser.Balance)  //Insufficient Balance
                {
                    MessageBox.Show("Insufficient Balance PLease Try Again");
                }
                else
                {

                    string query1 = $"Update Users Set Balance = Balance + {textBox2.Text} where IBAN = '{textBox1.Text}'"; // deposit to other recipient's account
                    bool recipent = DatabaseHelper.DB_update(query1);
                    if (recipent)
                    {
                        SessionManager.CurrentUser.Balance = SessionManager.CurrentUser.Balance - decimal.Parse(textBox2.Text);
                        Console.WriteLine($"Updated balance: {SessionManager.CurrentUser.Balance}");
                        string query2 = $"Update Users Set Balance ='{SessionManager.CurrentUser.Balance}' where IBAN = '{SessionManager.CurrentUser.IBAN}' "; // Withdrawal from Your account
                        DatabaseHelper.DB_update(query2);
                        MessageBox.Show($"Transaction Successful \n Details:\nAmount Sent: {textBox2.Text}\nRecipient Account#: {textBox1.Text}\nTimestamp: {DateTime.Now.ToString("F")} \n Your Current Balance is now: {SessionManager.CurrentUser.Balance}", "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Adding transaction records;

                        //sender (withdraw transaction)
                        Transaction transaction = new Transaction(new DatabaseHelper());
                        transaction.CreateTransaction(SessionManager.CurrentUser.ID, decimal.Parse(textBox2.Text), "Withdrawal");

                        //recipient (deposit transaction)
                        string query_get_recipientID = $"Select UserID from Users where IBAN = '{textBox1.Text}'";
                        int recipient_ID = (int)transaction.dbHelper.GetScalarValue(query_get_recipientID); //getting recipientID from DB
                        transaction.CreateTransaction(recipient_ID, decimal.Parse(textBox2.Text), "Deposit");

                    }
                    else
                    {
                        MessageBox.Show("Transaction Failed, make sure IBAN is correct", "Error");
                    }
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
