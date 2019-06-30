using System;
using System.Collections.Generic;
using System.Text;

namespace BanckAccount
{
    //Simulate a bank account supporting opening/closing, withdrawals, and deposits of money. (sum / dif / open or close account)
    public class BankAccount
    {
        
        private string name;
        private string cnp;

        public BankAccount(string name, string cnp)  
        {
            this.name = name;
            this.cnp = cnp;
            
        }
    }
}
