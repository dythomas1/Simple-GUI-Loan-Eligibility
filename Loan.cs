using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class Loan
    {
        private int loanID;
        private string agentName;
        private double loanAmt;
        private double interestRate;
        private string customer;
        public int LoanID
        {
            get { return loanID; }
            set { loanID = value; }
        }
        public string AgentName
        {
            get { return agentName; }
            set { agentName = value; }
        }
        public double LoanAmt
        {
            get { return loanAmt; }
            set { loanAmt = value; }
        }
        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }
        public string Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public Loan(int id, string name, double amt, double rate, string cust)
        {
            loanID = id;
            agentName = name;
            loanAmt = amt;
            interestRate = rate;
            customer = cust;
        }
        public Loan()
        {
            loanID = 1;
            agentName = "Drew Thomas";
            loanAmt= 10000;
            interestRate = .10;
            Customer = " ";
        }

    }
}
