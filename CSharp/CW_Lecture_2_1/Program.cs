using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Lecture_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human0 = new Human(){FullName = "Alex Fetcher", DoB = new DateTime(2000,10,5)};
            human0.Eat();


            Worker worker0 = new Worker() { FullName = "Alex Fetcher", Education = "BSUIR", DoB = new DateTime(2000, 10, 5) };
            worker0.Eat();
            worker0.DoSomeWork();



            HumanCollection humanCollection = new HumanCollection();
            humanCollection.Add(human0);

            var human1 =new Human("Petrr Jackson", DateTime.Now.AddYears(-45));
            humanCollection.Add(human1);

            humanCollection.Insert(0,new Human());





            Console.ReadKey();
        }
    }
}
