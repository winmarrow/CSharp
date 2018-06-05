using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Lecture_1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.DarkGreen;


            Car car0 = new Car("Reno", 1.9);
            car0.ManufactureDate = new DateTime(2015,1,1);
            car0.Model = "Kaleos";

            Car car1 = new Car(engineVolume: 5.4, breand:"BMW");

            Car car2 = new Car("BMW" ,"X7",5.0,new DateTime(2105,9,03));

            //------------------
            Student student1 = new Student();
            student1.SetFullName("Alex Ross");
            Console.WriteLine($"Student 1 {student1.GetFullName()} - {student1.Age}");


            

            Console.ReadKey();
        }
    }
}
