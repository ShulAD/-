using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace КП
{
   
    public partial class Main : Form
    { 
      // Theory theory;
      // Test test;
      // Form main = new Main();
      // Point tb;

        public Main()
        {
            InitializeComponent();
            // { Visible = false };
            // { Visible = false };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form theory = new Theory(this);
            this.Visible = false;
            theory.ShowDialog();
           // theory.Visible=true;   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form choose = new Choose(this);
            this.Visible = false;
            choose.ShowDialog();
          //  test.Visible=true;
        }

        private void Main_Resize(object sender, EventArgs e)
        {
           /* button1.Height = this.Height - tb.Y;
            button1.Width = this.Width - tb.X;
            if ((this.Height / 100) > 8.25)
                button1.Font = new System.Drawing.Font("Tahoma", this.Height / 15);*/
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
           // DialogResult rezult = MessageBox.Show("Закрыть окно?", "Закрыть?", MessageBoxButtons.YesNo);
           /* if (MessageBox.Show("Закрыть окно?", "Закрыть?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {Application.Exit(); }
            else
            { e.Cancel = true; }*/
            DialogResult rezult = MessageBox.Show("Закрыть главное окно?", "Закрыть?", MessageBoxButtons.YesNo);
            if (rezult == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            { e.Cancel = true; }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Электронный учебник  «Решение систем линейных уравнений» \nРазработчик:\nШульгин А.Д.\n", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void какРаботатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Переход по формам осуществляется с помощью кнопок.\n");
        }
    }
}
