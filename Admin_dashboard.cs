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
    public partial class Admin_dashboard : Form
    {
        public Admin_dashboard()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString("T");

        }

        private void Admin_dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label7.Text = $"Welcome {SessionManager.CurrentUser.FirstName} {SessionManager.CurrentUser.LastName} (Admin).";

            label1.Text = "Bank's Total Reserves $: " + SessionManager.CurrentUser.admin_getTotalBalance();
            label2.Text = "Average User Balance $: " + SessionManager.CurrentUser.getAvgUserBalance();
            label3.Text = "Average Transaction Amount $: " + SessionManager.CurrentUser.GetAverageTransactionAmount();
            label4.Text = "Average Deposited Amount $: " + SessionManager.CurrentUser.GetAvgDepositsAmount();
            label5.Text = "Average Withdrawal Amount $: " + SessionManager.CurrentUser.GetAvgWithdrawalAmount();
            label9.Text = "Total Number of Deposits: " + SessionManager.CurrentUser.GetTotalDepositsCount();
            label10.Text = "Total Number of Withdraws: " + SessionManager.CurrentUser.GetTotalWithdrawsCount();
            label11.Text = "Total Number of Active Accounts: " + SessionManager.CurrentUser.getActiveAccounts();
            label12.Text = "Largest Single Transaction $: " + SessionManager.CurrentUser.largestSingleTransaction();
            label13.Text = "Total Deposited Amount $: " + SessionManager.CurrentUser.GetTotalDepositsAmount();
            label14.Text = "Total Withdrawal Amount $: " + SessionManager.CurrentUser.GetTotalWithdrawalAmount();
            label15.Text = "Most Frequent Transaction Type: " + SessionManager.CurrentUser.mostFreqTransactionType();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Details user_DetailsForm = new User_Details();
            user_DetailsForm.Show();
        }
    }
}
