using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public class Account
    {
        private int checkingTotal;
        private int savingsTotal;
        private List<string> checkingBalance;
        private List<string> savingsBalance;
        private string pin;

        public Account(string p)
        {
            this.checkingTotal = 1000;
            this.savingsTotal = 1000;
            this.checkingBalance = new List<string>();
            this.savingsBalance = new List<string>();
            this.checkingBalance.Add("Deposit of 1000 $CAD");
            this.savingsBalance.Add("Deposit of 1000 $CAD");
            this.pin = p;
        }
        public void changeBalance(string statement, string type)
        {
            if (type.Equals("Checking"))
            {
                checkingBalance.Add(statement);
            }
            else if (type.Equals("Savings"))
            {
                savingsBalance.Add(statement);
            }
            
        }
        public int CheckingTotal
        {
            get
            {
                return checkingTotal;
            }
            set
            {
                checkingTotal = value;
            }
        }
        public int SavingsTotal
        {
            get
            {
                return savingsTotal;
            }
            set
            {
                savingsTotal = value;
            }
        }
        public string Pin
        {
            get
            {
                return pin;
            }
          
        }






    }
}
