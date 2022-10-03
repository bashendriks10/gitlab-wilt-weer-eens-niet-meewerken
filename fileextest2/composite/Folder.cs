using System.Collections.Generic;

namespace fileextest2.composite
{
    public class Folder : Component
    {
        List<Component> children = new List<Component>();
        public override int IconCode { get; protected set; }

        public Folder(string name)
            : base(name)
        {
            IconCode = 0;
        }
        public override void Add(Component component)
        {
            component.Parent = this;
            children.Add(component);
        }
        public override void Remove(Component component)
        {
            children.Remove(component);
        }

        public override bool IsFolder()
        {
            return true;
        }

        public Component getChild(int i)
        {
            return children[i];
        }
        public List<Component> Items()
        {
            return children;
        }

        public override void Execute()
        {
        }
    }
}
