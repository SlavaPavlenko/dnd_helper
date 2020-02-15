using System;
using System.Windows.Forms;

namespace dnd_helper
{
    public partial class MyTalents : Form
    {
        public MyTalents()
        {
            InitializeComponent();
            Resize += new EventHandler(this.MyTalents_Resize);
        }
        private void MyTalents_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                mainForm.notifyIcon.Visible = true;
        }
        TalentList talentList = new TalentList();
        private void addTalent_btn_Click(object sender, EventArgs e)
        {
            if (!talentList.Created)
                talentList = new TalentList();
            talentList.unlimited_listBox = unlimited_listBox;
            talentList.scenely_listBox = scenely_listBox;
            talentList.daily_listBox = daily_listBox;
            talentList.Show();
            talentList.BringToFront();
        }

        private void FindTalent(object sender, EventArgs e)
        {
            ListBox hoveredItem = (ListBox)sender;
            Talent hoveredTalent = mainForm.allTalents.Find(talentName => talentName.TalentName == hoveredItem.Text);
            Talent talentForm;
            if (hoveredTalent != null)
            {
                talentForm = hoveredTalent;
                talentForm.Show();
                talentForm.TalentLoad();
                talentForm.BringToFront();
                talentForm.WindowState = FormWindowState.Normal;
            }
        }

        private void MyTalents_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
