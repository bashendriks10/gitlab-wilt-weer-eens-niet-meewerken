using System;

namespace fileextest2.composite
{
    public class Executable : Component
    {
        // Constructor

        public Executable(string name)
            : base(name)
        {
        }
        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }
        public override void Remove(Component c)
        {

            Console.WriteLine("Cannot remove from a leaf");
        }
        public override bool isFolder()
        {
            return false;
        }
        public override string getName()
        {
            return name;
        }
    }
}
