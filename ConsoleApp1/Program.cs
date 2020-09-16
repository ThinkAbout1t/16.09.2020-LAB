using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Привіт ДоннУ");*/
            string name = "Tom";
                int age = 33;
                bool isEmployed = false;
                double weight = 78.65;

            /*Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Вес: {weight}");
            Console.WriteLine($"Работает: {isEmployed}");*/
            Console.WriteLine("Имя: {0}  Возраст: {1}  Рост: {2}", name, age, weight);
            Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {weight}");
            Console.ReadKey();
        }
    }
}
