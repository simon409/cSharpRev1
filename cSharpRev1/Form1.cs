using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpRev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void catégoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categories c = new Categories();
            c.MdiParent=this;
            c.Show();
        }

        private void articlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Articles a = new Articles();
            a.MdiParent = this;
            a.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment quitter l'application", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.MdiParent = this;
            ab.Show();
        }
    }
}
