using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork_2_7
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

            float sum;          //сумма баллов
            float averageSum;   //средняя сумма баллов

            sum = programing + maths + physics;
            averageSum = sum / 3f;

            Console.WriteLine(
                $"{familyName,20}\tfamilyName" +
                $"\n{name,20}\tname" +
                $"\n{surname,20}\tsurname" +
                $"\n{age,20}\tage" +
                $"\n{email,20}\temail" +
                $"\n{programing,20}\tпрограммирование" +
                $"\n{maths,20}\tматематика" +
                $"\n{physics,20}\tфизика" +
                $"\n\n{sum,20:#.#}\tобщая сумма баллов" +
                $"\n{averageSum,20:#.#}\tсредний балл"
                );

            Console.ReadKey();
        }
    }
}
