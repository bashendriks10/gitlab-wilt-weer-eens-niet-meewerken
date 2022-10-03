using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fileextest2.FormCompontents
{
    public class GeneralOperationsMenu : ContextMenuStrip
    {
        public GeneralOperationsMenu(EventHandler e)
        {
            ToolStripMenuItem AddFolderButton = new ToolStripMenuItem("AddFolder");
            ToolStripMenuItem AddTextButton = new ToolStripMenuItem("AddText");
            ToolStripMenuItem AddExeButton = new ToolStripMenuItem("AddExe");
            AddFolderButton.Click += e;
            AddTextButton.Click += e;
            AddExeButton.Click += e;
            this.Items.Add(AddFolderButton);
            this.Items.Add(AddTextButton);
            this.Items.Add(AddExeButton);
        }
    }
}
