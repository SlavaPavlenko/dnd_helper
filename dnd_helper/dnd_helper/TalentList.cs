using System;
using System.Linq;
using System.Windows.Forms;

namespace dnd_helper
{
    public partial class TalentList : Form
    {
        public TalentList()
        {
            InitializeComponent();
        }
        private void TalentList_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < mainForm.allTalents.Count; i++)
                talents_listBox.Items.Add(mainForm.allTalents.ElementAt(i).TalentName);
        }
        public ListBox unlimited_listBox;
        public ListBox scenely_listBox;
        public ListBox daily_listBox;
        private void talents_listBox_DoubleClick(object sender, EventArgs e)
        {
            ListBox selectedItem = (ListBox)sender;
            Talent talent = mainForm.allTalents.Find(talentName => talentName.TalentName == selectedItem.Text);
            if (talent != null)
                switch (talent.UsageRate)
                {
                    case "Неограниченный":
                        unlimited_listBox.Items.Add(talent.TalentName);
                        break;
                    case "На сцену":
                        scenely_listBox.Items.Add(talent.TalentName);
                        break;
                    case "На день":
                        daily_listBox.Items.Add(talent.TalentName);
                        break;
                }
        }
    }
}
