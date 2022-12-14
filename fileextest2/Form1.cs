using fileextest2.composite;
using fileextest2.FormCompontents;
using System;
using System.Windows.Forms;
using Component = fileextest2.composite.Component;

namespace fileextest2
{
    public partial class Form1 : Form
    {

        private Folder currentFolder;
        private Component currentlySelectedItem;
        private Folder root = new Folder("root");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillDB(root);
            loadFilesAndDirectories();
            listView1.ContextMenuStrip = new GeneralOperationsMenu(addFile);
        }

        public void fillDB(Folder root)
        {
            root.Add(new composite.Text("Text_1"));
            root.Add(new composite.Text("Text_2"));
            root.Add(new composite.Executable("Exe_3"));
            root.Add(new composite.Executable("Exe_4"));
            Folder comp = new Folder("Folder_1");
            root.Add(new composite.Text("Text_3"));
            root.Add(new composite.Executable("Exe_4"));
            root.Add(comp);
            comp.Add(new composite.Text("Text_5"));
            Folder comp2 = new Folder("Folder_2");
            comp.Add(comp2);
            comp2.Add(new composite.Text("Text_2"));
            //comp2.Add(root);
            comp2.Add(new composite.Executable("Exe_10"));
            comp2.Add(new composite.Text("Text_6"));
        }

        public void loadFilesAndDirectories()
        {
            if (currentFolder == null)
            {
                currentlySelectedItem = root;
                currentFolder = root;
            }

            for (int i = 0; i < currentFolder.Items().Count; i++)
            {
                var item = currentFolder.Items()[i];
                listView1.Items.Add(item.Name, item.IconCode);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException("don't touch me!");
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            _ = currentlySelectedItem ?? throw new ArgumentNullException(nameof(currentlySelectedItem));

            currentlySelectedItem = currentFolder.getChild(e.Item.Index);

            fileNameLabel.Text = currentlySelectedItem.Name;
            fileTypeLabel.Text = currentlySelectedItem.GetType().Name;

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            _ = currentFolder ?? throw new ArgumentNullException(nameof(currentFolder));
            if (currentlySelectedItem.IsFolder())
            {
                currentFolder = (Folder)currentlySelectedItem;
                listView1.Clear();
                loadFilesAndDirectories();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            currentFolder = (Folder)currentFolder.Parent;
            listView1.Clear();
            loadFilesAndDirectories();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            currentFolder.Remove(currentlySelectedItem);
            listView1.Clear();
            loadFilesAndDirectories();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            currentFolder.Add(new Folder(filePathTextBox.Text));
            listView1.Clear();
            loadFilesAndDirectories();
        }

        private void addFile(object sender, EventArgs e)
        {
            string name = filePathTextBox.Text;
            if(filePathTextBox.Text == "") name = "noname";
            string s = sender.ToString();
            if (s == "AddFolder")
            {
                currentFolder.Add(new Folder(name));

            }
            else if (s == "AddText")
            {
                currentFolder.Add(new Text(name));
            }
            else if (s == "AddExe")
            {
                currentFolder.Add(new Executable(name));
            }

            listView1.Clear();
            loadFilesAndDirectories();
        }
    }
}
