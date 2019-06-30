using System;
using System.Collections.Generic;
using System.Text;

namespace BanckAccount
{
    //Simulate a bank account supporting opening/closing, withdrawals, and deposits of money. (sum / dif / open or close account)
    class CurrentAccount : BankAccount, IWithdrawMessage,IDepositMessage
    {
        private string name;
        private string cnp;
        private string iban;
        private decimal balance;
        private Status status;
        public enum Status { Open, Closed };


        public CurrentAccount (string name, string cnp, string iban, decimal balance) : base(name, cnp)
        {
            this.name = name;
            this.cnp = cnp;
            this.iban = iban;
            this.balance = balance;
            

        }

        public void AccountInfo()
        {
            Console.WriteLine($"I'm the Current Account, at your service Mr./Ms.{name}.\nYour CNP: {cnp}\nYour IBAN: {iban}\nYour Balance {balance} at {DateTime.Now.ToLongDateString()}");
        }

        public void WMessage()
        {
           Console.WriteLine($"At {DateTime.Now.ToShortTimeString()} you have made an withdrawel");
        } 

        public void Withdraw(decimal ammount)
        {
            if (status == Status.Closed)
            {
                Console.WriteLine("Denied Withdrawel operation from Current Account because the account is CLOSED, contact your Bank");

            }
            else
            {
                if (balance < ammount)
                {
                    Console.WriteLine($"Operation failed not enough funds your Funds are {balance} can't retrive {ammount} --- check account ");
                }
                else
                {
                    balance += ammount;
                }
            }

        }
        public void Deposit(decimal ammount)
        {
            if (status == Status.Closed)
            {
                Console.WriteLine("Denied Deposit operation to Current Account because the account is CLOSED, contact your Bank");
            }
            else
            {
                balance += ammount;
            }
        }

        public void DMessage()
        {
            Console.WriteLine($"At {DateTime.Now.ToShortTimeString()} you have made a deposit");
        }

        public void OpenAccount()
        {
            this.status = Status.Open;  
        }

        public void CloseAccount()
        {
            this.status = Status.Closed ;
        }

        
    }
}
