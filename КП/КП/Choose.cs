using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace КП
{
    public partial class Choose : Form
    {
        private Main _main;

        public Choose(Main main)
        {
            InitializeComponent();
            _main = main;
        }

        private void Choose_FormClosing(object sender, FormClosingEventArgs e)
        {
            _main.Visible = true;
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _main.Visible = true;
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form praktica = new Praktika(this);
            this.Visible = false;
            praktica.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2(this);
            this.Visible = false;
            form2.ShowDialog();
        }
    }
}
