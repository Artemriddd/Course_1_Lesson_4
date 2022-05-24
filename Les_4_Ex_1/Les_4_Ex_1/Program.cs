using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_4_Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            GetFullName("Артем", "Мордасов", "Александрович");
            GetFullName("Сергей", "Пупкин", "Федорович");
            GetFullName("Максим", "Сыров", "Камамберович");
            Console.ReadKey();
        }
        static void GetFullName(string firstName, string secondName, string patronymic)
        {
            Console.WriteLine($"ФИО: {secondName} {firstName} {patronymic}");
        }
    }
}
