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
    public class Customer
    {
        private int customerID;
        private string fName;
        private string lName;
        private string email;
        private string phone;
        private DateTime dob;
        private double age;
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }
        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }
        public double Age
        {
            get { return age; }
            set { age = value; }
        }
        //Methods
        public Customer()
        {
            customerID = 0;
            fName = "John";
            lName = "Doe";
            email = "John.Doe@gmail.com";
            phone = "2051112222";
            dob = DateTime.Now;
        }
        public Customer(int id, string name1, string name2, string e, string p, DateTime d)
         {
            customerID = id;
            fName = name1;
            lName = name2;
            email = e;
            phone = p;
            dob = d;
         }
        public static bool IsEligible(DateTimePicker dob1)
        {
            Customer customer = new Customer();
            
            bool boo=false;
            double d4;
            DateTime d1 = DateTime.Today;
            DateTime d2 = DateTime.Today;
            TimeSpan d3;
            d1 = dob1.Value;
            d3 = (d2-d1);
            d4 = d3.TotalDays;
            if (d4 >= 7665)
            {
                boo = true;

            }
            else if(d4< 7665)
            {
                boo = false;
            }
            
            return boo;
        }
        public double GetAge(DateTimePicker dob2)
        {
            double d;
            double age;
            DateTime d1 = DateTime.Today;
            DateTime d2 = DateTime.Today;
            TimeSpan d3;
            d1 = dob2.Value;
            d3 = (d2-d1);
            d = d3.TotalDays;
            if (d >= 7665)
            {
                age = d / 365;

            }
            else
            {
                MessageBox.Show("You are not of age.");
                age = 0;
            }

            return age;
        }







    }
}
