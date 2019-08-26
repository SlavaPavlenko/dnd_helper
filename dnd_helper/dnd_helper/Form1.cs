using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
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
            //вычисление модификатора
            int mod;
            if (acrobatics_mod_textBox.Text != "")
                mod = Convert.ToInt32(acrobatics_mod_textBox.Text);
            else mod = 0;
            //вычисление результата
            acrobatics_result_textBox.Text = (bonus + mod + trained + armorFine + other).ToString();
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
            //вычисление модификатора
            int mod;
            if (athletics_mod_textBox.Text != "")
                mod = Convert.ToInt32(athletics_mod_textBox.Text);
            else mod = 0;
            //вычисление результата
            athletics_result_textBox.Text = (bonus + mod + trained + armorFine + other).ToString();
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
            //вычисление модификатора
            int mod;
            if (attentiveness_mod_textBox.Text != "")
                mod = Convert.ToInt32(attentiveness_mod_textBox.Text);
            else mod = 0;
            //вычисление результата
            attentiveness_result_textBox.Text = (bonus + mod + trained + other).ToString();
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
            //вычисление модификатора
            int mod;
            if (steal_mod_textBox.Text != "")
                mod = Convert.ToInt32(steal_mod_textBox.Text);
            else mod = 0;
            //вычисление результата
            steal_result_textBox.Text = (bonus + mod + trained + armorFine + other).ToString();
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
            //вычисление модификатора
            int mod;
            if (endurance_mod_textBox.Text != "")
                mod = Convert.ToInt32(endurance_mod_textBox.Text);
            else mod = 0;
            //вычисление результата
            endurance_result_textBox.Text = (bonus + mod + trained + armorFine + other).ToString();
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
            //вычисление модификатора
            int mod;
            if (terrifying_mod_textBox.Text != "")
                mod = Convert.ToInt32(terrifying_mod_textBox.Text);
            else mod = 0;
            //вычисление результата
            terrifying_result_textBox.Text = (bonus + mod + trained + other).ToString();
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
            //вычисление модификатора
            int mod;
            if (streetKnowlage_mod_textBox.Text != "")
                mod = Convert.ToInt32(streetKnowlage_mod_textBox.Text);
            else mod = 0;
            //вычисление результата
            streetKnowlage_result_textBox.Text = (bonus + mod + trained + other).ToString();
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
            //вычисление модификатора
            int mod;
            if (history_mod_textBox.Text != "")
                mod = Convert.ToInt32(history_mod_textBox.Text);
            else mod = 0;
            //вычисление результата
            history_result_textBox.Text = (bonus + mod + trained + other).ToString();
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
            //вычисление модификатора
            int mod;
            if (magic_mod_textBox.Text != "")
                mod = Convert.ToInt32(magic_mod_textBox.Text);
            else mod = 0;
            //вычисление результата
            magic_result_textBox.Text = (bonus + mod + trained + other).ToString();
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
            //вычисление модификатора
            int mod;
            if (cheating_mod_textBox.Text != "")
                mod = Convert.ToInt32(cheating_mod_textBox.Text);
            else mod = 0;
            //вычисление результата
            cheating_result_textBox.Text = (bonus + mod + trained + other).ToString();
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
            //вычисление модификатора
            int mod;
            if (discussion_mod_textBox.Text != "")
                mod = Convert.ToInt32(discussion_mod_textBox.Text);
            else mod = 0;
            //вычисление результата
            discussion_result_textBox.Text = (bonus + mod + trained + other).ToString();
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
            //вычисление модификатора
            int mod;
            if (dungeons_mod_textBox.Text != "")
                mod = Convert.ToInt32(dungeons_mod_textBox.Text);
            else mod = 0;
            //вычисление результата
            dungeons_result_textBox.Text = (bonus + mod + trained + other).ToString();
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
            //вычисление модификатора
            int mod;
            if (nature_mod_textBox.Text != "")
                mod = Convert.ToInt32(nature_mod_textBox.Text);
            else mod = 0;
            //вычисление результата
            nature_result_textBox.Text = (bonus + mod + trained + other).ToString();
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
            //вычисление модификатора
            int mod;
            if (insight_mod_textBox.Text != "")
                mod = Convert.ToInt32(insight_mod_textBox.Text);
            else mod = 0;
            //вычисление результата
            insight_result_textBox.Text = (bonus + mod + trained + other).ToString();
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
            //вычисление модификатора
            int mod;
            if (religion_mod_textBox.Text != "")
                mod = Convert.ToInt32(religion_mod_textBox.Text);
            else mod = 0;
            //вычисление результата
            religion_result_textBox.Text = (bonus + mod + trained + other).ToString();
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
            //вычисление модификатора
            int mod;
            if (stealth_mod_textBox.Text != "")
                mod = Convert.ToInt32(stealth_mod_textBox.Text);
            else mod = 0;
            //вычисление результата
            stealth_result_textBox.Text = (bonus + mod + trained + armorFine + other).ToString();
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
            //вычисление модификатора
            int mod;
            if (curing_mod_textBox.Text != "")
                mod = Convert.ToInt32(curing_mod_textBox.Text);
            else mod = 0;
            //вычисление результата
            curing_result_textBox.Text = (bonus + mod + trained + other).ToString();
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
            //ранение
            wounded_change();
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
            wizdom_label.BackColor = color;
            attentiveness_label.BackColor = color;
            dungeons_label.BackColor = color;
            nature_label.BackColor = color;
            insight_label.BackColor = color;
            curing_label.BackColor = color;
        }
        private void wizdom_hilight_off()
        {
            Color color = Color.Empty;
            wizdom_label.BackColor = color;
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
    }
}
