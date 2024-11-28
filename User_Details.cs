using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_bank
{
    public partial class User_Details : Form
    {
        public User_Details()
        {
            InitializeComponent();
        }

        private void User_Details_Load(object sender, EventArgs e)
        {
            label5.Text = @"Select user to get details of Transactions.";
            dataGridView2.Visible = false;
            dataGridView1.DataSource = SessionManager.CurrentUser.admin_getAllUsers();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                Transaction transaction = new Transaction(new DatabaseHelper());
                // the below function returns data_table of selected user transaction history
                dataGridView2.DataSource = transaction.GetTransactionHistory(id);
                dataGridView2.Visible = true;
                //                                            cell value 2 is name of selected user
                label5.Text = $"{dataGridView1.SelectedRows[0].Cells[2].Value}'s Current balance is: ${SessionManager.CurrentUser.admin_getSpecificUserBalance(id)}. ";
            }
            catch
            {
                Console.WriteLine("Error,select row!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_dashboard admin_Dashboard = new Admin_dashboard();
            admin_Dashboard.Show();
        }
    }
}
