using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int a;
            Console.Write("1. Сколько океанов на нашей планете?   Ответ: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 5)
            {
                sum += 1;

            }
            else
            {
                sum += 0;
            }

            int b;
            Console.Write("2. Сатурн это какая по счету планета?   Ответ: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (b == 6)
            {
                sum += 1;

            }
            else
            {
                sum += 0;
            }
            int с;
            Console.Write("3. Сколько будет 0,2км в дециметрах?   Ответ: ");
            с = Convert.ToInt32(Console.ReadLine());
            if (с == 2000)
            {
                sum += 1;

            }
            else
            {
                sum += 0;
            }

            int d;
            Console.Write("4. Какое число обозначается римскими  цифрами LXXVII   Ответ: ");
            d = Convert.ToInt32(Console.ReadLine());
            if (d == 77)
            {
                sum += 1;

            }
            else
            {
                sum += 0;
            }
            int e;
            Console.Write("5. Сколько хромосом в геноме человека?   Ответ: ");
            e = Convert.ToInt32(Console.ReadLine());
            if (e == 46)
            {
                sum += 1;

            }
            else
            {
                sum += 0;
            }
            Console.WriteLine("6. Единица измерения силы тока?");
            Console.WriteLine("1 - Ампер");
            Console.WriteLine("2 - Вольт");
            Console.WriteLine("3 - Ватт");
            int f = Convert.ToInt32(Console.ReadLine());
            switch (f)
            {
                case 1:
                    Console.WriteLine("Правильно");
                    sum += 1;
                    break;
                case 2:
                    Console.WriteLine("Неправильно");
                    break;
                case 3:
                    Console.WriteLine("Неправильно");
                    break;
            }
            Console.WriteLine("Количество баллов: " + sum + "/6");

        }
    }
}