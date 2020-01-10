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
            Console.WriteLine("Снова ");
            int i = 0;
            while(true)
            {
                i = i + 1;
                Console.Write(Math.Sin(i) * i * 2);
            }

            Console.ReadKey();
        }
    }
}
