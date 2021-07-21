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
        //Form Trackers
        FileJoiner joinerForm = null;
        FileSplitter splitterForm = null;

        public Form1()
        {
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
            About aboutForm = new About();
            aboutForm.MinimumSize = aboutForm.Size;
            aboutForm.MaximumSize = aboutForm.Size;
            aboutForm.MaximizeBox = false;
            aboutForm.Show();
        }

        private void fileSplitter_Click(object sender, EventArgs e)
        {
            splitterForm = new FileSplitter();
            splitterForm.MinimumSize = splitterForm.Size;
            splitterForm.MaximumSize = splitterForm.Size;
            splitterForm.MaximizeBox = false;
            splitterForm.ShowDialog();
        }

        private void fileJoin_Click(object sender, EventArgs e)
        {
            joinerForm = new FileJoiner();
            joinerForm.MinimumSize = joinerForm.Size;
            joinerForm.MaximumSize = joinerForm.Size;
            joinerForm.MaximizeBox = false;
            joinerForm.ShowDialog();
        }
    }
}
