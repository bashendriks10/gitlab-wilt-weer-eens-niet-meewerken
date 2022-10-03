using System;

namespace fileextest2.composite
{
    public class Text : Component
    {

        public Text(string name)
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
    }
}
