using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lecture_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            const string inputMsg = "Введитк натуральное число (n>0) : ";
            const string noPrimeMsg = "Нет простых чисел в выбранном диапазоне";
            const string invalidInputMsg = "Введены неверные значения...";
            const string outMsg = "{0,10}";

            Console.Write(inputMsg);
            string inputString = Console.ReadLine();

            if (!uint.TryParse(inputString, out uint n))
            {
                Console.WriteLine(invalidInputMsg);
                Console.ReadKey();
                return;
            }

            if (n==1)
                Console.WriteLine(noPrimeMsg);
            else if (n >= 2)
            {
                Console.Write(outMsg, 2);

                for (uint number = 2; number <= n; number++)
                {
                    for (uint oldNumber = 2; oldNumber <= Math.Ceiling(Math.Sqrt(number)); ++oldNumber)
                        if (number % oldNumber == 0) goto next;

                    Console.Write(outMsg, number);

                    next:;
                }
            }

            //exit
            Console.ReadKey();
        }
    }
}
