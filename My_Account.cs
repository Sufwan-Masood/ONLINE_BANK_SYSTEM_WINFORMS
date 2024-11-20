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
    public partial class My_Account : Form
    {
        public My_Account()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void My_Account_Load(object sender, EventArgs e)
        {
            label1.Text = "First Name: "+SessionManager.CurrentUser.FirstName.ToString();
            label2.Text = "Last Name: "+SessionManager.CurrentUser.LastName.ToString();
            label3.Text = "Email: "+SessionManager.CurrentUser.Email.ToString();
            label5.Text = "Contact No: "+SessionManager.CurrentUser.Contact.ToString();
            label6.Text = "Current Balance: "+SessionManager.CurrentUser.Balance.ToString();
            label7.Text = "IBAN: "+SessionManager.CurrentUser.IBAN.ToString();
            label9.Text = "User ID: "+SessionManager.CurrentUser.ID.ToString();
            label10.Text= "Password: "+SessionManager.CurrentUser.Password.ToString();
        }
    }
}
