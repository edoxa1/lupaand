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
            int a, b;
            Console.Write("Введите первую цифру: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите вторую цифру: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сумма: {a+b} \nРазность: {a-b}\nУмножение: {a*b}\nДеление: {a/b}");
            Console.ReadKey();
        }
    }
}
