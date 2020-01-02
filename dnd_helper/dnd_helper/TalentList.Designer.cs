namespace dnd_helper
{
    partial class TalentList
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
            this.talents_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // talents_listBox
            // 
            this.talents_listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.talents_listBox.FormattingEnabled = true;
            this.talents_listBox.Location = new System.Drawing.Point(0, 0);
            this.talents_listBox.Name = "talents_listBox";
            this.talents_listBox.Size = new System.Drawing.Size(219, 226);
            this.talents_listBox.TabIndex = 0;
            this.talents_listBox.DoubleClick += new System.EventHandler(this.talents_listBox_DoubleClick);
            // 
            // TalentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 226);
            this.Controls.Add(this.talents_listBox);
            this.Name = "TalentList";
            this.Text = "Список талантов";
            this.Load += new System.EventHandler(this.TalentList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox talents_listBox;
    }
}