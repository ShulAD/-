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
    public partial class Theory : Form
    {
        private Main _main;

        public Theory(Main main)
        {
            InitializeComponent();
            _main = main;
            quest(1);
        }

        private void Theory_FormClosing(object sender, FormClosingEventArgs e)
        {
           _main.Visible = true;
           this.Dispose();
        }

        void quest(int n)
        {
            
            string path = Application.StartupPath;
           
            switch (n)
            {
                case 1:
                    //Uri url1 = new Uri(path + @"\ресурсы\1.html");
                    //webBrowser1.Url = url1;
                   // webBrowser1.DocumentText = "C:\Users\Алексей\Desktop\Диплом\Исходники\КП\КП\Resources\1.html";
                  //  webBrowser1.Navigate(@path + "ресурсы/1.html");
                     Uri url1 = new Uri(path + @"\ресурсы\1.html");
                    webBrowser1.Url = url1; 
                   
                    break;
                case 2:
                    Uri url2 = new Uri(path + @"\ресурсы\2.html");
                    webBrowser1.Url = url2; 
                    break;
                case 3:
                    Uri url3 = new Uri(path + @"\ресурсы\3.html");
                    webBrowser1.Url = url3;
                    break;
                case 4:
                    Uri url4 = new Uri(path + @"\ресурсы\4.html");
                    webBrowser1.Url = url4;
                    break;
                case 5:
                    Uri url5 = new Uri(path + @"\ресурсы\5.html");
                    webBrowser1.Url = url5;
                    break;
                case 6:
                    Uri url6 = new Uri(path + @"\ресурсы\6.html");
                    webBrowser1.Url = url6;
                    break;
                case 7:
                    Uri url7 = new Uri(path + @"\ресурсы\7.html");
                    webBrowser1.Url = url7;
                    break;
            }
        }


        private void видыМатрицToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quest(1);
        }

        private void операцииНадМатрицамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quest(2);
        }

        private void определителиМатрицToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quest(3);
        }

        private void обратнаяМатрицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quest(5);
        }

        private void рангМатрицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quest(4);
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _main.Visible = true;
            this.Dispose();
        }

        private void методГауссаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void формулаКрамераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void методКрамераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quest(6);
        }

        private void методГауссаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            quest(7);
        }
    }
}