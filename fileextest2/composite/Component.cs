namespace fileextest2.composite
{
    public abstract class Component
    {
        public string Name { private set; get; }
        public abstract int IconCode { protected set; get; }

        // Constructor
        public Component(string name)
        {
            this.Name = name;
        }
        public abstract void Add(Component c);

        public abstract void Remove(Component c);
            
        public abstract bool IsFolder();

    }
}
