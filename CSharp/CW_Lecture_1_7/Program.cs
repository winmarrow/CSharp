using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Lecture_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            //Exercice_1();
            Exercice_2();


            //for (int i = 0; i < 10; i++)
            //{
            //    var foo = new Foo();
            //    Console.WriteLine($"[{i+1}] Guid: {foo.ID}");
            //}

            Console.ReadKey();

        }

        public static void Exercice_1()
        {
            Human human1 = new Human();

            human1.DoB = new DateTime(1994, 09, 01);
            human1.FullName = "Alexiander Galgousky";
            human1.Height = 181.5;
            human1.Weight = 51.8;

            Human human2 = new Human()
            {
                DoB = new DateTime(1994, 09, 01),
                FullName = "Bob Ross",
                Height = 181.5,
            };

            var info1 = human1.HumanInfo();
            var info2 = human2.HumanInfo();

            Console.WriteLine($"Human 1 info:{info1}");
            Console.WriteLine($"Human 2 info:{info2}");

            Console.WriteLine(Environment.NewLine);

            human2.AddWeight(26.3);
            Console.WriteLine($"Human 2 info:{human2.HumanInfo()}");
        }

        public static void Exercice_2()
        {

            var array = new int[10];
            var parser = new Parser();

            Console.WriteLine($"Array lenght is {array.Length}");

            parser.ResizeArray(ref array, 100);

            Console.WriteLine($"Array lenght is {array.Length}");
        }

        public static void OverloadTest()
        {
            var p =  new Parser();
            p.Test(" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ");
        }
    }




}
