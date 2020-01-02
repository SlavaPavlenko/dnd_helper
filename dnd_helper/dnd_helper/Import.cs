using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnd_helper
{
    public partial class Import : Form
    {
        public Import()
        {
            InitializeComponent();
        }

        public static void talentsImport()
        {
            string str;
            string[] values;
            string filePath = Directory.GetCurrentDirectory() + "\\Talents.txt";
            StreamReader reader = new StreamReader(filePath, Encoding.GetEncoding(1251));
            while (!reader.EndOfStream)
            {
                str = reader.ReadLine();
                values = str.Split('|');
                mainForm.allTalents.Add(new Talent(values));
                int a = 2;
                a++;
            }
            reader.Dispose();
        }
        private void talentsImport(object sender, EventArgs e)
        {
            talentsImport();
        }

        private void Import_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((Import)sender).Hide();
            e.Cancel = true;
        }
    }
}
