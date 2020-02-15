using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace dnd_helper
{
    public partial class mainForm : Form
    {
        public static NotifyIcon notifyIcon = new NotifyIcon();
        public mainForm()
        {
            InitializeComponent();
            //иконка в трее
            notifyIcon.Icon = new Icon(Directory.GetCurrentDirectory() + "\\NotifyIco.ico");
            notifyIcon.Visible = false;
            notifyIcon.MouseDoubleClick += new MouseEventHandler(notifyIcon_MouseDoubleClick);
            Resize += new EventHandler(this.mainForm_Resize);
        }
        //сворачивание в трей
        private void mainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }
        //разворачивание из трея
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            notifyIcon.Visible = false;
            WindowState = FormWindowState.Normal;
            if (backpackForm.Created)
            {
                backpackForm.WindowState = FormWindowState.Normal;
                backpackForm.Show();
            }
            if (talentsForm.Created)
            {
                talentsForm.WindowState = FormWindowState.Normal;
                talentsForm.Show();
            }
        }
        private void strange_change()
        {
            try
            {
                //вычисление mod
                if (strange_textBox.Text != "")
                    mod_strange_textBox.Text = (Convert.ToInt32(strange_textBox.Text) / 2 - 5).ToString();
                //вычисление mod + lvl/2
                int mod;
                if (mod_strange_textBox.Text == "")
                    mod = 0;
                else mod = Convert.ToInt32(mod_strange_textBox.Text);
                int lvl_half;
                if (lvl_textBox.Text == "")
                    lvl_half = 0;
                else
                    lvl_half = Convert.ToInt32(lvl_textBox.Text) / 2;
                mod_lvl_strange_textBox.Text = (mod + lvl_half).ToString();
            }
            catch (Exception) { }
        }
        private void agility_change()
        {
            try
            {
                //вычисление mod
                if (agility_textBox.Text != "")
                    mod_agility_textBox.Text = (Convert.ToInt32(agility_textBox.Text) / 2 - 5).ToString();
                //вычисление mod + lvl/2
                int mod;
                if (mod_agility_textBox.Text == "")
                    mod = 0;
                else mod = Convert.ToInt32(mod_agility_textBox.Text);
                int lvl_half;
                if (lvl_textBox.Text == "")
                    lvl_half = 0;
                else
                    lvl_half = Convert.ToInt32(lvl_textBox.Text) / 2;
                mod_lvl_agility_textBox.Text = (mod + lvl_half).ToString();
            }
            catch (Exception) { }
        }
        private void stamina_change()
        {
            try
            {
                //вычисление mod
                if (stamina_textBox.Text != "")
                    mod_stamina_textBox.Text = (Convert.ToInt32(stamina_textBox.Text) / 2 - 5).ToString();
                //вычисление mod + lvl/2
                int mod;
                if (mod_stamina_textBox.Text == "")
                    mod = 0;
                else mod = Convert.ToInt32(mod_stamina_textBox.Text);
                int lvl_half;
                if (lvl_textBox.Text == "")
                    lvl_half = 0;
                else
                    lvl_half = Convert.ToInt32(lvl_textBox.Text) / 2;
                mod_lvl_stamina_textBox.Text = (mod + lvl_half).ToString();
            }
            catch (Exception) { }
        }
        private void intelligence_change()
        {
            try
            {
                //вычисление mod
                if (intelligence_textBox.Text != "")
                    mod_intelligence_textBox.Text = (Convert.ToInt32(intelligence_textBox.Text) / 2 - 5).ToString();
                //вычисление mod + lvl/2
                int mod;
                if (mod_intelligence_textBox.Text == "")
                    mod = 0;
                else mod = Convert.ToInt32(mod_intelligence_textBox.Text);
                int lvl_half;
                if (lvl_textBox.Text == "")
                    lvl_half = 0;
                else
                    lvl_half = Convert.ToInt32(lvl_textBox.Text) / 2;
                mod_lvl_intelligence_textBox.Text = (mod + lvl_half).ToString();
            }
            catch (Exception) { }
        }
        private void wizdom_change()
        {
            try
            {
                //вычисление mod
                if (wisdom_textBox.Text != "")
                    mod_wisdom_textBox.Text = (Convert.ToInt32(wisdom_textBox.Text) / 2 - 5).ToString();
                //вычисление mod + lvl/2
                int mod;
                if (mod_wisdom_textBox.Text == "")
                    mod = 0;
                else mod = Convert.ToInt32(mod_wisdom_textBox.Text);
                int lvl_half;
                if (lvl_textBox.Text == "")
                    lvl_half = 0;
                else
                    lvl_half = Convert.ToInt32(lvl_textBox.Text) / 2;
                mod_lvl_wisdom_textBox.Text = (mod + lvl_half).ToString();
            }
            catch (Exception) { }
        }
        private void charisma_change()
        {
            try
            {
                //вычисление mod
                if (charisma_textBox.Text != "")
                    mod_charisma_textBox.Text = (Convert.ToInt32(charisma_textBox.Text) / 2 - 5).ToString();
                //вычисление mod + lvl/2
                int mod;
                if (mod_charisma_textBox.Text == "")
                    mod = 0;
                else mod = Convert.ToInt32(mod_charisma_textBox.Text);
                int lvl_half;
                if (lvl_textBox.Text == "")
                    lvl_half = 0;
                else
                    lvl_half = Convert.ToInt32(lvl_textBox.Text) / 2;
                mod_lvl_charisma_textBox.Text = (mod + lvl_half).ToString();
            }
            catch (Exception) { }
        }
        private void acrobatics_change()
        {
            try
            {
                //вычисление бонуса
                int bonus;
                if (acrobatics_textBox.Text != "")
                    bonus = Convert.ToInt32(acrobatics_textBox.Text);
                else bonus = 0;
                //вычисление тренированности
                int trained;
                if (acrobatics_checkBox.Checked)
                    trained = 5;
                else trained = 0;
                //вычисление штрафа за доспех
                int armorFine;
                if (acrobatics_armorFine_textBox.Text != "")
                    armorFine = Convert.ToInt32(acrobatics_armorFine_textBox.Text);
                else armorFine = 0;
                //вычисление иного
                int other;
                if (acrobatics_other_textBox.Text != "")
                    other = Convert.ToInt32(acrobatics_other_textBox.Text);
                else other = 0;
                //вычисление модификатора
                int mod;
                if (acrobatics_mod_textBox.Text != "")
                    mod = Convert.ToInt32(acrobatics_mod_textBox.Text);
                else mod = 0;
                //вычисление результата
                acrobatics_result_textBox.Text = (bonus + mod + trained + armorFine + other).ToString();
            }
            catch (Exception) { }
        }
        private void athletics_change()
        {
            try
            {
                //вычисление бонуса
                int bonus;
                if (athletics_textBox.Text != "")
                    bonus = Convert.ToInt32(athletics_textBox.Text);
                else bonus = 0;
                //вычисление тренированности
                int trained;
                if (athletics_checkBox.Checked)
                    trained = 5;
                else trained = 0;
                //вычисление штрафа за доспех
                int armorFine;
                if (athletics_armorFine_textBox.Text != "")
                    armorFine = Convert.ToInt32(athletics_armorFine_textBox.Text);
                else armorFine = 0;
                //вычисление иного
                int other;
                if (athletics_other_textBox.Text != "")
                    other = Convert.ToInt32(athletics_other_textBox.Text);
                else other = 0;
                //вычисление модификатора
                int mod;
                if (athletics_mod_textBox.Text != "")
                    mod = Convert.ToInt32(athletics_mod_textBox.Text);
                else mod = 0;
                //вычисление результата
                athletics_result_textBox.Text = (bonus + mod + trained + armorFine + other).ToString();
            }
            catch (Exception) { }
        }
        private void attentiveness_change()
        {
            try
            {
                //вычисление бонуса
                int bonus;
                if (attentiveness_textBox.Text != "")
                    bonus = Convert.ToInt32(attentiveness_textBox.Text);
                else bonus = 0;
                //вычисление тренированности
                int trained;
                if (attentiveness_checkBox.Checked)
                    trained = 5;
                else trained = 0;
                //вычисление иного
                int other;
                if (attentiveness_other_textBox.Text != "")
                    other = Convert.ToInt32(attentiveness_other_textBox.Text);
                else other = 0;
                //вычисление модификатора
                int mod;
                if (attentiveness_mod_textBox.Text != "")
                    mod = Convert.ToInt32(attentiveness_mod_textBox.Text);
                else mod = 0;
                //вычисление результата
                attentiveness_result_textBox.Text = (bonus + mod + trained + other).ToString();
            }
            catch (Exception) { }
        }
        private void steal_change()
        {
            try
            {
                //вычисление бонуса
                int bonus;
                if (steal_textBox.Text != "")
                    bonus = Convert.ToInt32(steal_textBox.Text);
                else bonus = 0;
                //вычисление тренированности
                int trained;
                if (steal_checkBox.Checked)
                    trained = 5;
                else trained = 0;
                //вычисление штрафа за доспех
                int armorFine;
                if (steal_armorFine_textBox.Text != "")
                    armorFine = Convert.ToInt32(steal_armorFine_textBox.Text);
                else armorFine = 0;
                //вычисление иного
                int other;
                if (steal_other_textBox.Text != "")
                    other = Convert.ToInt32(steal_other_textBox.Text);
                else other = 0;
                //вычисление модификатора
                int mod;
                if (steal_mod_textBox.Text != "")
                    mod = Convert.ToInt32(steal_mod_textBox.Text);
                else mod = 0;
                //вычисление результата
                steal_result_textBox.Text = (bonus + mod + trained + armorFine + other).ToString();
            }
            catch (Exception) { }
        }
        private void endurance_change()
        {
            try
            {
                //вычисление бонуса
                int bonus;
                if (endurance_textBox.Text != "")
                    bonus = Convert.ToInt32(endurance_textBox.Text);
                else bonus = 0;
                //вычисление тренированности
                int trained;
                if (endurance_checkBox.Checked)
                    trained = 5;
                else trained = 0;
                //вычисление штрафа за доспех
                int armorFine;
                if (endurance_armorFine_textBox.Text != "")
                    armorFine = Convert.ToInt32(endurance_armorFine_textBox.Text);
                else armorFine = 0;
                //вычисление иного
                int other;
                if (endurance_other_textBox.Text != "")
                    other = Convert.ToInt32(steal_other_textBox.Text);
                else other = 0;
                //вычисление модификатора
                int mod;
                if (endurance_mod_textBox.Text != "")
                    mod = Convert.ToInt32(endurance_mod_textBox.Text);
                else mod = 0;
                //вычисление результата
                endurance_result_textBox.Text = (bonus + mod + trained + armorFine + other).ToString();
            }
            catch (Exception) { }
        }
        private void terrifying_change()
        {
            try
            {
                //вычисление бонуса
                int bonus;
                if (terrifying_textBox.Text != "")
                    bonus = Convert.ToInt32(terrifying_textBox.Text);
                else bonus = 0;
                //вычисление тренированности
                int trained;
                if (terrifying_checkBox.Checked)
                    trained = 5;
                else trained = 0;
                //вычисление иного
                int other;
                if (terrifying_other_textBox.Text != "")
                    other = Convert.ToInt32(steal_other_textBox.Text);
                else other = 0;
                //вычисление модификатора
                int mod;
                if (terrifying_mod_textBox.Text != "")
                    mod = Convert.ToInt32(terrifying_mod_textBox.Text);
                else mod = 0;
                //вычисление результата
                terrifying_result_textBox.Text = (bonus + mod + trained + other).ToString();
            }
            catch (Exception) { }
        }
        private void streetKnowlage_change()
        {
            try
            {
                //вычисление бонуса
                int bonus;
                if (streetKnowlage_textBox.Text != "")
                    bonus = Convert.ToInt32(streetKnowlage_textBox.Text);
                else bonus = 0;
                //вычисление тренированности
                int trained;
                if (streetKnowlage_checkBox.Checked)
                    trained = 5;
                else trained = 0;
                //вычисление иного
                int other;
                if (streetKnowlage_other_textBox.Text != "")
                    other = Convert.ToInt32(steal_other_textBox.Text);
                else other = 0;
                //вычисление модификатора
                int mod;
                if (streetKnowlage_mod_textBox.Text != "")
                    mod = Convert.ToInt32(streetKnowlage_mod_textBox.Text);
                else mod = 0;
                //вычисление результата
                streetKnowlage_result_textBox.Text = (bonus + mod + trained + other).ToString();
            }
            catch (Exception) { }
        }
        private void history_change()
        {
            try
            {
                //вычисление бонуса
                int bonus;
                if (history_textBox.Text != "")
                    bonus = Convert.ToInt32(history_textBox.Text);
                else bonus = 0;
                //вычисление тренированности
                int trained;
                if (history_checkBox.Checked)
                    trained = 5;
                else trained = 0;
                //вычисление иного
                int other;
                if (history_other_textBox.Text != "")
                    other = Convert.ToInt32(steal_other_textBox.Text);
                else other = 0;
                //вычисление модификатора
                int mod;
                if (history_mod_textBox.Text != "")
                    mod = Convert.ToInt32(history_mod_textBox.Text);
                else mod = 0;
                //вычисление результата
                history_result_textBox.Text = (bonus + mod + trained + other).ToString();
            }
            catch (Exception) { }
        }
        private void magic_change()
        {
            try
            {
                //вычисление бонуса
                int bonus;
                if (magic_textBox.Text != "")
                    bonus = Convert.ToInt32(magic_textBox.Text);
                else bonus = 0;
                //вычисление тренированности
                int trained;
                if (magic_checkBox.Checked)
                    trained = 5;
                else trained = 0;
                //вычисление иного
                int other;
                if (magic_other_textBox.Text != "")
                    other = Convert.ToInt32(steal_other_textBox.Text);
                else other = 0;
                //вычисление модификатора
                int mod;
                if (magic_mod_textBox.Text != "")
                    mod = Convert.ToInt32(magic_mod_textBox.Text);
                else mod = 0;
                //вычисление результата
                magic_result_textBox.Text = (bonus + mod + trained + other).ToString();
            }
            catch (Exception) { }
        }
        private void cheating_change()
        {
            try
            {
                //вычисление бонуса
                int bonus;
                if (cheating_textBox.Text != "")
                    bonus = Convert.ToInt32(cheating_textBox.Text);
                else bonus = 0;
                //вычисление тренированности
                int trained;
                if (cheating_checkBox.Checked)
                    trained = 5;
                else trained = 0;
                //вычисление иного
                int other;
                if (cheating_other_textBox.Text != "")
                    other = Convert.ToInt32(steal_other_textBox.Text);
                else other = 0;
                //вычисление модификатора
                int mod;
                if (cheating_mod_textBox.Text != "")
                    mod = Convert.ToInt32(cheating_mod_textBox.Text);
                else mod = 0;
                //вычисление результата
                cheating_result_textBox.Text = (bonus + mod + trained + other).ToString();
            }
            catch (Exception) { }
        }
        private void discussion_change()
        {
            try
            {
                //вычисление бонуса
                int bonus;
                if (discussion_textBox.Text != "")
                    bonus = Convert.ToInt32(discussion_textBox.Text);
                else bonus = 0;
                //вычисление тренированности
                int trained;
                if (discussion_checkBox.Checked)
                    trained = 5;
                else trained = 0;
                //вычисление иного
                int other;
                if (discussion_other_textBox.Text != "")
                    other = Convert.ToInt32(steal_other_textBox.Text);
                else other = 0;
                //вычисление модификатора
                int mod;
                if (discussion_mod_textBox.Text != "")
                    mod = Convert.ToInt32(discussion_mod_textBox.Text);
                else mod = 0;
                //вычисление результата
                discussion_result_textBox.Text = (bonus + mod + trained + other).ToString();
            }
            catch (Exception) { }
        }
        private void dungeons_change()
        {
            try
            {
                //вычисление бонуса
                int bonus;
                if (dungeons_textBox.Text != "")
                    bonus = Convert.ToInt32(dungeons_textBox.Text);
                else bonus = 0;
                //вычисление тренированности
                int trained;
                if (dungeons_checkBox.Checked)
                    trained = 5;
                else trained = 0;
                //вычисление иного
                int other;
                if (dungeons_other_textBox.Text != "")
                    other = Convert.ToInt32(steal_other_textBox.Text);
                else other = 0;
                //вычисление модификатора
                int mod;
                if (dungeons_mod_textBox.Text != "")
                    mod = Convert.ToInt32(dungeons_mod_textBox.Text);
                else mod = 0;
                //вычисление результата
                dungeons_result_textBox.Text = (bonus + mod + trained + other).ToString();
            }
            catch (Exception) { }
        }
        private void nature_change()
        {
            try
            {
                //вычисление бонуса
                int bonus;
                if (nature_textBox.Text != "")
                    bonus = Convert.ToInt32(nature_textBox.Text);
                else bonus = 0;
                //вычисление тренированности
                int trained;
                if (nature_checkBox.Checked)
                    trained = 5;
                else trained = 0;
                //вычисление иного
                int other;
                if (nature_other_textBox.Text != "")
                    other = Convert.ToInt32(steal_other_textBox.Text);
                else other = 0;
                //вычисление модификатора
                int mod;
                if (nature_mod_textBox.Text != "")
                    mod = Convert.ToInt32(nature_mod_textBox.Text);
                else mod = 0;
                //вычисление результата
                nature_result_textBox.Text = (bonus + mod + trained + other).ToString();
            }
            catch (Exception) { }
        }
        private void insight_change()
        {
            try
            {
                //вычисление бонуса
                int bonus;
                if (insight_textBox.Text != "")
                    bonus = Convert.ToInt32(insight_textBox.Text);
                else bonus = 0;
                //вычисление тренированности
                int trained;
                if (insight_checkBox.Checked)
                    trained = 5;
                else trained = 0;
                //вычисление иного
                int other;
                if (insight_other_textBox.Text != "")
                    other = Convert.ToInt32(steal_other_textBox.Text);
                else other = 0;
                //вычисление модификатора
                int mod;
                if (insight_mod_textBox.Text != "")
                    mod = Convert.ToInt32(insight_mod_textBox.Text);
                else mod = 0;
                //вычисление результата
                insight_result_textBox.Text = (bonus + mod + trained + other).ToString();
            }
            catch (Exception) { }
        }
        private void religion_change()
        {
            try
            {
                //вычисление бонуса
                int bonus;
                if (religion_textBox.Text != "")
                    bonus = Convert.ToInt32(religion_textBox.Text);
                else bonus = 0;
                //вычисление тренированности
                int trained;
                if (religion_checkBox.Checked)
                    trained = 5;
                else trained = 0;
                //вычисление иного
                int other;
                if (religion_other_textBox.Text != "")
                    other = Convert.ToInt32(steal_other_textBox.Text);
                else other = 0;
                //вычисление модификатора
                int mod;
                if (religion_mod_textBox.Text != "")
                    mod = Convert.ToInt32(religion_mod_textBox.Text);
                else mod = 0;
                //вычисление результата
                religion_result_textBox.Text = (bonus + mod + trained + other).ToString();
            }
            catch (Exception) { }
        }
        private void stealth_change()
        {
            try
            {
                //вычисление бонуса
                int bonus;
                if (stealth_textBox.Text != "")
                    bonus = Convert.ToInt32(stealth_textBox.Text);
                else bonus = 0;
                //вычисление тренированности
                int trained;
                if (stealth_checkBox.Checked)
                    trained = 5;
                else trained = 0;
                //вычисление штрафа за доспех
                int armorFine;
                if (stealth_armorFine_textBox.Text != "")
                    armorFine = Convert.ToInt32(stealth_armorFine_textBox.Text);
                else armorFine = 0;
                //вычисление иного
                int other;
                if (stealth_other_textBox.Text != "")
                    other = Convert.ToInt32(steal_other_textBox.Text);
                else other = 0;
                //вычисление модификатора
                int mod;
                if (stealth_mod_textBox.Text != "")
                    mod = Convert.ToInt32(stealth_mod_textBox.Text);
                else mod = 0;
                //вычисление результата
                stealth_result_textBox.Text = (bonus + mod + trained + armorFine + other).ToString();
            }
            catch (Exception) { }
        }
        private void curing_change()
        {
            try
            {
                //вычисление бонуса
                int bonus;
                if (curing_textBox.Text != "")
                    bonus = Convert.ToInt32(curing_textBox.Text);
                else bonus = 0;
                //вычисление тренированности
                int trained;
                if (curing_checkBox.Checked)
                    trained = 5;
                else trained = 0;
                //вычисление иного
                int other;
                if (curing_other_textBox.Text != "")
                    other = Convert.ToInt32(steal_other_textBox.Text);
                else other = 0;
                //вычисление модификатора
                int mod;
                if (curing_mod_textBox.Text != "")
                    mod = Convert.ToInt32(curing_mod_textBox.Text);
                else mod = 0;
                //вычисление результата
                curing_result_textBox.Text = (bonus + mod + trained + other).ToString();
            }
            catch (Exception) { }
        }
        private void wounded_change()
        {
            try
            {
                if (maxHits_textBox.Text != "")
                    wounded_textBox.Text = (Convert.ToInt32(maxHits_textBox.Text) / 2).ToString();
            }
            catch (Exception) { }
        }
        private void healingValue_change()
        {
            try
            {
                if (maxHits_textBox.Text != "")
                    healing_value_textBox.Text = (Convert.ToInt32(maxHits_textBox.Text) / 4).ToString();
            }
            catch (Exception) { }
        }
        private void KDValue_change()
        {
            int lvl = 0;
            int armor = 0;
            int other = 0;

            if (lvl_textBox.Text != "")
                lvl = Convert.ToInt32(lvl_textBox.Text) / 2 + 10;
            KD_lvl_textBox.Text = lvl.ToString();

            if (KD_armor_textBox.Text != "")
                armor = Convert.ToInt32(KD_armor_textBox.Text);

            if (KD_other_textBox.Text != "")
                other = Convert.ToInt32(KD_other_textBox.Text);

            KD_value_textBox.Text = (lvl + armor + other).ToString();
        }
        private void DurabilityValue_change()
        {
            int lvl = 0;
            int armor = 0;
            int other = 0;

            if (lvl_textBox.Text != "")
                lvl = Convert.ToInt32(lvl_textBox.Text) / 2 + 10;
            durability_lvl_textBox.Text = lvl.ToString();

            if (durability_armor_textBox.Text != "")
                armor = Convert.ToInt32(durability_armor_textBox.Text);

            if (durability_other_textBox.Text != "")
                other = Convert.ToInt32(durability_other_textBox.Text);

            durability_value_textBox.Text = (lvl + armor + other).ToString();
        }
        private void ReactionValue_change()
        {
            int lvl = 0;
            int armor = 0;
            int other = 0;

            if (lvl_textBox.Text != "")
                lvl = Convert.ToInt32(lvl_textBox.Text) / 2 + 10;
            reaction_lvl_textBox.Text = lvl.ToString();

            if (reaction_armor_textBox.Text != "")
                armor = Convert.ToInt32(reaction_armor_textBox.Text);

            if (reaction_other_textBox.Text != "")
                other = Convert.ToInt32(reaction_other_textBox.Text);

            reaction_value_textBox.Text = (lvl + armor + other).ToString();
        }
        private void WillValue_change()
        {
            int lvl = 0;
            int armor = 0;
            int other = 0;

            if (lvl_textBox.Text != "")
                lvl = Convert.ToInt32(lvl_textBox.Text) / 2 + 10;
            will_lvl_textBox.Text = lvl.ToString();

            if (will_armor_textBox.Text != "")
                armor = Convert.ToInt32(will_armor_textBox.Text);

            if (will_other_textBox.Text != "")
                other = Convert.ToInt32(will_other_textBox.Text);

            will_value_textBox.Text = (lvl + armor + other).ToString();
        }
        private void submit_button_Click(object sender, EventArgs e)
        {
            strange_change();
            stamina_change();
            agility_change();
            intelligence_change();
            wizdom_change();
            charisma_change();
            //копирование мод. + 1/2 ур.
            acrobatics_mod_textBox.Text = mod_lvl_agility_textBox.Text;
            athletics_mod_textBox.Text = mod_lvl_strange_textBox.Text;
            attentiveness_mod_textBox.Text = mod_lvl_wisdom_textBox.Text;
            steal_mod_textBox.Text = mod_lvl_agility_textBox.Text;
            endurance_mod_textBox.Text = mod_lvl_stamina_textBox.Text;
            terrifying_mod_textBox.Text = mod_lvl_charisma_textBox.Text;
            streetKnowlage_mod_textBox.Text = mod_lvl_charisma_textBox.Text;
            history_mod_textBox.Text = mod_lvl_intelligence_textBox.Text;
            magic_mod_textBox.Text = mod_lvl_intelligence_textBox.Text;
            cheating_mod_textBox.Text = mod_lvl_charisma_textBox.Text;
            discussion_mod_textBox.Text = mod_lvl_charisma_textBox.Text;
            dungeons_mod_textBox.Text = mod_lvl_wisdom_textBox.Text;
            nature_mod_textBox.Text = mod_lvl_wisdom_textBox.Text;
            insight_mod_textBox.Text = mod_lvl_wisdom_textBox.Text;
            religion_mod_textBox.Text = mod_lvl_intelligence_textBox.Text;
            stealth_mod_textBox.Text = mod_lvl_agility_textBox.Text;
            curing_mod_textBox.Text = mod_lvl_wisdom_textBox.Text;
            //навыки
            acrobatics_change();
            athletics_change();
            attentiveness_change();
            steal_change();
            endurance_change();
            terrifying_change();
            streetKnowlage_change();
            history_change();
            magic_change();
            cheating_change();
            discussion_change();
            dungeons_change();
            nature_change();
            insight_change();
            religion_change();
            stealth_change();
            curing_change();
            //хиты
            healingValue_change();
            wounded_change();
            //защиты
            KDValue_change();
            DurabilityValue_change();
            ReactionValue_change();
            WillValue_change();
        }

        private void strange_hilight_on()
        {
            Color color = Color.Yellow;
            strange_label.BackColor = color;
            athletics_label.BackColor = color;
        }
        private void strange_hilight_off()
        {
            Color color = Color.Empty;
            strange_label.BackColor = color;
            athletics_label.BackColor = color;
        }
        private void stamina_hilight_on()
        {
            Color color = Color.Yellow;
            stamina_label.BackColor = color;
            endurance_label.BackColor = color;
        }
        private void stamina_hilight_off()
        {
            Color color = Color.Empty;
            stamina_label.BackColor = color;
            endurance_label.BackColor = color;
        }

        private void agility_hilight_on()
        {
            Color color = Color.Yellow;
            agility_label.BackColor = color;
            acrobatics_label.BackColor = color;
            steal_label.BackColor = color;
            stealth_label.BackColor = color;
        }
        private void agility_hilight_off()
        {
            Color color = Color.Empty;
            agility_label.BackColor = color;
            acrobatics_label.BackColor = color;
            steal_label.BackColor = color;
            stealth_label.BackColor = color;
        }
        private void intelligence_hilight_on()
        {
            Color color = Color.Yellow;
            intelligence_label.BackColor = color;
            history_label.BackColor = color;
            magic_label.BackColor = color;
            religion_label.BackColor = color;
        }
        private void intelligence_hilight_off()
        {
            Color color = Color.Empty;
            intelligence_label.BackColor = color;
            history_label.BackColor = color;
            magic_label.BackColor = color;
            religion_label.BackColor = color;
        }
        private void wizdom_hilight_on()
        {
            Color color = Color.Yellow;
            wisdom_label.BackColor = color;
            attentiveness_label.BackColor = color;
            dungeons_label.BackColor = color;
            nature_label.BackColor = color;
            insight_label.BackColor = color;
            curing_label.BackColor = color;
        }
        private void wizdom_hilight_off()
        {
            Color color = Color.Empty;
            wisdom_label.BackColor = color;
            attentiveness_label.BackColor = color;
            dungeons_label.BackColor = color;
            nature_label.BackColor = color;
            insight_label.BackColor = color;
            curing_label.BackColor = color;
        }
        private void charisma_hilight_on()
        {
            Color color = Color.Yellow;
            charisma_label.BackColor = color;
            terrifying_label.BackColor = color;
            streetKnowlage_label.BackColor = color;
            cheating_label.BackColor = color;
            discussion_label.BackColor = color;
        }
        private void charisma_hilight_off()
        {
            Color color = Color.Empty;
            charisma_label.BackColor = color;
            terrifying_label.BackColor = color;
            streetKnowlage_label.BackColor = color;
            cheating_label.BackColor = color;
            discussion_label.BackColor = color;
        }

        private void strange_label_MouseEnter(object sender, EventArgs e)
        {
            strange_hilight_on();
        }

        private void strange_label_MouseLeave(object sender, EventArgs e)
        {
            strange_hilight_off();
        }

        private void stamina_label_MouseEnter(object sender, EventArgs e)
        {
            stamina_hilight_on();
        }

        private void stamina_label_MouseLeave(object sender, EventArgs e)
        {
            stamina_hilight_off();
        }

        private void agility_label_MouseEnter(object sender, EventArgs e)
        {
            agility_hilight_on();
        }

        private void agility_label_MouseLeave(object sender, EventArgs e)
        {
            agility_hilight_off();
        }

        private void intelligence_label_MouseEnter(object sender, EventArgs e)
        {
            intelligence_hilight_on();
        }

        private void intelligence_label_MouseLeave(object sender, EventArgs e)
        {
            intelligence_hilight_off();
        }

        private void wizdom_label_MouseEnter(object sender, EventArgs e)
        {
            wizdom_hilight_on();
        }

        private void wizdom_label_MouseLeave(object sender, EventArgs e)
        {
            wizdom_hilight_off();
        }

        private void charisma_label_MouseEnter(object sender, EventArgs e)
        {
            charisma_hilight_on();
        }

        private void charisma_label_MouseLeave(object sender, EventArgs e)
        {
            charisma_hilight_off();
        }


        private void strange_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                strange_change();
                e.Handled = true;
            }
        }

        private void stamina_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                stamina_change();
                e.Handled = true;
            }
        }

        private void agility_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                agility_change();
                e.Handled = true;
            }
        }

        private void intelligence_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                intelligence_change();
                e.Handled = true;
            }
        }

        private void wizdom_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                wizdom_change();
                e.Handled = true;
            }
        }

        private void charisma_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                charisma_change();
                e.Handled = true;
            }
        }

        private void lvl_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                strange_change();
                stamina_change();
                agility_change();
                intelligence_change();
                wizdom_change();
                charisma_change();

                //копирование мод. + 1/2 ур.
                acrobatics_mod_textBox.Text = mod_lvl_agility_textBox.Text;
                athletics_mod_textBox.Text = mod_lvl_strange_textBox.Text;
                attentiveness_mod_textBox.Text = mod_lvl_wisdom_textBox.Text;
                steal_mod_textBox.Text = mod_lvl_agility_textBox.Text;
                endurance_mod_textBox.Text = mod_lvl_stamina_textBox.Text;
                terrifying_mod_textBox.Text = mod_lvl_charisma_textBox.Text;
                streetKnowlage_mod_textBox.Text = mod_lvl_charisma_textBox.Text;
                history_mod_textBox.Text = mod_lvl_intelligence_textBox.Text;
                magic_mod_textBox.Text = mod_lvl_intelligence_textBox.Text;
                cheating_mod_textBox.Text = mod_lvl_charisma_textBox.Text;
                discussion_mod_textBox.Text = mod_lvl_charisma_textBox.Text;
                dungeons_mod_textBox.Text = mod_lvl_wisdom_textBox.Text;
                nature_mod_textBox.Text = mod_lvl_wisdom_textBox.Text;
                insight_mod_textBox.Text = mod_lvl_wisdom_textBox.Text;
                religion_mod_textBox.Text = mod_lvl_intelligence_textBox.Text;
                stealth_mod_textBox.Text = mod_lvl_agility_textBox.Text;
                curing_mod_textBox.Text = mod_lvl_wisdom_textBox.Text;

                acrobatics_change();
                athletics_change();
                attentiveness_change();
                stealth_change();
                endurance_change();
                terrifying_change();
                streetKnowlage_change();
                history_change();
                magic_change();
                cheating_change();
                discussion_change();
                dungeons_change();
                nature_change();
                insight_change();
                religion_change();
                stealth_change();
                curing_change();
                e.Handled = true;
            }
        }

        private void maxHits_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                wounded_change();
                e.Handled = true;
            }
        }

        private void acrobatics_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                acrobatics_mod_textBox.Text = mod_lvl_agility_textBox.Text;
                acrobatics_change();
                e.Handled = true;
            }
        }

        private void athletics_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                athletics_change();
                e.Handled = true;
            }
        }

        private void attentiveness_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                attentiveness_change();
                e.Handled = true;
            }
        }

        private void steal_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                steal_change();
                e.Handled = true;
            }
        }

        private void endurance_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                endurance_change();
                e.Handled = true;
            }
        }

        private void terrifying_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                terrifying_change();
                e.Handled = true;
            }
        }

        private void streetKnowlage_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                streetKnowlage_change();
                e.Handled = true;
            }
        }

        private void history_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                history_change();
                e.Handled = true;
            }
        }

        private void magic_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                magic_change();
                e.Handled = true;
            }
        }

        private void cheating_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cheating_change();
                e.Handled = true;
            }
        }

        private void discussion_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                discussion_change();
                e.Handled = true;
            }
        }

        private void dungeons_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dungeons_change();
                e.Handled = true;
            }
        }

        private void nature_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                nature_change();
                e.Handled = true;
            }
        }

        private void insight_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                insight_change();
                e.Handled = true;
            }
        }

        private void religion_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                religion_change();
                e.Handled = true;
            }
        }

        private void stealth_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                stealth_change();
                e.Handled = true;
            }
        }

        private void curing_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                curing_change();
                e.Handled = true;
            }
        }

        //Бросок дайсов
        private void Dices_throw_button_Click(object sender, EventArgs e)
        {
            try
            {
                int[] values = new int[Convert.ToInt32(dices_amount_textBox.Text)];
                Random random = new Random();
                for (int i = 0; i < Convert.ToInt32(dices_amount_textBox.Text); i++)
                    values[i] = random.Next(1, Convert.ToInt32(dices_value_textBox.Text) + 1);
                //формирование новой строки
                string newStr = "";
                int j = 0;
                if (values[0] != 0)
                {
                    newStr += values[0];
                    j++;
                }
                while (j < values.Length)
                {
                    newStr += " + " + values[j];
                    j++;
                }
                newStr += " = " + values.Sum() + "\r\n";
                //добавление строк
                string previousText = dices_log_textBox.Text;
                dices_log_textBox.Clear();
                dices_log_textBox.AppendText(newStr);
                dices_log_textBox.AppendText(previousText);
                dices_log_textBox.SelectionStart = 0;
                dices_log_textBox.ScrollToCaret();
            }
            catch (Exception) { }
        }

        //Снаряжение
        MyBackpack backpackForm = new MyBackpack();
        private void СнаряжениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!backpackForm.Created)
                backpackForm = new MyBackpack();
            backpackForm.Show();
            backpackForm.BringToFront();
        }

        //Таланты
        MyTalents talentsForm = new MyTalents();
        private void талантыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!talentsForm.Created)
                talentsForm = new MyTalents();
            talentsForm.Show();
            talentsForm.BringToFront();
        }
        //Добавление талантов в лист
        public static List<Talent> allTalents = new List<Talent>();
        private void mainForm_Load(object sender, EventArgs e)
        {
            талантыToolStripMenuItem1_Click(new object(), new EventArgs());
        }

        //Класс
        public static string MyClass = "";
        private void myClass_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyClass = myClass_comboBox.SelectedItem.ToString();
        }

        //Экспорт
        private void экспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = Directory.GetCurrentDirectory() + "\\Stats.txt";
            StreamWriter writer = new StreamWriter(filePath);
            string str = "";
            try
            {
                str = name_textBox.Text + "|" + lvl_textBox.Text + "|" + myClass_comboBox.Text + "|" +
                    strange_textBox.Text + "|" + stamina_textBox.Text + "|" + agility_textBox.Text + "|" + intelligence_textBox.Text + "|" + wisdom_textBox.Text + "|" + charisma_textBox.Text + "|" +  //характеристики
                    maxHits_textBox.Text + "|" + curHits_textBox.Text + "|" + temporary_textBox.Text + "|" + healing_amount_textBox.Text + "|" + healingsUsed_textBox.Text + "|" + secondWind_checkBox.Checked.ToString() + "|" + failedDeathSaves_checkBox1.Checked.ToString() + "|" + failedDeathSaves_checkBox2.Checked.ToString() + "|" + failedDeathSaves_checkBox3.Checked.ToString() + "|" + effects_textBox.Text + "|" +    //хиты
                    acrobatics_textBox.Text + "|" + athletics_textBox.Text + "|" + attentiveness_textBox.Text + "|" + steal_textBox.Text + "|" + endurance_textBox.Text + "|" + terrifying_textBox.Text + "|" + streetKnowlage_textBox.Text + "|" + history_textBox.Text + "|" + magic_textBox.Text + "|" + cheating_textBox.Text + "|" + discussion_textBox.Text + "|" + dungeons_textBox.Text + "|" + nature_textBox.Text + "|" + insight_textBox.Text + "|" + religion_textBox.Text + "|" + stealth_textBox.Text + "|" + curing_textBox.Text + "|" + //бонусы навыков
                    acrobatics_checkBox.Checked.ToString() + "|" + athletics_checkBox.Checked.ToString() + "|" + attentiveness_checkBox.Checked.ToString() + "|" + steal_checkBox.Checked.ToString() + "|" + endurance_checkBox.Checked.ToString() + "|" + terrifying_checkBox.Checked.ToString() + "|" + streetKnowlage_checkBox.Checked.ToString() + "|" + history_checkBox.Checked.ToString() + "|" + magic_checkBox.Checked.ToString() + "|" + cheating_checkBox.Checked.ToString() + "|" + discussion_checkBox.Checked.ToString() + "|" + dungeons_checkBox.Checked.ToString() + "|" + nature_checkBox.Checked.ToString() + "|" + insight_checkBox.Checked.ToString() + "|" + religion_checkBox.Checked.ToString() + "|" + stealth_checkBox.Checked.ToString() + "|" + curing_checkBox.Checked.ToString() + "|" +  //тренированность
                    acrobatics_armorFine_textBox.Text + "|" + athletics_armorFine_textBox.Text + "|" + steal_armorFine_textBox.Text + "|" + endurance_armorFine_textBox.Text + "|" + stealth_armorFine_textBox.Text + "|" + //штрафы за броню
                    acrobatics_other_textBox.Text + "|" + athletics_other_textBox.Text + "|" + attentiveness_other_textBox.Text + "|" + steal_other_textBox.Text + "|" + endurance_other_textBox.Text + "|" + terrifying_other_textBox.Text + "|" + streetKnowlage_other_textBox.Text + "|" + history_other_textBox.Text + "|" + magic_other_textBox.Text + "|" + cheating_other_textBox.Text + "|" + discussion_other_textBox.Text + "|" + dungeons_other_textBox.Text + "|" + nature_other_textBox.Text + "|" + insight_other_textBox.Text + "|" + religion_other_textBox.Text + "|" + stealth_other_textBox.Text + "|" + curing_other_textBox.Text + "|" +   //иное
                    KD_armor_textBox.Text + "|" + durability_armor_textBox.Text + "|" + reaction_armor_textBox.Text + "|" + will_armor_textBox.Text + "|" + KD_other_textBox.Text + "|" + durability_other_textBox.Text + "|" + reaction_other_textBox.Text + "|" + will_other_textBox.Text;
            }
            catch (Exception)
            {
                var result = MessageBox.Show("Заполните все необходимые пустые поля.", "Ошибка",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            writer.Write(str);
            writer.Dispose();
        }

        //Импорт характеристик
        private void характеристикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = Directory.GetCurrentDirectory() + "\\Stats.txt";
            StreamReader reader = new StreamReader(filePath, System.Text.Encoding.UTF8);
            string str = reader.ReadLine();
            string[] values = str.Split('|');
            name_textBox.Text = values[0];
            lvl_textBox.Text = values[1];
            myClass_comboBox.Text = values[2];
            //характеристики
            strange_textBox.Text = values[3];
            stamina_textBox.Text = values[4];
            agility_textBox.Text = values[5];
            intelligence_textBox.Text = values[6];
            wisdom_textBox.Text = values[7];
            charisma_textBox.Text = values[8];
            //хиты
            maxHits_textBox.Text = values[9];
            curHits_textBox.Text = values[10];
            temporary_textBox.Text = values[11];
            healing_amount_textBox.Text = values[12];
            healingsUsed_textBox.Text = values[13];
            secondWind_checkBox.Checked = Convert.ToBoolean(values[14]);
            failedDeathSaves_checkBox1.Checked = Convert.ToBoolean(values[15]);
            failedDeathSaves_checkBox2.Checked = Convert.ToBoolean(values[16]);
            failedDeathSaves_checkBox3.Checked = Convert.ToBoolean(values[17]);
            effects_textBox.Text = values[18];
            //бонусы навыков
            acrobatics_textBox.Text = values[19];
            athletics_textBox.Text = values[20];
            attentiveness_textBox.Text = values[21];
            steal_textBox.Text = values[22];
            endurance_textBox.Text = values[23];
            terrifying_textBox.Text = values[24];
            streetKnowlage_textBox.Text = values[25];
            history_textBox.Text = values[26];
            magic_textBox.Text = values[27];
            cheating_textBox.Text = values[28];
            discussion_textBox.Text = values[29];
            dungeons_textBox.Text = values[30];
            nature_textBox.Text = values[31];
            insight_textBox.Text = values[32];
            religion_textBox.Text = values[33];
            stealth_textBox.Text = values[34];
            curing_textBox.Text = values[35];
            //тренированность
            acrobatics_checkBox.Checked = Convert.ToBoolean(values[36]);
            athletics_checkBox.Checked = Convert.ToBoolean(values[37]);
            attentiveness_checkBox.Checked = Convert.ToBoolean(values[38]);
            steal_checkBox.Checked = Convert.ToBoolean(values[39]);
            endurance_checkBox.Checked = Convert.ToBoolean(values[40]);
            terrifying_checkBox.Checked = Convert.ToBoolean(values[41]);
            streetKnowlage_checkBox.Checked = Convert.ToBoolean(values[42]);
            history_checkBox.Checked = Convert.ToBoolean(values[43]);
            magic_checkBox.Checked = Convert.ToBoolean(values[44]);
            cheating_checkBox.Checked = Convert.ToBoolean(values[45]);
            discussion_checkBox.Checked = Convert.ToBoolean(values[46]);
            dungeons_checkBox.Checked = Convert.ToBoolean(values[47]);
            nature_checkBox.Checked = Convert.ToBoolean(values[48]);
            insight_checkBox.Checked = Convert.ToBoolean(values[49]);
            religion_checkBox.Checked = Convert.ToBoolean(values[50]);
            stealth_checkBox.Checked = Convert.ToBoolean(values[51]);
            curing_checkBox.Checked = Convert.ToBoolean(values[52]);
            //штрафы за броню
            acrobatics_armorFine_textBox.Text = values[53];
            athletics_armorFine_textBox.Text = values[54];
            steal_armorFine_textBox.Text = values[55];
            endurance_armorFine_textBox.Text = values[56];
            stealth_armorFine_textBox.Text = values[57];
            //иное
            acrobatics_other_textBox.Text = values[58];
            athletics_other_textBox.Text = values[59];
            attentiveness_other_textBox.Text = values[60];
            steal_other_textBox.Text = values[61];
            endurance_other_textBox.Text = values[62];
            terrifying_other_textBox.Text = values[63];
            streetKnowlage_other_textBox.Text = values[64];
            history_other_textBox.Text = values[65];
            magic_other_textBox.Text = values[66];
            cheating_other_textBox.Text = values[67];
            discussion_other_textBox.Text = values[68];
            dungeons_other_textBox.Text = values[69];
            nature_other_textBox.Text = values[70];
            insight_other_textBox.Text = values[71];
            religion_other_textBox.Text = values[72];
            stealth_other_textBox.Text = values[73];
            curing_other_textBox.Text = values[74];
            //защиты
            KD_armor_textBox.Text = values[75];
            durability_armor_textBox.Text = values[76];
            reaction_armor_textBox.Text = values[77];
            will_armor_textBox.Text = values[78];
            KD_other_textBox.Text = values[79];
            durability_other_textBox.Text = values[80];
            reaction_other_textBox.Text = values[81];
            will_other_textBox.Text = values[82];
            reader.Dispose();
        }

        //Импорт талантов
        private void талантыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            allTalents.Clear();
            string filePath = Directory.GetCurrentDirectory() + "\\Talents.txt";
            StreamReader reader = new StreamReader(filePath, System.Text.Encoding.Default);
            while (!reader.EndOfStream)
            {
                string str = reader.ReadLine();
                string[] values = str.Split('|');
                allTalents.Add(new Talent(values));
            }
            reader.Dispose();
        }
    }
}
