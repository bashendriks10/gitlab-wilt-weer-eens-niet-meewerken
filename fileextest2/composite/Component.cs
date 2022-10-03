namespace fileextest2.composite
{
    public abstract class Component
    {
        public string name;

        // Constructor
        public Component(string name)
        {
            this.name = name;
        }
        public abstract void Add(Component c);

        public abstract void Remove(Component c);
            
        public abstract bool isFolder();
    }
}
