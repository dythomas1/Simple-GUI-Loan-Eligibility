using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExam
{
    public partial class Form1 : Form
    {
        private Customer customer;
        private Loan loan;
        public Form1()
        {
            InitializeComponent();

        }

        private void Eligibility_Click(object sender, EventArgs e)
        {
            customer = new Customer();
            loan = new Loan();
            
            bool check=false;
            check=Customer.IsEligible(dateTimePicker1);
            if (check == true)
            {
                customer.CustomerID = Int32.Parse(textBox1.Text);
                customer.FName = textBox2.Text;
                customer.LName = textBox3.Text;
                customer.Email = textBox4.Text;
                customer.Phone = textBox5.Text;
                customer.Dob = dateTimePicker1.Value;
                customer.Age=customer.GetAge(dateTimePicker1);
                customer.Age = Math.Round(customer.Age, 2);
                MessageBox.Show("You can receive the full loan amount of " + loan.LoanAmt + " with paying an interest of " + loan.InterestRate + 
                                ". Your agent is " + loan.AgentName + " and your ID number is " + loan.LoanID + ".");
                MessageBox.Show("Your age is " + customer.Age);
            }
            else
                MessageBox.Show("You are not 21, so you cannot receive a loan.");

            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        //ID
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //firstName
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //lastname
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //email
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        //phone
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = customer.CustomerID.ToString();
            textBox2.Text = customer.FName;
            textBox3.Text = customer.LName;
            textBox4.Text = customer.Email;
            textBox5.Text = customer.Phone;
        }
    }
}
