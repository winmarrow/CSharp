using System;
using System.Globalization;
using System.Text;

namespace HW_Lecture_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.OutputEncoding = Encoding.UTF8;

            string borderString = new string('=', Console.BufferWidth - 1);

            //output caption
            Console.WriteLine(borderString);
            Console.WriteLine("\t\t\t\t\t\t- Sphere Calculator -");
            Console.WriteLine(borderString);
            Console.WriteLine("\t\t\t\t\t\t-= Basic Formulas =-");
            Console.WriteLine("\t\t\t\t\tVolume=(4/3)\u03C0R\u00B3 m\u00B3 & Area = 4\u03C0R\u00B2 m\u00B2");

            //input radius of sphere
            Console.WriteLine(borderString);
            Console.Write(" Please enter the radius (R) of your sphere in meters (m) ");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            string separator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            Console.Write($"[you must separate of number parts with \"{separator}\" char!]");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(": ");


            //convertation & calculations
            Console.ForegroundColor = ConsoleColor.Blue;
            string sphereRadiusString = Console.ReadLine();
            double sphereRadius = Math.Abs(Convert.ToDouble(sphereRadiusString)); 

            double sphereV = 4.0 / 3.0 * Math.PI * Math.Pow(sphereRadius, 3.0); // Вопрос 1: Надо ли всегда указывать
            double sphereA = 4.0 * Math.PI * Math.Pow(sphereRadius, 2.0);

            //output results
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(borderString);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\tVolume=(4/3)\u03C0R\u00B3={0:0.###} m\u00B3{1}\tArea=(4/3)\u03C0R\u00B3={2:0.###} m\u00B2", sphereV, Environment.NewLine, sphereA);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(borderString);
            Console.WriteLine($" Thank you for using our program, we hope it helped you :D {Environment.NewLine} Goodbye!");

            //exit
            Console.ReadKey();
        }
    }
}
