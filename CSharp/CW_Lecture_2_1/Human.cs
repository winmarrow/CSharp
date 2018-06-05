using System;

namespace CW_Lecture_2_1
{
    public class Human
    {
        private readonly Guid _dnaSequance = Guid.NewGuid();

        public string FullName { get; set; }
        public DateTime DoB { get; set; }

        public Human()
        {

        }

        public Human(string fullName, DateTime doB)
        {
            FullName = fullName;
            DoB = doB;
        }

        public void Eat()
        {
            Console.WriteLine($"[{this.GetType().Name}|{_dnaSequance}] {FullName} is eating");
        }
    }

    public class Worker : Human
    {
        public string Education { get; set; }

        public void DoSomeWork()
        {
            Console.WriteLine($"[{this.GetType().Name}] {FullName} is working");
        }
    }
}