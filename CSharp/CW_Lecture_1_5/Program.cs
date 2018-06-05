using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CW_Lecture_1_5
{
    class Program
    {

        static void Exercice_1(string[] args)
        {
            int[] intMass0 = new int[10];
            string[] stringsMass0 = new string[2];
            object[] objMass0 = new object[0];

            object[] objMass1 = null; //надо провирить на null перед исспользованием

            int? argsLenght = args?.Length ?? 0;


            for (int i = 0; i < argsLenght; i++)
            {
                Console.WriteLine(args[i]);
            }

            // проверка н null
            string str = null;
            string resultstring0 = str == null ? "0" : str;
            string resultSreing1 = str ?? "0";

            Console.WriteLine("Print int array:");
            for (int i = 0; i < intMass0.Length; i++)
            {
                Console.WriteLine($"{i}:\"{intMass0[i]}\"");
            }

            Console.WriteLine("Print string array:");
            for (int i = 0; i < stringsMass0.Length; i++)
            {
                Console.WriteLine($"{i}:\"{stringsMass0[i] ?? "null"}\"");
            }



            int[] intMass1 = new int[5];
            int[] intMass2 = intMass1;
            for (int i = 0; i < intMass1.Length; i++)
            {
                intMass1[i] = i;
                if (i % 2 == 0)
                {
                    intMass2[i] = -1;
                }
            }


        }
        static void Exercice_1_1()
        {
            const string inputMsg1 = "Введите длину массива: ";
            const string inputMsg2 = "Введитеэлемент массива №{0}: ";
            const string incorectInputMsg = "Веедено неверное значение";

            bool isValid;
            uint n;
            do
            {
                Console.Write(inputMsg1);
                string inputString = Console.ReadLine();
                isValid = uint.TryParse(inputString, out n);
                if (!isValid)
                    Console.WriteLine(incorectInputMsg);
            } while (!isValid);

            int[] intMass = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write(inputMsg2, i);
                do
                {
                    string inputString = Console.ReadLine();
                    isValid = int.TryParse(inputString, out int value);
                    if (!isValid)
                        Console.WriteLine(incorectInputMsg);
                    else
                        intMass[i] = value;
                } while (!isValid);


            }

            //output
            Console.Write("Ваш массив:");
            foreach (int value in intMass)
                Console.Write("{0,4}", value);

        }

        static void Exercice_2()
        {
            //Многомерный массив

            //трёхмерный массив
            int[,,] mass3d = new int[2, 3, 4];
            Console.WriteLine("Dimension 0 - {0}", mass3d.GetLength(0));
            Console.WriteLine("Dimension 1 - {0}", mass3d.GetLength(1));
            Console.WriteLine("Dimension 2 - {0}", mass3d.GetLength(2));
            Console.WriteLine("Mass 3D lenght:{0}", mass3d.Length);

            //
            int[,] mass2D = new int[3, 3]
            {
                {1, 2, 3}, {4, 5, 6}, {7, 8, 9}
            };


            //Ступечнатый массив
            int[][] myArray = new int[2][];
            myArray[0] = new int[3];
            myArray[1] = new int[4];

            //int[][,] myArray1 = new int[1][,];
            //myArray[0] = new int[3,4];




            int[][] mass4 = new int[5][];
            mass4[0] = new int[10];
            mass4[1] = new int[12];

            Console.WriteLine(mass4.GetType().Name); //Int32 [][]
            Console.WriteLine(mass4[0].GetType().Name);// Int32[]
            Console.WriteLine(mass4[0][5].GetType().Name);// Int32

            //for (int i = 0; i < mynumbers.Length; i++)
            //{
            //    if(mynumbers[i] == null) continue;
            //    for (int j = 0; j < mynumbers[i].Length; j++)
            //    {
            //        mynumbers[i][j] = i << j;
            //    }
            //}

            //for (int i = 0; i < mynumbers.Length; i++)
            //{
            //    if (mynumbers[i] == null) continue;
            //    for (int j = 0; j < mynumbers[i].Length; j++)
            //    {
            //        Console.WriteLine("{0,4}", mynumbers[i][j]);
            //    }
            //}


            Random rand = new Random();

            foreach (int[] mass in mass4)
            {
                for (int i = 0; i < (mass?.Length ?? 0); i++)
                {
                    mass[i] = rand.Next();
                }
            }


            foreach (int[] mass in mass4)
            {
                for (int i = 0; i < (mass?.Length ?? 0); i++)
                {
                    Console.WriteLine("{0,4}", mass[i]);
                }

            }

            //String Class
            char[] charString1 = new char[] { 'H', 'E', 'L', 'L', 'O', 'W' };
            string string1 = "HELLOW";

            char firstChar = charString1[0];
            char lastChar = charString1[charString1.Length - 1];

            //string1[0] = 'h'; Error

            string string2 = new string(charString1);
            string string3 = new string('=', 50);


            string[] textStrings = new[]
            {
                "Text", "Some text here", "More text", "No"
            };

            string resultString = null;
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < textStrings.Length; i++)
            {
                builder.AppendLine($"String {i} lenght: {textStrings[i].Length}");
                builder.AppendFormat("String {0} lenght: {1}", i, textStrings[i].Length);
            }

            
        }

        static void Exercice_2_1()
        {

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            //Exercice_1(args);
            //Exercice_1_1();
            Exercice_2();

            //exit
            Console.ReadKey();
        }


    }
}
