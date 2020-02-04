using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CourseApp.Business
{
    class BankAccount
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double Charge { get; private set; } = 3.00;

        public BankAccount(int number, string holder)
        {
            Number = number;
            Holder = holder;
        }
        public BankAccount(int number, string holder, double balance) : this(number, holder)
        {
            Balance = balance;
        }

        public double Deposit(params double[] depositAccount)
        {
            for (int i = 0; i < depositAccount.Length; i++)
            {
                Balance += depositAccount[i];
            }
            return Balance;
        }

        public double Withdraw(double withdraw)
        {
            return Balance = Balance - withdraw - Charge; 
        }

        public override string ToString()
        {
            return "\n" + "Número: " + Number
                 + "\n" + "Titular: " + Holder
                 + "\n" + "Saldo: " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
