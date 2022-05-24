using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_4_Ex_3
{
    class Program
    {
        enum Month
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            bool m = true; // Переменная для бесконечного цикла
            Console.WriteLine("Для выхода набери 0.");
            while (m == true) // Бесконечный цикл
            {
                Month wd;
                Console.Write("Введите номер месяца: ");
                bool t = Int32.TryParse(Console.ReadLine(), out int b);
                if (t == false)
                {
                    Console.WriteLine("Ошибка: Введите число от 1 до 12"); // Если ввели белиберду
                }   
                else
                {
                    if (b < 0 || b > 12)
                    {
                        Console.WriteLine("Ошибка: Введите число от 1 до 12"); // Если ввели число но вне заданного диапазона
                    }
                    else if (b == 0)
                    {
                        m = false; // Выход из бесконечного цикла = Выход из программы
                    }
                    else if (b < 3 || b == 12) // Ниже диапазоны для вывода времени года
                    {
                        wd = Month.Winter;
                        Weather(wd);
                    }
                    else if (b < 6)
                    {
                        wd = Month.Spring;
                        Weather(wd);
                    }
                    else if (b < 9)
                    {
                        wd = Month.Summer;
                        Weather(wd);
                    }
                    else
                    {
                        wd = Month.Autumn;
                        Weather(wd);
                    }
                }
            }
        }
        static void Weather(Month wd) // Метод с входными данными Enum (Как просили в задаче)
        {
            if (wd == Month.Autumn)
            {
                Console.WriteLine("Осень");
            }
            else if (wd == Month.Spring)
            {
                Console.WriteLine("Весна");
            }
            else if (wd == Month.Summer)
            {
                Console.WriteLine("Лето");
            }
            else
            {
                Console.WriteLine("Зима");
            }
        }
    }
}
