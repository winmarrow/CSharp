using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Lecture_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Exercice_1();
            //Exercice_2();

            Console.ReadKey();
        }


        static void Exercice_1()
        {
            #region Stack

            //Stack

            Stack stackObj = new Stack();

            stackObj.Push(DateTime.Now);
            stackObj.Push("Some text");
            stackObj.Push(5d);
            stackObj.Push(ConsoleColor.Blue);

            while (stackObj.Count !=0)
            {
                object obj = stackObj.Pop();
                if(obj is double)
                    Console.WriteLine($"Double: {(double)obj :0.##}");
                else if (obj is ConsoleColor)
                {
                    ConsoleColor color = (ConsoleColor) obj;
                    Console.ForegroundColor = color;
                    Console.WriteLine($"Console color: {color.ToString()}");
                }
                else if (obj is DateTime)
                    Console.WriteLine($"DateTime: {(DateTime)obj:d}");
                else 
                {
                    string str = obj as string;
                    if(!string.IsNullOrWhiteSpace(str))
                        Console.WriteLine($"String: {str}");
                }
            }

            Console.WriteLine(new string('*', 10));

            //generic
            Stack<string> stackStrings = new Stack<string>();

            stackStrings.Push("C#");
            stackStrings.Push("JS");
            stackStrings.Push("HTTP");

            //stackStrings.Push(15d); Error:<- string only

            string str1 = stackStrings.Peek(); // сохранит верхний элемент не удаляя
            Console.WriteLine($"Result 1:{str1}, stack count {stackStrings.Count}");
            string str2 = stackStrings.Pop(); //удалит верхний элемент из коллекции
            Console.WriteLine($"Result 1:{str2}, stack count {stackStrings.Count}");

            if (stackStrings.Contains("C#")) Console.WriteLine("yes");

            stackStrings.Clear();//очищает

            #endregion

            Console.WriteLine(new string('*', 10));

            #region Queue

            Queue queueObj = new Queue();

            Queue<string> queueStrings = new Queue<string>();

            int queueCount = queueStrings.Count;
            queueStrings.Clear();
            queueStrings.Contains("text");
            //queueStrings.Peek();

            queueStrings.Enqueue("C#");
            queueStrings.Enqueue("ASP.NET");
            queueStrings.Enqueue("JS");

            string element = queueStrings.Dequeue();

            #endregion

            Console.WriteLine(new string('*', 10));


            #region LIST

            List<string> listStrings1 = new List<string>();
            listStrings1.Add("C#");
            listStrings1.AddRange(queueStrings); //we add to list an object witch implements interface IEnumerable

            List<string> listStrings2 = new List<string>(){ "WebAPI","REST","SOAP","XML"};//init

            listStrings1.AddRange(listStrings2); //add to list another list

            Console.WriteLine($"List count: {listStrings1.Count}");
            Console.WriteLine($"List copacity: {listStrings1.Capacity}");

            int index = listStrings1.IndexOf("WebAPI");
            Console.WriteLine($"Index of WebAPI = {index}");

            listStrings1.RemoveAt(index);
            Console.WriteLine($"Element at index #{index} = {listStrings1[index]}");

            listStrings1.Sort();

            #endregion

            Console.WriteLine(new string('*', 10));

            #region  LincedList

            LinkedList<string> linkedList = new LinkedList<string>();


            linkedList.AddFirst("C#");
            linkedList.AddLast("JS");
            linkedList.AddLast("HTML");
            linkedList.AddLast("CSS");
            linkedList.AddLast("LESS");
            linkedList.AddLast("SASS");

            LinkedListNode<string> node1 = linkedList.Find("JS");
            var node2 = linkedList.Find("HTML");

            linkedList.AddAfter(node1, "STRING");

            int linkedListCount = linkedList.Count;



            LinkedListNode<string> first = linkedList.First;
            LinkedListNode<string> last = linkedList.Last;

            #endregion

            Console.WriteLine(new string('*', 10));

            #region Dictionsary

            Dictionary<string,decimal> priceList= new Dictionary<string, decimal>();

            KeyValuePair<string,decimal> pair = new KeyValuePair<string, decimal>("Cheese", 10.6M);
            

            priceList.Add("Wine", 26.6M);
            priceList.Add("Bread", 2.5M);
            priceList.Add("Breаd", 2.56M); //Keys collision, compiler throw exeption

            foreach (KeyValuePair<string, decimal> keyValuePair in priceList)
            {
                Console.WriteLine($"[{keyValuePair.Key.GetHashCode()}]: {keyValuePair.Key} - {keyValuePair.Value}");
            }

            if(!priceList.TryGetValue("Meat", out decimal meatPrice))
                Console.WriteLine("PAir isn't exist");

            priceList["Bread"] = 22.1m;
            decimal cheeesePrice = priceList["Cheese"];

            var keys = priceList.Keys;
            var values = priceList.Values;

            #endregion

        }
        static void Exercice_2()
        {
            #region Stack IN/OUT

            Stack<string> stakStrings = new Stack<string>();

            ConsoleKey choise;

            do
            {
                Console.Write($"Input stack element #{stakStrings.Count}: ");
                string str = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(str))
                    Console.WriteLine("Incorrect input.Ttry again");
                else
                    stakStrings.Push(str);

                Console.WriteLine("Are you want to input another [Y - to yes, any other key - to no]");
                choise = Console.ReadKey(true).Key;

            } while (choise == ConsoleKey.Y);

            Console.WriteLine("Stack Elements");

            foreach (string str in stakStrings)
                Console.WriteLine($"Element #{stakStrings.Count-1}: {str}");
            

            #endregion
        }
    }
}
