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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Please Fill All Fields", "Error", MessageBoxButtons.OK);
            }
            else
            {
                if (textBox6.Text != textBox7.Text)
                {
                    MessageBox.Show("Password Mismatch");
                }
                else
                {
                    string query = $"INSERT INTO Users (FirstName, LastName, Email, DOB, Contact, Password, Balance, IsAdmin) " +
                                  $"VALUES ('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}', '{textBox5.Text}', '{textBox6.Text}', 0.00, 0)";

                    if (DatabaseHelper.AddUser(query))
                    {
                        MessageBox.Show("User Successfully Signed Up");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Mandatory Field, Please Enter!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }


        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Focus();
                errorProvider1.SetError(textBox1, "Mandatory Field, Please Enter!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Focus();
                errorProvider1.SetError(textBox1, "Mandatory Field, Please Enter!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Focus();
                errorProvider1.SetError(textBox1, "Mandatory Field, Please Enter!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Focus();
                errorProvider1.SetError(textBox1, "Mandatory Field, Please Enter!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Focus();
                errorProvider1.SetError(textBox1, "Mandatory Field, Please Enter!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Focus();
                errorProvider1.SetError(textBox1, "Mandatory Field, Please Enter!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginForm= new Form1();
            loginForm.Show();
        }
    }
}
