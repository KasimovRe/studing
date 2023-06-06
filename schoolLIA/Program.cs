using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolLIA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // даны 2 угла треугольника (в градусах)
            // определить, сущ ли такой треуг, и если да, 
            // то будет ли он прямоугольным

            int a = Convert.ToInt32(Console.ReadLine()); // первый угол
            int b = Convert.ToInt32(Console.ReadLine()); // второй угол

            if ((a + b <= 90) && (a > 0) && (b > 0)) // сумма 2 углов должна быть меньше 180 градусов
            {                                         
                Console.WriteLine("Да, такой треугольник существует");

                if (a + b == 90) // если сумма 2 углов будет 90, то 3 угол
                                 // тоже будет 90 градусов. и треуг будет прямоугольнымппмрнпнпе
                {
                    Console.WriteLine("Треугольник прямоугольный");
                }
                else // если условие выше неверное, то треуг не прямоугольный
                {
                    Console.WriteLine("Треугольник НЕ прямоугольный");
                }
            }
            else // если сумма 2 углов больше 90, то такого не сущ 
            {
                Console.WriteLine("Такого треугольника не существует");
            }

            Console.ReadKey();
        }
    }
}
