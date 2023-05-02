using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace test
// написать код, где мы указываем данные о человеке в класс, а затем передаем в другой и через него же выводим
// если значений нет, то значения дефолтные
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lenar lenar = new Lenar(); // здесь мы создаем объекты класса Ленар, где хранятся значения Ленара

            User danielUser = new User(Guid.NewGuid(), "Даниель", "Афанасьев", 10, null, null);
            User lenarUser = new User(lenar); // здесь мы создаем объект класса User, куда передаем значения объекта ленар т.е. его данные
            User timerlanUser = new User();
            User vladikUser = new User(lenar) // тут те же данные Ленара, только некоторые мы изменили
            {
                Id = Guid.NewGuid(),
                Nickname = "Владлен",
                Age = 17,
                Account = "None",
                Phone = "+7 (937) 788-80-90"
            };

            var adelina = InfoUserAdelina(); // тут создаем переменную аделина и помещаем значения с вызываемого метода

            danielUser.Print();
            lenarUser.Print();
            timerlanUser.Print();
            vladikUser.Print();

            adelina.PrintName(); // тк п-я аделина хранит значения объекта, в том числе ее экземпляр, мы можем обращаться к методу класса
        }

        static User InfoUserAdelina() // создаем объект класса User и присваевам нужные значения
        {
            User adelina = new User("Аделина", "Касимова");
            return adelina;
        }
    }

    class Lenar // хранит значение пользователя Ленар
    {
        public Guid Id = Guid.NewGuid();
        public string Nickname = "Ленар";
        public string Firstname = "Касимов";
        public int Age = 12;
        public string Account = "kasimovlenar2010@gamil.com";
        public string Phone = "+7 (937) 841-47-28";
    }
}
