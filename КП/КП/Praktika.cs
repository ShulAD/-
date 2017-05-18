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
    public partial class Praktika : Form
    {
        private Choose _test;
        int _n;
        public int row, col;
        public double[,] matrix;
        double opred;


        public Praktika(Choose test)
        {
            InitializeComponent();
            _test = test;
           
        }
   
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Random rd = new Random();
                if (Convert.ToInt32(textBox1.Text) == 0) MessageBox.Show("Опеределитель нулевой матрицы =0");
                else
                {
                    col = Convert.ToInt32(textBox1.Text);
                    row = Convert.ToInt32(textBox1.Text);

                    matrix = new double[row, col];
                    int k = 0;
                    k = dataGridView1.ColumnCount;
                    if (k != 0)
                        for (int i = 0; i < k; i++)
                            dataGridView1.Columns.RemoveAt(0);

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < row; j++)
                        {
                            matrix[i, j] = rd.Next(20)-10;
                        }

                    AddColumns(row);
                    AddRows(row);

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < row; j++)
                        {
                            dataGridView1[i, j].Value = matrix[i, j];
                        }

                    opred = Determ(matrix);
                    label4.Text = Convert.ToString(opred);
                }
            }
            catch { MessageBox.Show("Введите корректные данные"); }
        }

        private void AddColumns(double n)
        {
            //добавляет n столбцов в элемент управления dgw
            //Заполнение DGView столбцами
            DataGridViewColumn column;
            for (int i = 0; i < n; i++)
            {
                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = i.ToString();
                column.Name = i.ToString();
                dataGridView1.Columns.Add(column);
            }
        }
        private void AddRows(double m)
        {
            //добавляет m строк в элемент управления dgw       
            //Заполнение DGView строками
            for (int i = 0; i < m; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].HeaderCell.Value = i.ToString();
            }
        }
        public static double[,] GetMinor(double[,] matrix, int row, int column)
        {
            double[,] buf = new double[matrix.GetLength(0) - 1, matrix.GetLength(0) - 1];

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i != row) || (j != column))
                    {
                        if (i > row && j < column) buf[i - 1, j] = matrix[i, j];
                        if (i < row && j > column) buf[i, j - 1] = matrix[i, j];
                        if (i > row && j > column) buf[i - 1, j - 1] = matrix[i, j];
                        if (i < row && j < column) buf[i, j] = matrix[i, j];
                    }
                }
            return buf;
        }
        public static double Determ(double[,] matrix)
        {
            double det = 0;
            int Rank = matrix.GetLength(0);
            if (Rank == 1)  det = matrix[0, 0];// MessageBox.Show("Опеределитель нулевой матрицы - 0"); }
            if (Rank == 2) det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            if (Rank > 2)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    det += Math.Pow(-1, 0 + j) * matrix[0, j] * Determ(GetMinor(matrix, 0, j));
                }
            }
            return det;
        }


        private void Praktika_FormClosing(object sender, FormClosingEventArgs e)
        {
            _test.Visible = true;
            this.Dispose();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (opred == Convert.ToDouble(textBox2.Text)) label5.Text = "Верно!";
                else label5.Text = "Не верно.";
            }
            catch { MessageBox.Show("Введите корректные данные"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _test.Visible = true;
            this.Dispose(); 
        }

        private void Praktika_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Form Form1 = new Form2(this);
            //this.Visible = false;
            //Form1.ShowDialog();
        }
    }
}





/*  public Matrix(int n, int m)
           {
               row = n;
               col = m;
               p = new int[n, m];
           }*/
/*    public Matrix Menor(int a, int b)
        {
            int i, j, p, q;
            Matrix MEN = new Matrix(row - 1, col - 1);
            for (j = 0, q = 0; q < MEN.col; j++, q++)
                for (i = 0, p = 0; p < MEN.row; i++, p++)
                {
                    if (i == a) i++;
                    if (j == b) j++;
                    MEN.p[p, q] = this.p[i, j];
                }
            return MEN;
        }*/
/* public double Det2x2()
    {
        double det;
        det = p[0, 0] * p[1, 1] - p[0, 1] * p[1, 0];

        return det;
    }*/