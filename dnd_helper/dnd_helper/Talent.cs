using System;
using System.Windows.Forms;

namespace dnd_helper
{
    public partial class Talent : Form
    {
        public string TalentClass;
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

        public Talent(string talentClass, string name, int level, string description, string usageRate, string keyWords, string actionType, string required, string condition,
            string target, string feature, string attack, string hit, string miss, string effect, string lvlUpgrades)
        {
            TalentClass = talentClass;
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

        public Talent(string[] values)
        {
            TalentClass = values[0];
            TalentName = values[1];
            Level = Convert.ToInt32(values[2]);
            Description = values[3];
            UsageRate = values[4];
            KeyWords = values[5];
            ActionType = values[6];
            Required = values[7];
            Condition = values[8];
            Target = values[9];
            Feature = values[10];
            Attack = values[11];
            Hit = values[12];
            Miss = values[13];
            Effect = values[14];
            LvlUpgrades = values[15];
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