namespace fileextest2.composite
{
    public abstract class Component
    {
        public string Name { private set; get; }
        public abstract int IconCode { protected set; get; }
        public Component Parent { get; set; }

        // Constructor
        public Component(string name)
        {
            this.Name = name;
        }
        public abstract void Add(Component c);

        public abstract void Remove(Component c);

        public abstract void Execute();
            
        public abstract bool IsFolder();

        public bool HasParrent()
        {
            return this.Parent != null;
        }

    }
}
