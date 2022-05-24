using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_4_Ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для выхода наберите 0.");
            while (true)
            {
                Console.Write("Введите номер числа фиббоначи: ");
                ulong a = ulong.Parse(Console.ReadLine());
                if (a == 0)
                {
                    break;
                }
                if (a == 1)
                {
                    Console.WriteLine("Число фиббоначи = 0");
                }
                if(a<0)
                {
                    Console.WriteLine("Число должно быть больше 0!");
                }
                if(a>45)
                {
                    Console.WriteLine("Друг, ждать ты будешь до конца времен! Давай, число поменьше!");
                }
                else
                {
                    Console.WriteLine("Число Фиббоначи = " + Fibbo(a - 1));
                }
            }
        }
        static ulong Fibbo(ulong n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return Fibbo(n - 1) + Fibbo(n - 2);  //Честно признаюсь, в учебнике по шарпу давно видел этот пример с рекурсией. Чтобы понять как работает рекурсия, нужно рисовать схему работы, как мы делали на лекции, иначе мозг вскипит.
            }
        }
    }
}
