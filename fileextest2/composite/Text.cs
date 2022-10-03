using System;

namespace fileextest2.composite
{
    public class Text : Component
    {
        public override int IconCode { get; protected set; }
        public Text(string name)
            : base(name)
        {
            IconCode = 1;
        }
        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }
        public override void Remove(Component c)
        {

            Console.WriteLine("Cannot remove from a leaf");
        }
        public override bool IsFolder()
        {
            return false;
        }

        public override void Execute()
        {
        
        }
    }
}
