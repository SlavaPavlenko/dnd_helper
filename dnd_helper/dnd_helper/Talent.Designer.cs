namespace dnd_helper
{
    partial class Talent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.usageRate = new System.Windows.Forms.Label();
            this.actionType = new System.Windows.Forms.Label();
            this.required = new System.Windows.Forms.Label();
            this.condition = new System.Windows.Forms.Label();
            this.target = new System.Windows.Forms.Label();
            this.attack = new System.Windows.Forms.Label();
            this.feature = new System.Windows.Forms.Label();
            this.hit = new System.Windows.Forms.Label();
            this.miss = new System.Windows.Forms.Label();
            this.lvlUpgrades = new System.Windows.Forms.Label();
            this.effect = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(2, 3);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(57, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Уровень";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Location = new System.Drawing.Point(347, 3);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(14, 13);
            this.level.TabIndex = 2;
            this.level.Text = "#";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(2, 27);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(357, 44);
            this.description.TabIndex = 3;
            this.description.Text = "Описание";
            // 
            // usageRate
            // 
            this.usageRate.AutoSize = true;
            this.usageRate.Location = new System.Drawing.Point(3, 76);
            this.usageRate.Name = "usageRate";
            this.usageRate.Size = new System.Drawing.Size(100, 13);
            this.usageRate.TabIndex = 4;
            this.usageRate.Text = "неогр/сцена/день";
            // 
            // actionType
            // 
            this.actionType.AutoSize = true;
            this.actionType.Location = new System.Drawing.Point(3, 93);
            this.actionType.Name = "actionType";
            this.actionType.Size = new System.Drawing.Size(74, 13);
            this.actionType.TabIndex = 5;
            this.actionType.Text = "тип действия";
            // 
            // required
            // 
            this.required.BackColor = System.Drawing.SystemColors.ControlDark;
            this.required.Location = new System.Drawing.Point(204, 76);
            this.required.Name = "required";
            this.required.Size = new System.Drawing.Size(155, 30);
            this.required.TabIndex = 6;
            this.required.Text = "Требуемое";
            // 
            // condition
            // 
            this.condition.BackColor = System.Drawing.SystemColors.ControlDark;
            this.condition.Location = new System.Drawing.Point(6, 110);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(353, 36);
            this.condition.TabIndex = 7;
            this.condition.Text = "Условие использования: ";
            // 
            // target
            // 
            this.target.BackColor = System.Drawing.SystemColors.ControlDark;
            this.target.Location = new System.Drawing.Point(6, 151);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(170, 40);
            this.target.TabIndex = 8;
            this.target.Text = "Цель: ";
            // 
            // attack
            // 
            this.attack.AutoSize = true;
            this.attack.Location = new System.Drawing.Point(6, 196);
            this.attack.Name = "attack";
            this.attack.Size = new System.Drawing.Size(43, 13);
            this.attack.TabIndex = 9;
            this.attack.Text = "Атака: ";
            // 
            // feature
            // 
            this.feature.BackColor = System.Drawing.SystemColors.ControlDark;
            this.feature.Location = new System.Drawing.Point(182, 151);
            this.feature.Name = "feature";
            this.feature.Size = new System.Drawing.Size(177, 40);
            this.feature.TabIndex = 10;
            this.feature.Text = "Особенность: ";
            // 
            // hit
            // 
            this.hit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hit.Location = new System.Drawing.Point(6, 215);
            this.hit.Name = "hit";
            this.hit.Size = new System.Drawing.Size(353, 39);
            this.hit.TabIndex = 11;
            this.hit.Text = "Попадание: ";
            // 
            // miss
            // 
            this.miss.BackColor = System.Drawing.SystemColors.ControlDark;
            this.miss.Location = new System.Drawing.Point(6, 258);
            this.miss.Name = "miss";
            this.miss.Size = new System.Drawing.Size(353, 42);
            this.miss.TabIndex = 12;
            this.miss.Text = "Промах: ";
            // 
            // lvlUpgrades
            // 
            this.lvlUpgrades.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lvlUpgrades.Location = new System.Drawing.Point(6, 357);
            this.lvlUpgrades.Name = "lvlUpgrades";
            this.lvlUpgrades.Size = new System.Drawing.Size(353, 60);
            this.lvlUpgrades.TabIndex = 13;
            this.lvlUpgrades.Text = "Улучшение: ";
            // 
            // effect
            // 
            this.effect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.effect.Location = new System.Drawing.Point(6, 304);
            this.effect.Name = "effect";
            this.effect.Size = new System.Drawing.Size(353, 49);
            this.effect.TabIndex = 14;
            this.effect.Text = "Эффект: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.required);
            this.panel1.Controls.Add(this.feature);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.level);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 421);
            this.panel1.TabIndex = 15;
            // 
            // Talent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 421);
            this.Controls.Add(this.effect);
            this.Controls.Add(this.lvlUpgrades);
            this.Controls.Add(this.miss);
            this.Controls.Add(this.hit);
            this.Controls.Add(this.attack);
            this.Controls.Add(this.target);
            this.Controls.Add(this.condition);
            this.Controls.Add(this.actionType);
            this.Controls.Add(this.usageRate);
            this.Controls.Add(this.description);
            this.Controls.Add(this.name);
            this.Controls.Add(this.panel1);
            this.Name = "Talent";
            this.Text = "Талант ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Talent_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label usageRate;
        private System.Windows.Forms.Label actionType;
        private System.Windows.Forms.Label required;
        private System.Windows.Forms.Label condition;
        private System.Windows.Forms.Label target;
        private System.Windows.Forms.Label attack;
        private System.Windows.Forms.Label feature;
        private System.Windows.Forms.Label hit;
        private System.Windows.Forms.Label miss;
        private System.Windows.Forms.Label lvlUpgrades;
        private System.Windows.Forms.Label effect;
        private System.Windows.Forms.Panel panel1;
    }
}