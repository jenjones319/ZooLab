using System;

namespace ZooLab
{
    public abstract class OzAnimal
    {
        static void Main(string[] args)
        {
            OzAnimal[] OzAnimal = new OzAnimal[]
            {
                new Horses(),
                new Dogs(),
                new Monkeys(),
                new Lions(),
                new Tigers(),
                new Bears(),
            };

            foreach (OzAnimal animal in OzAnimal)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Wings: {animal.HasWings()}");
                Console.WriteLine($"Bites: {animal.Bites()}");
                Console.WriteLine($"TailLength: {animal.TailLength()}");
                Console.WriteLine($"LegCount: {animal.LegCount()}");

            }
        }
    }
}
