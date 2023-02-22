using System;
using static System.Console;

namespace AbstractAnimalClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Reptile firstReptile = new Reptile();
            firstReptile.Name = "Chi";
            firstReptile.Species = "Bearded Dragon";
            firstReptile.NumberOfLegs = 4;
            Reptile secondReptile = new Reptile("Boris", "Tortoise", 4);
            WriteLine(firstReptile.whatAmI());
            WriteLine(firstReptile.Describe());
            WriteLine(secondReptile.whatAmI());
            WriteLine(secondReptile.Describe());
        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }

        public abstract string Describe();
        public string whatAmI() { return "I am an animal"; }
    }
    class Reptile : Animal
    {
        public override string Name { get; set; }
        public string Species { get; set; }
        public int NumberOfLegs { get; set; }
        public Reptile() 
        {
            Name= string.Empty;
            Species= string.Empty;
            NumberOfLegs= 0;
        }
        public Reptile(string name, string species, int numberOfLegs)
        {
            Name = name;
            Species= species;
            NumberOfLegs = numberOfLegs;
        }

        public override string Describe()
        {
            return $"My Name is {Name}. I am a {Species} with {NumberOfLegs} legs";

        }
    }
}
