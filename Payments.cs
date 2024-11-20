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
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction(new DatabaseHelper());
            dataGridView1.DataSource = transaction.GetDepositHistory(SessionManager.CurrentUser.ID);
            dataGridView2.DataSource = transaction.GetWithdrawalHistory(SessionManager.CurrentUser.ID);

        }
    }
}
