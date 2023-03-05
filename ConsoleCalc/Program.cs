using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;

            Console.Write("Введите А ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите В ");
            B = Convert.ToInt32(Console.ReadLine());

            C = A + B;
            Console.WriteLine($"Ответ сложения: {C} ");

            C = A - B;
            Console.WriteLine($"Ответ вычитания: {C} ");
        }
    }
}
