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
    public partial class Form2 : Form
    {
        bool otv = true, dan=true;
        double x, y, z;
        int n, shag = 1,q=0,osh=0;
        double[,] matrix;
        double[,] matrix2;
        double[,] matrix3;
        double[,] matrix4;
        double d;
        private Choose _test;

        public Form2(Choose chose)
        {
            _test = chose;
            InitializeComponent();
            groupBox3.Enabled = false;
            label11.Enabled = false;
            label11.Enabled = false;
            label11.Enabled = false;
            label11.Enabled = false;
            label11.Enabled = false;
            textBox1.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            groupBox6.Enabled = false;
            groupBox7.Enabled = false;
            label11.Visible = true;
            textBox1.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            groupBox5.Visible = true;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            button4.Enabled = false;
            button4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prisv();
            if (radioButton2.Checked)
            {
               
                    button1.Enabled = false;
                    button3.Enabled = true;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = true;
                    if (radioButton1.Checked)
                    { n = 1; button4.Enabled = true; button2.Enabled = false; groupBox6.Enabled = true; }
                    else
                    { n = 2; button2.Enabled = true; button4.Enabled = false; }
                   
            }
            else
            {
                button1.Enabled = false;

                button3.Enabled = true;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
                if (radioButton1.Checked)
                { n = 1; button4.Enabled = true; button2.Enabled = false; groupBox6.Enabled = true; }
                else
                { n = 2; button2.Enabled = true; button4.Enabled = false; }
               
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            groupBox3.Text = "Введите матрицу для нахождения главного определителя";
            groupBox4.Text = "Найденные определители";
            groupBox5.Text = "Найдите корни уравнения";
            groupBox6.Text = "Запишите расширенную матрицу";
            groupBox7.Text = "Предыдущий вид матрицы";
            shag = 1;
            q = 0;
            groupBox3.Enabled = false;
            label11.Enabled = false;
            textBox1.Enabled = false;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            x1.Clear();
            x2.Clear();
            x3.Clear();
            y1.Clear();
            y2.Clear();
            y3.Clear();
            z1.Clear();
            z2.Clear();
            z3.Clear();
            b1.Clear();
            b2.Clear();
            b3.Clear();
            a00.Clear();
            a01.Clear();
            a02.Clear();
            a10.Clear();
            a11.Clear();
            a12.Clear();
            a20.Clear();
            a21.Clear();
            a22.Clear();
            c00.Clear();
            c01.Clear();
            c02.Clear();
            c10.Clear();
            c11.Clear();
            c12.Clear();
            c20.Clear();
            c21.Clear();
            c22.Clear();
            e0.Clear();
            e1.Clear();
            e2.Clear();
            a_00.Clear();
            a_01.Clear();
            a_02.Clear();
            a_10.Clear();
            a_11.Clear();
            a_12.Clear();
            a_20.Clear();
            a_21.Clear();
            a_22.Clear();
            b_1.Clear();
            b_2.Clear();
            b_0.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dan = true;
                prisv2();
                switch (shag)
                {
                    case 1:
                        proverka1();
                        if (dan)
                        {
                            if (otv)
                            {
                                osh = 0;
                                MessageBox.Show("Верно");
                                shag++;
                                groupBox3.Enabled = false;
                                label11.Enabled = true;
                                textBox1.Enabled = true;

                            }
                            else
                            {
                                osh++;
                                if (osh < 3)
                                    MessageBox.Show("Неверно");
                                else MessageBox.Show("Неверно!\nПодсказка:\nГлавный определитель:\n x1\ty1\tz1\nx2\ty2\tz2\nx3\ty3\tz3\n");
                            }
                        }
                        break;

                    case 2:
                        proverka2();
                        if (dan)
                        {
                            if (otv)
                            {
                                if (d != 0)
                                {
                                    osh = 0;
                                    MessageBox.Show("Верно");
                                    shag++;
                                    textBox2.Text = Convert.ToString(d);
                                    groupBox3.Text = "Найдите определитель матрицы по Х";
                                    groupBox3.Enabled = true;
                                    label11.Enabled = false;
                                    textBox1.Enabled = false;
                                }
                                else
                                {

                                    MessageBox.Show("Определитель равено 0, корней не имеет");
                                }
                            }
                            else 
                            { osh++;
                            if (osh < 3)
                                MessageBox.Show("Неверно");
                            else MessageBox.Show("Подсказка:\nОпределитель матрицы 3-го порядка находится:\na[1][1]*a[2][2]*a[3][3]\n+a[1][2]*a[2][3]*a[3][1]\n+a[1][3]*a[2][1]*a[3][2]\n+(-a[1][3]*a[2][2]*a[3][1])\n+(-a[1][2]*a[2][1]*a[3][3])\n+(-a[1][1]*a[2][3]*a[3][2])");
                            }
                        }
                        
                        break;
                    case 3:
                        proverka3();
                        if (dan)
                        {
                            if (otv)
                            {
                                osh=0;
                                MessageBox.Show("Верно");
                                shag++;
                                groupBox3.Enabled = false;
                                label11.Enabled = true;
                                textBox1.Enabled = true;
                                // label11.Text = "Найдите определитель получившейся матрицы";
                            }
                            else
                            {
                                osh++;
                                if (osh < 3)
                                    MessageBox.Show("Неверно");
                                else MessageBox.Show("Неверно!\nПодсказка:\nОпределитель по Х:\n b1\ty1\tz1\nb2\ty2\tz2\nb3\ty3\tz3\n");
                            }
                        }
                        break;
                    case 4:
                        proverka2();
                        if (dan)
                        {
                            if (otv)
                            {
                                osh = 0;
                                MessageBox.Show("Верно");
                                shag++;
                                textBox3.Text = Convert.ToString(d);
                                groupBox3.Text = "Найдите определитель матрицы по Y";
                                groupBox3.Enabled = true;
                                label11.Enabled = false;
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                osh++;
                                if (osh < 3)
                                    MessageBox.Show("Неверно");
                                else MessageBox.Show("Подсказка:\nОпределитель матрицы 3-го порядка находится:\na[1][1]*a[2][2]*a[3][3]\n+a[1][2]*a[2][3]*a[3][1]\n+a[1][3]*a[2][1]*a[3][2]\n+(-a[1][3]*a[2][2]*a[3][1])\n+(-a[1][2]*a[2][1]*a[3][3])\n+(-a[1][1]*a[2][3]*a[3][2])");
                            }
                        }
                        break;
                    case 5:
                        proverka4();
                        if (dan)
                        {
                            if (otv)
                            {
                                osh = 0;
                                MessageBox.Show("Верно");
                                shag++;
                                groupBox3.Enabled = false;
                                label11.Enabled = true;
                                textBox1.Enabled = true;
                                // label11.Text = "Найдите определитель получившейся матрицы";
                            }
                            else
                            {
                                osh++;
                                if (osh < 3)
                                    MessageBox.Show("Неверно");
                                else MessageBox.Show("Неверно!\nПодсказка:\nОпределитель по Y: \n x1\tb1\tz1\nx2\tb2\tz2\nx3\tb3\tz3\n");
                            }
                        }
                        break;
                    case 6:
                        proverka2();
                        if (dan)
                        {
                            if (otv)
                            {
                                osh = 0;
                                MessageBox.Show("Верно");
                                shag++;
                                textBox4.Text = Convert.ToString(d);
                                groupBox3.Text = "Найдите определитель матрицы по Z";
                                groupBox3.Enabled = true;
                                label11.Enabled = false;
                                textBox1.Enabled = false;
                            }
                            else
                            {
                                osh++;
                                if (osh < 3)
                                    MessageBox.Show("Неверно");
                                else MessageBox.Show("Подсказка:\nОпределитель матрицы 3-го порядка находится:\na[1][1]*a[2][2]*a[3][3]\n+a[1][2]*a[2][3]*a[3][1]\n+a[1][3]*a[2][1]*a[3][2]\n+(-a[1][3]*a[2][2]*a[3][1])\n+(-a[1][2]*a[2][1]*a[3][3])\n+(-a[1][1]*a[2][3]*a[3][2])");
                            }
                        }
                        break;
                    case 7:
                        proverka5();
                        if (dan)
                        {
                            if (otv)
                            {
                                osh = 0;
                                MessageBox.Show("Верно");
                                shag++;
                                groupBox3.Enabled = false;
                                label11.Enabled = true;
                                textBox1.Enabled = true;
                                // label11.Text = "Найдите определитель получившейся матрицы";
                            }
                            else
                            {
                                osh++;
                                if (osh < 3)
                                    MessageBox.Show("Неверно");
                                else MessageBox.Show("Неверно!\nПодсказка:\nОпределитель по Z: \n x1\ty1\tb1\nx2\ty2\tb2\nx3\ty3\tb3\n");
                            }
                        }
                        break;
                    case 8:
                        proverka2();
                        if (dan)
                        {
                            if (otv)
                            {
                                osh = 0;
                                MessageBox.Show("Верно");
                                shag++;
                                textBox5.Text = Convert.ToString(d);
                                groupBox3.Text = "Найдите определитель матрицы по Z";
                                // groupBox3.Enabled = true;
                                label11.Enabled = false;
                                textBox1.Enabled = false;
                                groupBox5.Enabled = true;
                            }
                            else
                            {
                                osh++;
                                if (osh < 3)
                                    MessageBox.Show("Неверно");
                                else MessageBox.Show("Подсказка:\nОпределитель матрицы 3-го порядка находится:\na[1][1]*a[2][2]*a[3][3]\n+a[1][2]*a[2][3]*a[3][1]\n+a[1][3]*a[2][1]*a[3][2]\n+(-a[1][3]*a[2][2]*a[3][1])\n+(-a[1][2]*a[2][1]*a[3][3])\n+(-a[1][1]*a[2][3]*a[3][2])");
                            }
                        }
                        break;
                    case 9:
                        proverka6();
                        if (dan)
                        {
                            if (otv)
                            {
                                osh = 0;
                                MessageBox.Show("Верно");
                                groupBox5.Enabled = false;
                            }
                            else
                            {
                                osh++;
                                if (osh < 3)
                                    MessageBox.Show("Неверно");
                                else MessageBox.Show("Подсказка:\n X = Определитель по Х / Главный определитель\n Y = Определитель по Y / Главный определитель\n Z = Определитель по Z / Главный определитель");
                            }
                        }
                        break;
                }
         
        }

        void proverka1()
        {
            otv = true;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    if (matrix2[i, j] != matrix[i, j])
                        otv = false;
                }
        }
        void proverka2()
        {
            otv = true;
            d = det(matrix2);
            try
            {
                if (d != Convert.ToDouble(textBox1.Text))
                    otv = false; 
            }
            catch
            {
                MessageBox.Show("Введите корректные данные");
                dan = false;
            }
        }
        void proverka3()
        {
            otv = true;
            if (matrix2[0, 0] != matrix[0, 3] ||
                matrix2[0, 1] != matrix[0, 1] ||
                matrix2[0, 2] != matrix[0, 2] ||
                matrix2[1, 0] != matrix[1, 3] ||
                matrix2[1, 1] != matrix[1, 1] ||
                matrix2[1, 2] != matrix[1, 2] ||
                matrix2[2, 0] != matrix[2, 3] ||
                matrix2[2, 1] != matrix[2, 1] ||
                matrix2[2, 2] != matrix[2, 2])
                otv = false;

        }
        void proverka4()
        {
            otv = true;
            if (matrix2[0, 0] != matrix[0, 0] ||
                matrix2[0, 1] != matrix[0, 3] ||
                matrix2[0, 2] != matrix[0, 2] ||
                matrix2[1, 0] != matrix[1, 0] ||
                matrix2[1, 1] != matrix[1, 3] ||
                matrix2[1, 2] != matrix[1, 2] ||
                matrix2[2, 0] != matrix[2, 0] ||
                matrix2[2, 1] != matrix[2, 3] ||
                matrix2[2, 2] != matrix[2, 2])
                otv = false;
        }
        void proverka5()
        {
            otv = true;
            if (matrix2[0, 0] != matrix[0, 0] ||
                matrix2[0, 1] != matrix[0, 1] ||
                matrix2[0, 2] != matrix[0, 3] ||
                matrix2[1, 0] != matrix[1, 0] ||
                matrix2[1, 1] != matrix[1, 1] ||
                matrix2[1, 2] != matrix[1, 3] ||
                matrix2[2, 0] != matrix[2, 0] ||
                matrix2[2, 1] != matrix[2, 1] ||
                matrix2[2, 2] != matrix[2, 3])
                otv = false;
        }
        void proverka6()
        {
            try
            {
                otv = true;
                double x, y, z;
                x = Convert.ToDouble(textBox3.Text) / Convert.ToDouble(textBox2.Text);
                y = Convert.ToDouble(textBox4.Text) / Convert.ToDouble(textBox2.Text);
                z = Convert.ToDouble(textBox5.Text) / Convert.ToDouble(textBox2.Text);
                //textBox6.Text = Convert.ToString(x);
                //textBox7.Text = Convert.ToString(y);
                //textBox8.Text = Convert.ToString(z);
                if (x != Convert.ToDouble(textBox6.Text)) otv = false;
                if (y != Convert.ToDouble(textBox7.Text)) otv = false;
                if (z != Convert.ToDouble(textBox8.Text)) otv = false;
            }
            catch
            {
                MessageBox.Show("Введите корректные данные");
                dan = false;
            }
        }
        void proverka7()
        {
            otv = true;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (matrix3[i, j] != matrix[i, j])
                        otv = false;
                }
        }
        void proverka8()
        {
            
            for (int i = 0; i < 4;i++ )
            {
                matrix4[0, i] = matrix[0, i];
              
               double a=matrix[1, i] ;
               double b = matrix[1, 0];
               double c=matrix[0, 0];
               double d=matrix[0, i];

                matrix4[1, i] = (a *c)- (b*d);

                 a = matrix[2, i];
                 b = matrix[2, 0];
                 c = matrix[0, 0];
                 d = matrix[0, i];
 
                matrix4[2, i] = (a *c)- (b*d);
            }
           

            proverka13();
        }
        void proverka9()
        {
            for (int i = 0; i < 4; i++)
            {
                matrix4[0, i] = matrix[0, i];
                matrix4[1, i] = matrix[1, i];
                matrix4[2, i] = (matrix[2, i] * matrix[1, 1]) -( matrix[2, 1] * matrix[1, i]);
               
            }
            proverka13();
        }
        void proverka10()
        {
            try
            {
                otv = true;
                z = matrix[2, 3] / matrix[2, 2];
                if (z != Convert.ToDouble(textBox8.Text)) otv = false;
            }
            catch
            {
                MessageBox.Show("Введите корректные данные");
                dan = false;
            }
        }
        void proverka11()
        {
            try
            {
                otv = true;
                y = (matrix[1, 3] - (matrix[1, 2] * z)) / matrix[1, 1];
                if (y != Convert.ToDouble(textBox7.Text)) otv = false;
            }
            catch
            {
                MessageBox.Show("Введите корректные данные");
                dan = false;
            }
        }
        void proverka12()
        {
            try
            {
                otv = true;

                x = (matrix[0, 3] - (matrix[0, 2] * z) - (matrix[0, 1] * y)) / matrix[0, 0];
                if (x != Convert.ToDouble(textBox6.Text)) otv = false;
            }
            catch
            {
                MessageBox.Show("Введите корректные данные");
                dan = false;
            }
        }
        void proverka13()
        {
          
            otv = true;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (matrix3[i, j] != matrix4[i, j])
                        otv = false;
                }
        }
        void prisv()
        {
            try
            {
                matrix = new double[3, 4];

                if (x1.Text != "")
                    matrix[0, 0] = Convert.ToDouble(x1.Text);
                else matrix[0, 0] = 0;

                if (x2.Text != "")
                    matrix[1, 0] = Convert.ToDouble(x2.Text);
                else matrix[1, 0] = 0;

                if (x3.Text != "")
                    matrix[2, 0] = Convert.ToDouble(x3.Text);
                else matrix[2, 0] = 0;

                if (y1.Text != "")
                    matrix[0, 1] = Convert.ToDouble(y1.Text);
                else matrix[0, 1] = 0;

                if (y2.Text != "")
                    matrix[1, 1] = Convert.ToDouble(y2.Text);
                else matrix[1, 1] = 0;

                if (y3.Text != "")
                    matrix[2, 1] = Convert.ToDouble(y3.Text);
                else matrix[2, 1] = 0;

                if (z1.Text != "")
                    matrix[0, 2] = Convert.ToDouble(z1.Text);
                else matrix[0, 2] = 0;

                if (z2.Text != "")
                    matrix[1, 2] = Convert.ToDouble(z2.Text);
                else matrix[1, 2] = 0;

                if (z3.Text != "")
                    matrix[2, 2] = Convert.ToDouble(z3.Text);
                else matrix[2, 2] = 0;

                if (b1.Text != "")
                    matrix[0, 3] = Convert.ToDouble(b1.Text);
                else matrix[0, 3] = 0;

                if (b2.Text != "")
                    matrix[1, 3] = Convert.ToDouble(b2.Text);
                else matrix[1, 3] = 0;

                if (b3.Text != "")
                    matrix[2, 3] = Convert.ToDouble(b3.Text);
                else matrix[2, 3] = 0;
            }
            catch
            { MessageBox.Show("Введите корректные данные");
            dan = false;
            }
        }
        void prisv2()
        {
            try
            {
                matrix2 = new double[3, 3];

                if (a00.Text != "")
                    matrix2[0, 0] = Convert.ToDouble(a00.Text);
                else matrix2[0, 0] = 0;

                if (a10.Text != "")
                    matrix2[1, 0] = Convert.ToDouble(a10.Text);
                else matrix2[1, 0] = 0;

                if (a20.Text != "")
                    matrix2[2, 0] = Convert.ToDouble(a20.Text);
                else matrix2[2, 0] = 0;

                if (a01.Text != "")
                    matrix2[0, 1] = Convert.ToDouble(a01.Text);
                else matrix2[0, 1] = 0;

                if (a11.Text != "")
                    matrix2[1, 1] = Convert.ToDouble(a11.Text);
                else matrix2[1, 1] = 0;

                if (a21.Text != "")
                    matrix2[2, 1] = Convert.ToDouble(a21.Text);
                else matrix2[2, 1] = 0;

                if (a02.Text != "")
                    matrix2[0, 2] = Convert.ToDouble(a02.Text);
                else matrix2[0, 2] = 0;

                if (a12.Text != "")
                    matrix2[1, 2] = Convert.ToDouble(a12.Text);
                else matrix2[1, 2] = 0;

                if (a22.Text != "")
                    matrix2[2, 2] = Convert.ToDouble(a22.Text);
                else matrix2[2, 2] = 0;

            }
            catch
            {
                MessageBox.Show("Введите корректные данные");
                dan = false;
            }
        }
        void prisv3()
        {
            try
            {
                matrix3 = new double[3, 4];

                if (c00.Text != "")
                    matrix3[0, 0] = Convert.ToDouble(c00.Text);
                else matrix3[0, 0] = 0;

                if (c10.Text != "")
                    matrix3[1, 0] = Convert.ToDouble(c10.Text);
                else matrix3[1, 0] = 0;

                if (c20.Text != "")
                    matrix3[2, 0] = Convert.ToDouble(c20.Text);
                else matrix3[2, 0] = 0;

                if (c01.Text != "")
                    matrix3[0, 1] = Convert.ToDouble(c01.Text);
                else matrix3[0, 1] = 0;

                if (c11.Text != "")
                    matrix3[1, 1] = Convert.ToDouble(c11.Text);
                else matrix3[1, 1] = 0;

                if (c21.Text != "")
                    matrix3[2, 1] = Convert.ToDouble(c21.Text);
                else matrix3[2, 1] = 0;

                if (c02.Text != "")
                    matrix3[0, 2] = Convert.ToDouble(c02.Text);
                else matrix3[0, 2] = 0;

                if (c12.Text != "")
                    matrix3[1, 2] = Convert.ToDouble(c12.Text);
                else matrix3[1, 2] = 0;

                if (c22.Text != "")
                    matrix3[2, 2] = Convert.ToDouble(c22.Text);
                else matrix3[2, 2] = 0;

                if (e0.Text != "")
                    matrix3[0, 3] = Convert.ToDouble(e0.Text);
                else matrix3[0, 3] = 0;

                if (e1.Text != "")
                    matrix3[1, 3] = Convert.ToDouble(e1.Text);
                else matrix3[1, 3] = 0;

                if (e2.Text != "")
                    matrix3[2, 3] = Convert.ToDouble(e2.Text);
                else matrix3[2, 3] = 0;
            }
            catch
            { MessageBox.Show("Введите корректные данные");
            dan = false;
            }
        }
        void prisv4()
        {
            a_00.Text = c00.Text;
            a_01.Text = c01.Text;
            a_02.Text = c02.Text;
            a_10.Text = c10.Text;
            a_11.Text = c11.Text;
            a_12.Text = c12.Text;
            a_20.Text = c20.Text;
            a_21.Text = c21.Text;
            a_22.Text = c22.Text;
            b_0.Text = e0.Text;
            b_1.Text = e1.Text;
            b_2.Text = e2.Text; 
        }
        void prisv5()
        {
          
           // otv = true;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                {
                    matrix4[i, j] = matrix3[i, j];
                }  
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = matrix4[i, j];
                }
        }
        void prisv6()
        { 
            matrix4 = new double[3, 4];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                {
                    matrix4[i, j] = 1;
                }
        }

        static double det(double[,] B)
        {
            return B[0, 0] * (B[1, 1] * B[2, 2] - B[1, 2] * B[2, 1]) - B[0, 1] * (B[1, 0] * B[2, 2] - B[1, 2] * B[2, 0]) +
            B[0, 2] * (B[1, 0] * B[2, 1] - B[1, 1] * B[2, 0]);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label11.Visible = false;
            textBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            button2.Visible = false;
            button4.Visible = true;
            groupBox6.Visible = true;
            groupBox7.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label11.Visible = true;
            textBox1.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            button4.Visible = false;
            button2.Visible = true;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dan = true;
            prisv6();
            prisv3();
            switch (shag)
            {
                case 1:
                    proverka7();
                    if (dan)
                    {
                        if (otv)
                        {
                            osh = 0;
                            MessageBox.Show("Верно");
                            shag++;
                            prisv4();
                            //prisv5();
                            groupBox6.Text = "Обнулите значения первого столбца, находящиеся под первой строкой";
                        }
                        else
                        {
                            osh++;
                            if (osh < 3)
                                MessageBox.Show("Неверно");
                            else MessageBox.Show("Неверно!\nПодсказка:\nx1\ty1\tz1\tb1\nx2\ty2\tz2\tb2\nx3\ty3\tz3\tb3");
                        }
                    }
                    break;

                case 2:
                    proverka8();
                    if (dan)
                    {
                        if (otv)
                        {
                            osh = 0;
                            MessageBox.Show("Верно");
                            shag++;
                            prisv4();
                            prisv5();
                            groupBox6.Text = "Обнулите значения второго столбца, находящиеся под второй строкой";
                        }
                        else
                        {
                            osh++;
                            if (osh < 3)
                                MessageBox.Show("Неверно");
                            else MessageBox.Show("Неверно!\nПодсказка:\nОбнуление происходит по формуле:\n II*a[1][1]-a[2][1]*I \nIII*a[1][1]-a[3][1]*I");
                        }
                    }
                    break;
                case 3:
                    proverka9();
                    if (dan)
                    {
                        if (otv)
                        {
                            osh = 0;
                            MessageBox.Show("Верно");

                            for (int i = 0; i < 4; i++)
                            {
                                if (matrix3[2, i] == 0) q++;
                            }
                            if (q == 4)
                            {
                                MessageBox.Show("Матрица совместна и неопределена");
                                shag = 1;
                                button4.Enabled = false;
                                groupBox6.Enabled = false;
                            }
                            else
                            {
                                if (q == 3)
                                {
                                    MessageBox.Show("Матрица не совместна");
                                    shag = 1;
                                    button4.Enabled = false;
                                    groupBox6.Enabled = false;
                                }
                                else
                                {
                                    shag++;
                                    prisv4();
                                    prisv5();
                                    groupBox6.Enabled = false;
                                    groupBox5.Enabled = true;
                                    groupBox5.Text = "Введите Z";
                                }
                            }

                        }
                        else
                        {
                            osh++;
                            if (osh < 3)
                                MessageBox.Show("Неверно");
                            else MessageBox.Show("Неверно!\nПодсказка:\nОбнуление происходит по формуле: \nIII*a[2][2]-a[3][1]*II");
                        }
                    }
                    break;
                case 4:
                    proverka10();
                    if (dan)
                    {
                        if (otv)
                        {
                            osh = 0;
                            MessageBox.Show("Верно");
                            shag++;
                            prisv4();
                            prisv5();
                            groupBox5.Text = "Введите Y";
                            textBox8.Enabled = false;
                        }
                        else
                        {
                            osh++;
                            if (osh < 3)
                                MessageBox.Show("Неверно");
                            else MessageBox.Show("Неверно!\nПодсказка:\n z=a[3][4]/a[3][3]");
                        }
                    }
                    break;
                case 5:
                    proverka11();
                    if (dan)
                    {
                        if (otv)
                        {
                            osh = 0;
                            MessageBox.Show("Верно");
                            shag++;
                            prisv4();
                            prisv5();
                            groupBox5.Text = "Введите X";
                            textBox8.Enabled = false;
                            textBox7.Enabled = false;
                        }
                        else
                        {
                            osh++;
                            if (osh < 3)
                                MessageBox.Show("Неверно");
                            else MessageBox.Show("Неверно!\nПодсказка:\n y=(a[2]4[]-(a[2][3]*z))/a[2][2]");
                        }
                    }
                    break;
                case 6:
                    
                    proverka12();
                    if (dan)
                    {
                        if (otv)
                        {
                            osh = 0;
                            MessageBox.Show("Верно");
                            shag++;
                            prisv4();
                            prisv5();
                            button4.Enabled = false;
                            shag = 1;
                            textBox6.Enabled = false;
                        }
                        else
                        {
                            osh++;
                            if (osh < 3)
                                MessageBox.Show("Неверно");
                            else MessageBox.Show("Неверно!\nПодсказка:\n z=(a[1][4]-(a[1][3]*z)-(a[1][2]*y))/a[1][1]");
                        }
                    }
                    break;

            }
        }

        private void b1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            _test.Visible = true;
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _test.Visible = true;
            this.Dispose();
        }
    }
}
