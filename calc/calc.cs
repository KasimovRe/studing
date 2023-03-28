using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    internal class calc
    {
        static void Main(string[] args)
        {
            double n1, n2 ;
            string metod;

            while (true)
            {   Console.Clear();
                Console.WriteLine("Введите число 1");
                n1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите число 2");
                n2 = double.Parse(Console.ReadLine());


                Console.WriteLine("Выберите метод операции:");
                Console.WriteLine("(+) =1, (-) =2, (*) =3, (/) =4");
                metod = (Console.ReadLine());

                switch (metod)
                {
                    case "1":
                        Console.WriteLine(n1 + n2);
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine(n1 - n2);
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine(n1 * n2);
                        Console.ReadLine();
                        break;
                    case "":
                        if (n2 == 0)
                        {
                            Console.WriteLine("0");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine(n1 / n2);
                            Console.ReadLine();
                        }
                        break;
                    default:
                        Console.WriteLine("Некоректно введены значения");
                        Console.ReadLine();
                        break;
                        // меньше моих предыдущих кодов на >20 строчек. фунционал тот же, только не так "красиво"
                }
            }
        }
    }
}
