namespace ZooLab
{
    class Bears
    {

        public abstract class OzAnimal
        {
            public string Name { get; set; }
            public virtual bool Bites { get { return true; } }
            public virtual bool HasWings { get { return false; } }

            public virtual int LegCount { get { return 4; } }
            public virtual string TailLength { get { return "small"; } }

            public virtual string Sleep()
            {
                return "Zzzzzzzz";
            }
        }
    }
}
