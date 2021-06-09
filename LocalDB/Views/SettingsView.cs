using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalDB.Views
{
    public partial class SettingsView : Form
    {
        public SettingsView()
        {
            InitializeComponent();
            panel1.BackColor = Properties.Settings.Default.CommonBackColor;
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            var dr = colorDialog1.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                panel1.BackColor = colorDialog1.Color;
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CommonBackColor = panel1.BackColor;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
