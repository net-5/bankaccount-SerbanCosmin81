using System;

namespace BanckAccount
{
    //    BankAccount
    //Simulate a bank account supporting opening/closing, withdrawals, and deposits of money. (sum / dif / open or close account)

    //It should be possible to close an account; operations against a closed account must fail. (deny operations if account close)

    //Remember you are working with money so you should use an appropriate data type for it. (decimal)
    class Program
    {
        static void Main(string[] args)
        {
            CurrentAccount myAccount = new CurrentAccount("Serban Cosmin", "18112160000", "RO19BRDE1234567891234567", 0.00M);
            myAccount.AccountInfo();
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////////\n");
            ShoppingAccount myShopAcc = new ShoppingAccount("Serban Cosmin", "18112160000", "RO19BRDE7654321987654321", 3000.00M);
            myShopAcc.AccountInfo();
            Console.WriteLine("**************************-MY ACCOUNT-*********************************\n");

            myAccount.Deposit(3000.55M);
            myAccount.DMessage();
            myAccount.AccountInfo();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

            myAccount.Withdraw(1550.34M);
            myAccount.WMessage();
            myAccount.AccountInfo();
            myAccount.Withdraw(155000.34M);

            Console.WriteLine("-------------------------------------------------------------------------------------------------\n-------------------------------------------------------------------------------------------------");
            Console.WriteLine("**************************-MY Shoping Account-*********************************\n");

            myShopAcc.Withdraw(1550.34M);
            myShopAcc.WMessage();
            myShopAcc.AccountInfo();
            myShopAcc.Withdraw(155000.34M);
            Console.WriteLine("-------------------------------------------------------------------------------------------------\n");

            myShopAcc.Deposit(300.55M);
            myShopAcc.DMessage();
            myShopAcc.AccountInfo();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

            myAccount.CloseAccount();
            myShopAcc.CloseAccount();

            myShopAcc.Withdraw(550.34M);
            myShopAcc.Deposit(3000.55M);
            myAccount.Withdraw(550.34M);
            myAccount.Deposit(3000.55M);

            Console.WriteLine("-------------------------------------------------------------------------------------------------\n");

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
        }
    }
}
