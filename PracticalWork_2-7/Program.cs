using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork_2_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string familyName = "Иванов";//фамилия
            string name = "Иван";        //имя
            string surname = "Иванович"; //отчество

            int age = 30;       //возраст

            string email = "ivanoffii@google.com";//Email

            float programing = 90f;   //программирование
            float maths = 78.5f;      //математика
            float physics = 82.4f;    //физика

            Console.WriteLine(
                $"{familyName, 20}\tfamilyName" +
                $"\n{name, 20}\tname" +
                $"\n{surname,20}\tsurname" +
                $"\n{age,20}\tage" +
                $"\n{email,20}\temail" +
                $"\n{programing,20}\tprograming" +
                $"\n{maths,20}\tmaths" +
                $"\n{physics,20}\tphysics"
                );

            Console.ReadKey();
        }
    }
}
