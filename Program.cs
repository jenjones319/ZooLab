using System;
namespace ZooLab
{
    abstract class OzAnimals
    {
        public OzAnimals(string name)
        {
            Name = name;
        }
        public string Wings { get; set; }

        public override bool HasWings => true;

        public string Name { get; }

        public override void Setup()
        {
            Console.WriteLine("{name} has wings. That's why they're called flying monkeys!");
        }
    }

}
