using System;
using System.Windows.Forms;

namespace dnd_helper
{
    public partial class MyBackpack : Form
    {
        public MyBackpack()
        {
            InitializeComponent();
            Resize += new EventHandler(this.MyBackpack_Resize);
        }

        private void MyBackpack_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MyBackpack)sender).Hide();
            e.Cancel = true;
        }
        private void MyBackpack_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                mainForm.notifyIcon.Visible = true;
        }
    }
}
