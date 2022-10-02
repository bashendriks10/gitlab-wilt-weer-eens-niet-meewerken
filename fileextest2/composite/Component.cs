namespace fileextest2.composite
{
    public abstract class Component
    {
        protected string name;

        // Constructor
        public Component(string name)
        {
            this.name = name;
        }
        public abstract void Add(Component c);

        public abstract void Remove(Component c);

        public abstract string getName();

        public abstract bool isFolder();
    }
}
