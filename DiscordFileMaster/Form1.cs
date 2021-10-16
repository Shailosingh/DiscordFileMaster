using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordFileMaster
{
    public partial class Form1 : Form
    {
        //Form Trackers (Used to ensure only one instance of each form can exist)
        FileJoiner joinerForm = null;
        FileSplitter splitterForm = null;
        About aboutForm = null;

        public Form1()
        {
            //Makes sure window is at fixed size
            InitializeComponent();
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void about_Click(object sender, EventArgs e)
        {
            //Makes sure window is at fixed size
            aboutForm = new About();
            aboutForm.MinimumSize = aboutForm.Size;
            aboutForm.MaximumSize = aboutForm.Size;
            aboutForm.MaximizeBox = false;

            //Show Dialog ensures it is always a Modal Window (Over the other forms and makes other forms inaccessible)
            aboutForm.ShowDialog();
        }

        private void fileSplitter_Click(object sender, EventArgs e)
        {
            //Makes sure window is at fixed size
            splitterForm = new FileSplitter();
            splitterForm.MinimumSize = splitterForm.Size;
            splitterForm.MaximumSize = splitterForm.Size;
            splitterForm.MaximizeBox = false;

            //Show Dialog ensures it is always a Modal Window (Over the other forms and makes other forms inaccessible)
            splitterForm.ShowDialog();
        }

        private void fileJoin_Click(object sender, EventArgs e)
        {
            //Makes sure window is at fixed size
            joinerForm = new FileJoiner();
            joinerForm.MinimumSize = joinerForm.Size;
            joinerForm.MaximumSize = joinerForm.Size;
            joinerForm.MaximizeBox = false;

            //Show Dialog ensures it is always a Modal Window (Over the other forms and makes other forms inaccessible)
            joinerForm.ShowDialog();
        }
    }
}
