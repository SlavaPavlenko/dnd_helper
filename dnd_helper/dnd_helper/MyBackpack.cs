using System.Windows.Forms;

namespace dnd_helper
{
    public partial class MyBackpack : Form
    {
        public MyBackpack()
        {
            InitializeComponent();
        }

        private void MyBackpack_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((Talent)sender).Hide();
            e.Cancel = true;
        }
    }
}
