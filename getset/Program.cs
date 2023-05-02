using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset
{
    class Point
    {
        private int y = 0;

        public int Yprint
        {
            get { return y; }
            set { y = value * 11; }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point y = new Point();

            y.Yprint = 10;

            Console.WriteLine(y);
        }
    }
}
