using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace str_delete
{
    // написать код, который удаляет первый и последний символ в строке
    internal class Program
    {
        static void Main(string[] args)
        {
            string userWords = Console.ReadLine();
            char[] str = new char[userWords.Length];

            ArrayWord(str, userWords);
            ArrayDelete(ref str);

            for (int i = 0; i < str.Length; i++)
                Console.Write(str[i]);

            // или же... тот же код в одну строчку

            Console.WriteLine("\n" + "\n" + userWords.Remove(userWords.Length - 1, 1).Remove(0, 1));
        }

        /// <summary>
        /// Преобразует текст в массив, состоящий из символов непосредственно текста типа "char"
        /// </summary>
        /// <param name="str"></param>
        /// <param name="userWords"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        static char[] ArrayWord(char[] str, string userWords, int i = 0)
        {
            foreach (char word in userWords)
            {
                str[i] = word;
                i++;
            }
            return str;
        }

        /// <summary>
        /// Удаляет первый и последний символ из строки
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static char[] ArrayDelete(ref char[] str)
        {
            char[] newStr = new char[str.Length - 2];

            for (int i = 0; i < newStr.Length; i++)
            {
                newStr[i] = str[i + 1];
            }
            return str = newStr;
        }
    }
}
