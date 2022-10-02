using System.Collections.Generic;

namespace fileextest2.composite
{
    public class Folder : Component
    {
        List<Component> children = new List<Component>();

        public Folder(string name)
            : base(name)
        {
        }
        public override void Add(Component component)
        {
            children.Add(component);
        }
        public override void Remove(Component component)
        {
            children.Remove(component);
        }
        public override string getName()
        {
            return name;
        }

        public override bool isFolder()
        {
            return true;
        }

        public List<Component> Items()
        {

            return children;

        }
    }
}
