namespace КП
{
    partial class Theory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Theory));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.темыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видыМатрицToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операцииНадМатрицамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.определителиМатрицToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рангМатрицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обратнаяМатрицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методГауссаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методКрамераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методГауссаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.темыToolStripMenuItem,
            this.назадToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(681, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // темыToolStripMenuItem
            // 
            this.темыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видыМатрицToolStripMenuItem,
            this.операцииНадМатрицамиToolStripMenuItem,
            this.определителиМатрицToolStripMenuItem,
            this.рангМатрицыToolStripMenuItem,
            this.обратнаяМатрицаToolStripMenuItem,
            this.методГауссаToolStripMenuItem});
            this.темыToolStripMenuItem.Name = "темыToolStripMenuItem";
            this.темыToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.темыToolStripMenuItem.Text = "Темы";
            // 
            // видыМатрицToolStripMenuItem
            // 
            this.видыМатрицToolStripMenuItem.Name = "видыМатрицToolStripMenuItem";
            this.видыМатрицToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.видыМатрицToolStripMenuItem.Text = "Виды матриц";
            this.видыМатрицToolStripMenuItem.Click += new System.EventHandler(this.видыМатрицToolStripMenuItem_Click);
            // 
            // операцииНадМатрицамиToolStripMenuItem
            // 
            this.операцииНадМатрицамиToolStripMenuItem.Name = "операцииНадМатрицамиToolStripMenuItem";
            this.операцииНадМатрицамиToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.операцииНадМатрицамиToolStripMenuItem.Text = "Операции над матрицами";
            this.операцииНадМатрицамиToolStripMenuItem.Click += new System.EventHandler(this.операцииНадМатрицамиToolStripMenuItem_Click);
            // 
            // определителиМатрицToolStripMenuItem
            // 
            this.определителиМатрицToolStripMenuItem.Name = "определителиМатрицToolStripMenuItem";
            this.определителиМатрицToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.определителиМатрицToolStripMenuItem.Text = "Определители матриц";
            this.определителиМатрицToolStripMenuItem.Click += new System.EventHandler(this.определителиМатрицToolStripMenuItem_Click);
            // 
            // рангМатрицыToolStripMenuItem
            // 
            this.рангМатрицыToolStripMenuItem.Name = "рангМатрицыToolStripMenuItem";
            this.рангМатрицыToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.рангМатрицыToolStripMenuItem.Text = "Ранг матрицы";
            this.рангМатрицыToolStripMenuItem.Click += new System.EventHandler(this.рангМатрицыToolStripMenuItem_Click);
            // 
            // обратнаяМатрицаToolStripMenuItem
            // 
            this.обратнаяМатрицаToolStripMenuItem.Name = "обратнаяМатрицаToolStripMenuItem";
            this.обратнаяМатрицаToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.обратнаяМатрицаToolStripMenuItem.Text = "Обратная матрица";
            this.обратнаяМатрицаToolStripMenuItem.Click += new System.EventHandler(this.обратнаяМатрицаToolStripMenuItem_Click);
            // 
            // методГауссаToolStripMenuItem
            // 
            this.методГауссаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.методКрамераToolStripMenuItem,
            this.методГауссаToolStripMenuItem1});
            this.методГауссаToolStripMenuItem.Name = "методГауссаToolStripMenuItem";
            this.методГауссаToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.методГауссаToolStripMenuItem.Text = "Решение систем линейных уравнений";
            // 
            // методКрамераToolStripMenuItem
            // 
            this.методКрамераToolStripMenuItem.Name = "методКрамераToolStripMenuItem";
            this.методКрамераToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.методКрамераToolStripMenuItem.Text = "Метод Крамера";
            this.методКрамераToolStripMenuItem.Click += new System.EventHandler(this.методКрамераToolStripMenuItem_Click);
            // 
            // методГауссаToolStripMenuItem1
            // 
            this.методГауссаToolStripMenuItem1.Name = "методГауссаToolStripMenuItem1";
            this.методГауссаToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.методГауссаToolStripMenuItem1.Text = "Метод Гаусса";
            this.методГауссаToolStripMenuItem1.Click += new System.EventHandler(this.методГауссаToolStripMenuItem1_Click);
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.webBrowser1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(681, 410);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(23, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(675, 404);
            this.webBrowser1.TabIndex = 7;
            this.webBrowser1.Url = new System.Uri("C:\\Users\\Алексей\\Desktop\\Курсовой проект\\КП\\ресурсы\\1.html", System.UriKind.Absolute);
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // Theory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 434);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(10, 10);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(697, 250);
            this.Name = "Theory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Теоретический материал";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Theory_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem темыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видыМатрицToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операцииНадМатрицамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem определителиМатрицToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обратнаяМатрицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рангМатрицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методГауссаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методКрамераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методГауссаToolStripMenuItem1;
    }
}