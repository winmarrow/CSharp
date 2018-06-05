using System;

namespace CW_Lecture_1_7
{
    public class Human
    {
        //Поля класса Human
        public string FullName; 
        public DateTime DoB;
        public double Weight;
        public double Height;

        private string _passportId = Guid.NewGuid().ToString();



        public string HumanInfo()
        {
            return $"Name: {FullName}\nPassport: {_passportId}\nWeight: {Weight}kg\nHeight: {Height}cm";
        }


        public void AddWeight(double weight)
        {
            Weight += weight;
        }
    }
}