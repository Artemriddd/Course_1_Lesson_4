using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_4_Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целые числа через пробел и нажмите \"Enter\": ");
            string numbers = Console.ReadLine();
            String[] splitNumber = numbers.Split(' ');
            int summ = 0;
            foreach (var number in splitNumber)
            {
                int a = Int32.Parse(number);
                summ += a;
            }
            Console.WriteLine("Сумма чисел в строке = " + summ);
            Console.ReadKey();
        }
    }
}
