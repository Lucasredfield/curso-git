using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CourseApp.Business
{
    class BankAccountBusiness
    {
        public void Start()
        {
            BankAccount bankAccount;

            Console.Write("Entre com número da Conta: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Entre com o Titular da Conta: ");
            string holder = Console.ReadLine().ToString();

            Console.Write("\n Haverá deposito inicial? (s/n) ");
            string depositInitial = Console.ReadLine().ToString();

            double balance = 0;

            if (depositInitial == "s" || depositInitial == "sim" || depositInitial == "S")
            {
                Console.Write("Entre com o valor incial de depósito: ");
                balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                bankAccount = new BankAccount(number, holder, balance);
            }
            else
            {
                bankAccount = new BankAccount(number, holder);
            }

            Console.Write("Dados da conta:");
            Console.WriteLine(bankAccount);

            Console.WriteLine("Deseja agendar depositos? (s/n) ");
            string deposit = Console.ReadLine().ToString();


            if (deposit == "s" || deposit == "sim" || deposit == "S")
            {
                Console.WriteLine("Quantos depositos?");
                int amount = int.Parse(Console.ReadLine());

                for (int i = 0; i < amount; i++)
                {
                    Console.WriteLine("Insira o valor [" + i + "]");
                    double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    bankAccount.Deposit(value);
                }
                Console.Write("Dados da conta atualizados após o recebimento dos depositos:");
                Console.WriteLine(bankAccount);
            }                 


            Console.Write("Entre com um valor para saque: \n[Taxa de serviço: R$" + bankAccount.Charge + "]  ");
            double amountWithdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            bankAccount.Withdraw(amountWithdraw);

            Console.Write("Dados da conta atualizados:");
            Console.WriteLine(bankAccount);

            Console.Read();
        }
    }
}
