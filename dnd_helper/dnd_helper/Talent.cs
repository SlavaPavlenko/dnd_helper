using System;
using System.Windows.Forms;

namespace dnd_helper
{
    public partial class Talent : Form
    {
        public string TalentName;
        public int Level;
        public string Description;
        public string UsageRate;
        public string KeyWords;
        public string ActionType;
        public string Required;
        public string Condition;
        public string Target;
        public string Feature;
        public string Attack;
        public string Hit;
        public string Miss;
        public string Effect;
        public string LvlUpgrades;

        public Talent()
        {
            InitializeComponent();
        }

        public Talent(string name, int level, string description, string usageRate, string keyWords, string actionType, string required, string condition,
            string target, string feature, string attack, string hit, string miss, string effect, string lvlUpgrades)
        {
            TalentName = name;
            Level = level;
            Description = description;
            UsageRate = usageRate;
            KeyWords = keyWords;
            ActionType = actionType;
            Required = required;
            Condition = condition;
            Target = target;
            Feature = feature;
            Attack = attack;
            Hit = hit;
            Miss = miss;
            Effect = effect;
            LvlUpgrades = lvlUpgrades;
        }

        public void TalentLoad()
        {
            string tmpName = TalentName;  //почему-то Name после InitializeComponent() меняется на "Talent"
            InitializeComponent();
            TalentName = tmpName;
            name.Text = TalentName;
            level.Text = Level.ToString();
            description.Text = Description;
            usageRate.Text = UsageRate;
            usageRate.Text += " | " + KeyWords;
            actionType.Text = ActionType;
            required.Text = Required;
            condition.Text = Condition;
            target.Text += Target;
            feature.Text = Feature;
            attack.Text += Attack;
            hit.Text += Hit;
            miss.Text += Miss;
            effect.Text += Effect;
            lvlUpgrades.Text += LvlUpgrades;

            Text += tmpName;
        }

        private void Talent_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((Talent)sender).Hide();
            e.Cancel = true;
        }
    }
}