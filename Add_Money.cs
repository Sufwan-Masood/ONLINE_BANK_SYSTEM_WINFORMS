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
            }
            else
            {
                string query = $"Select Balance from Users where IBAN='{textBox1.Text}'";
                decimal balance = (decimal)DatabaseHelper.DB_getBalance(query);
                Console.WriteLine($"BALANCE IS {balance}");

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
