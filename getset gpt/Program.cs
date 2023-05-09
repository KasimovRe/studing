using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset_gpt
{
    // Создайте класс "BankAccount" с закрытым полем "balance". Добавьте свойства "Balance" и "InterestRate",
    // которые позволяют получать и устанавливать значения этих полей. Добавьте метод "Deposit", который
    // увеличивает баланс на заданную сумму, и метод "Withdraw", который уменьшает баланс на заданную сумму.
    // При попытке снять больше денег, чем есть на счету, должно возникать исключение.
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            Console.WriteLine(account.Balance);
            account.InterestRate = 100;

            Console.WriteLine(account.Balance);

            account.Deposit(10000);
            Console.WriteLine(account.Balance);

            account.Withdraw(100);
            Console.WriteLine(account.Balance);

            account.Withdraw(100001);
            Console.WriteLine(account.Balance);

            account.Withdraw(1000);
            Console.WriteLine(account.Balance);
        }
    }

    class BankAccount
    {
        private decimal balance;

        public decimal Balance { get { return balance; } }
        public decimal InterestRate { set { balance = value; } }

        public void Deposit(decimal value) { for (int i = 0; i < value; i++) { balance++; } }
        public void Withdraw(decimal value) 
        {
            if (balance >= value)
            {
                for (int i = 0; i < value; value--)
                {
                    balance--;
                };
            }
            else Console.WriteLine($"Недостаточно средств на карте для списания денег на сумму {value}");
        }
    }
}
