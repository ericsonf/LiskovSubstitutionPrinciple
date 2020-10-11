using System;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Dog("Akita", "Red", 14);
            Console.WriteLine(animal.GetInformation());

            animal = new Bird("Arara", "Blue");
            Console.WriteLine(animal.GetInformation());
        }
    }

    public abstract class Animal
    {
        protected string Name { get; }
        protected string Color { get; }

        protected Animal(string name, string color)
        {
            Name = name;
            Color = color;
        }
        public abstract string GetInformation();
    }

    public class Dog : Animal
    {
        private int LifeExpectancy { get; }

        public Dog(string name, string color, int lifeExpectancy) : base(name, color)
        {
            LifeExpectancy = lifeExpectancy;
        }

        public override string GetInformation() => $"Name: {Name} - Color: {Color} - Life Expectancy: {LifeExpectancy}";
    }

    public class Bird : Animal
    {
        public Bird(string name, string color) : base(name, color)
        {
        }

        public override string GetInformation() => $"Name: {Name} - Color: {Color}";
    }
}
