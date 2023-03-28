using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace stud3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tarif, sum;

            Console.WriteLine("Доступны следующие тарифы:");
            Console.WriteLine("#1: 1 месяц = 60р");
            Console.WriteLine("#2: 3 месяца = 180р + 5% скидка");
            Console.WriteLine("#3: 6 месяцев = 360р + 10% скидка");
            Console.WriteLine("#4: 12 месяцев = 720р + 15% скидка");
            Console.WriteLine("Введите номер желаемой подписки (укажите ТОЛЬКО цифру)");

            tarif = int.Parse(Console.ReadLine());
            sum = 60;

            switch (tarif)
            {
                case 1:
                    Console.WriteLine("Ваша стоимость подписки - " + sum + "p.");
                    break;
                case 2:
                    double sum1 = (sum * 3 * 0.95);
                    Console.WriteLine("Ваша стоимость подписки, включая скидку 5% = " + sum1 + "p.");
                    break;
                case 3:
                    double sum2 = (sum * 6 * 0.90);
                    Console.WriteLine("Ваша стоимость подписки, включая скидку 10% = " + sum2 + "p.");
                    break;
                case 4:
                    double sum3 = (sum * 12 * 0.85);
                    Console.WriteLine("Ваша стоимость подписки, включая скидку 15% = " + sum3 + "p.");
                    break;
                default:
                    Console.WriteLine("Выбранной вами подписки не существует");
                    break;
            }
            Console.ReadLine();

        }
    }
}
