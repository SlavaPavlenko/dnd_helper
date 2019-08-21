using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnd_helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void strange_change()
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
        private void agility_change()
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
        private void stamina_change()
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
        private void intelligence_change()
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
        private void wizdom_change()
        {
            //вычисление mod
            if (wizdom_textBox.Text != "")
                mod_wizdom_textBox.Text = (Convert.ToInt32(wizdom_textBox.Text) / 2 - 5).ToString();
            //вычисление mod + lvl/2
            int mod;
            if (mod_wizdom_textBox.Text == "")
                mod = 0;
            else mod = Convert.ToInt32(mod_wizdom_textBox.Text);
            int lvl_half;
            if (lvl_textBox.Text == "")
                lvl_half = 0;
            else
                lvl_half = Convert.ToInt32(lvl_textBox.Text) / 2;
            mod_lvl_wizdom_textBox.Text = (mod + lvl_half).ToString();
        }
        private void charisma_change()
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
        private void acrobatics_change()
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
            //вычисление результата
            acrobatics_result_textBox.Text = (bonus + Convert.ToInt32(acrobatics_mod_textBox.Text) + trained + armorFine + other).ToString();
        }
        private void athletics_change()
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
            //вычисление результата
            athletics_result_textBox.Text = (bonus + Convert.ToInt32(athletics_mod_textBox.Text) + trained + armorFine + other).ToString();
        }
        private void attentiveness_change()
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
            //вычисление результата
            attentiveness_result_textBox.Text = (bonus + Convert.ToInt32(attentiveness_mod_textBox.Text) + trained + other).ToString();
        }
        private void steal_change()
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
            //вычисление результата
            steal_result_textBox.Text = (bonus + Convert.ToInt32(steal_mod_textBox.Text) + trained + armorFine + other).ToString();
        }
        private void endurance_change()
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
            //вычисление результата
            endurance_result_textBox.Text = (bonus + Convert.ToInt32(endurance_mod_textBox.Text) + trained + armorFine + other).ToString();
        }
        private void terrifying_change()
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
            //вычисление результата
            terrifying_result_textBox.Text = (bonus + Convert.ToInt32(terrifying_mod_textBox.Text) + trained + other).ToString();
        }
        private void streetKnowlage_change()
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
            //вычисление результата
            streetKnowlage_result_textBox.Text = (bonus + Convert.ToInt32(streetKnowlage_mod_textBox.Text) + trained + other).ToString();
        }
        private void history_change()
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
            //вычисление результата
            history_result_textBox.Text = (bonus + Convert.ToInt32(history_mod_textBox.Text) + trained + other).ToString();
        }
        private void magic_change()
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
            //вычисление результата
            magic_result_textBox.Text = (bonus + Convert.ToInt32(magic_mod_textBox.Text) + trained + other).ToString();
        }
        private void cheating_change()
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
            //вычисление результата
            cheating_result_textBox.Text = (bonus + Convert.ToInt32(cheating_mod_textBox.Text) + trained + other).ToString();
        }
        private void discussion_change()
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
            //вычисление результата
            discussion_result_textBox.Text = (bonus + Convert.ToInt32(discussion_mod_textBox.Text) + trained + other).ToString();
        }
        private void dungeons_change()
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
            //вычисление результата
            dungeons_result_textBox.Text = (bonus + Convert.ToInt32(dungeons_mod_textBox.Text) + trained + other).ToString();
        }
        private void nature_change()
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
            //вычисление результата
            nature_result_textBox.Text = (bonus + Convert.ToInt32(nature_mod_textBox.Text) + trained + other).ToString();
        }
        private void insight_change()
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
            //вычисление результата
            insight_result_textBox.Text = (bonus + Convert.ToInt32(insight_mod_textBox.Text) + trained + other).ToString();
        }
        private void religion_change()
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
            //вычисление результата
            religion_result_textBox.Text = (bonus + Convert.ToInt32(religion_mod_textBox.Text) + trained + other).ToString();
        }
        private void stealth_change()
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
            //вычисление результата
            stealth_result_textBox.Text = (bonus + Convert.ToInt32(stealth_mod_textBox.Text) + trained + armorFine + other).ToString();
        }
        private void curing_change()
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
            //вычисление результата
            curing_result_textBox.Text = (bonus + Convert.ToInt32(curing_mod_textBox.Text) + trained + other).ToString();
        }
        private void wounded_change()
        {
            if (maxHits_textBox.Text != "")
                wounded_textBox.Text = (Convert.ToInt32(maxHits_textBox.Text) / 2).ToString();
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
            attentiveness_mod_textBox.Text = mod_lvl_wizdom_textBox.Text;
            steal_mod_textBox.Text = mod_lvl_agility_textBox.Text;
            endurance_mod_textBox.Text = mod_lvl_stamina_textBox.Text;
            terrifying_mod_textBox.Text = mod_lvl_charisma_textBox.Text;
            streetKnowlage_mod_textBox.Text = mod_lvl_charisma_textBox.Text;
            history_mod_textBox.Text = mod_lvl_intelligence_textBox.Text;
            magic_mod_textBox.Text = mod_lvl_intelligence_textBox.Text;
            cheating_mod_textBox.Text = mod_lvl_charisma_textBox.Text;
            discussion_mod_textBox.Text = mod_lvl_charisma_textBox.Text;
            dungeons_mod_textBox.Text = mod_lvl_wizdom_textBox.Text;
            nature_mod_textBox.Text = mod_lvl_wizdom_textBox.Text;
            insight_mod_textBox.Text = mod_lvl_wizdom_textBox.Text;
            religion_mod_textBox.Text = mod_lvl_intelligence_textBox.Text;
            stealth_mod_textBox.Text = mod_lvl_agility_textBox.Text;
            curing_mod_textBox.Text = mod_lvl_wizdom_textBox.Text;
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
            //
            wounded_change();
        }
    }
}
