using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structGPT
{
    // Реализуйте структуру Account, содержащую номер счета и баланс.
    // Добавьте методы MakeDeposit() - для пополнения счета и WithdrawFunds() - для снятия денег со счета.
    // Проверьте, чтобы баланс не становился отрицательным при снятии денег.
    internal class Program
    {
        static void Main(string[] args)
        {
            Account lenar = new Account();

            lenar.CreditCardNumber = 2746_9999_2148_2901;
            lenar.Balans = 5000;

            Account.Print(lenar);

            Account.WithdrawFunds(ref lenar, 1000);
            Console.WriteLine(lenar.Balans);

            Account.MakeDeposit(ref lenar, 2000);
            Console.WriteLine(lenar.Balans);


            Account timerlan = new Account
            {
                CreditCardNumber = 2200_1234_5678_9012
            };
            Account.WithdrawFunds(ref timerlan, 1000);

            Account.MakeDeposit(ref timerlan, 200);
            Account.Print(timerlan);

            Account.WithdrawFunds(ref timerlan, 100);
            Account.Print(timerlan);

            Account.WithdrawFunds(ref timerlan, 100);
            Account.WithdrawFunds(ref timerlan, 900);

            Console.ReadKey();
        }
    }

    struct Account
    {
        public decimal CreditCardNumber { get; set; }
        public decimal Balans { get; set; }

        public static void WithdrawFunds(ref Account account, int value) // списывает, выводит
        {
            if ((account.Balans >= value) && (account.Balans > 0))
            {
                Console.WriteLine($"Снятие на: {value}p");
                account.Balans -= value;
            }
            else
            {
                Console.WriteLine("Недостаточно средств");
                Console.WriteLine($"Попытка снять {value}р c баланса - {account.Balans}p");
            }
        }
        public static void MakeDeposit(ref Account account, int value) // пополняет
        {
            Console.WriteLine($"Пополнение на: {value}p");
            account.Balans += value;
        }
        public static void Print(Account account)
        {
            Console.WriteLine("---");
            Console.WriteLine($"Номер карты: {account.CreditCardNumber}");
            Console.WriteLine($"Баланс: {account.Balans}p");
            Console.WriteLine("---");
        }

    }
}
