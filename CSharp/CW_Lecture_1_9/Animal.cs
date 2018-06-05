namespace CW_Lecture_1_9
{
    public class Animal
    {
        public string Type { get; }
        public int Hunger { get; private set; }

        public void Eat()
        {
            if (Hunger > 0) Hunger--;
        }

        public void Starve()
        {
            Hunger++;
        }

        public Animal(string animalType)
        {
            Type = animalType;
        }

        public override string ToString()
        {
            return $"Animal: {Type} - Hunger: {Hunger}";
        }

        public override bool Equals(object obj)
        {
            //Animal animal = obj as Animal;
            //return animal != null && animal.Type == this.Type;

            //C# 7.0
            return obj is Animal animal 
                   && animal.Type == this.Type 
                   && animal.Hunger == this.Hunger;
        }
    }
}