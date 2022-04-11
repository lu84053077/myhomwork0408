using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operation9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { int c = 1;
            for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)

            {
                for (int j = 0; j < c; j++)
                {
                    richTextBox1.Text += "*";


                }
                c++;
                richTextBox1.Text += "\n";
            }
            }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 100;
            int c = 0;
            List<int> a = new List<int>();
            while (i > 1)
            {


                c++;
                a.Add(i % 2);

                i = i / 2;
            }
            a.Add(i);
           

            for (int j = c; j >=0; j--)
            {
                richTextBox1.Text += a[j].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int i = 0; i < 6; i++) {

                richTextBox1.Text += rnd.Next(49);
                richTextBox1.Text += "  ";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String[] names = { "aaa", "bbb", "ccc", "Mary", "Tom" };
            string c = "";
            int a = 0, b = 0;
            for (int i = 0; i < 5; i++)
            {
                if (i < 4)
                {

                    c += names[i] + " , ";
                }

                else
                {
                    c += names[i];
                }

            }
            for (int i = 0; i < 5; i++)
            {

                if (a < names[i].Length)
                {
                    a = names[i].Length;
                    b = i;
                }
            }


            MessageBox.Show("neame :(" + c + ")" + "\n最長名子為 : " + names[b]);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] names = { 44, 66, 99, 100, 78 };
            string c = "";
            int a = 0, b = 0;
            for (int i = 0; i < 5; i++)
            {
                if (i < 4)
                {

                    c += names[i] + " , ";
                }

                else
                {
                    c += names[i];
                }

            }

            for (int i = 0; i < 5; i++)
            {


                if (names[i] % 2 == 1)
                    a++;
                else
                    b++;

            }
            MessageBox.Show("name : (" + c + ")" + "\n 奇數有 : " + a + "\n偶數有 : " + b);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String[] names = { "aaa", "bbb", "ccc", "Mary", "Tom" };
            string c = "";
            int z = 0;
            for (int i = 0; i < 5; i++)
            {
                if (i < 4)
                {

                    c += names[i] + " , ";
                }

                else
                {
                    c += names[i];
                }

            }


            for (int i = 0; i < 5; i++)
            {

                if (names[i].Contains("C") || names[i].Contains("c"))
                {
                    z++;
                }

            }

            MessageBox.Show("neame :(" + c + ")" + "\n名字有 “C” or “c” 字樣有 : " + z + "個");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int[] names = { 44, 66, 99, 100, 78 };
            string c = "";

            for (int i = 0; i < 5; i++)
            {
                if (i < 4)
                {

                    c += names[i] + " , ";
                }

                else
                {
                    c += names[i];
                }

            }
            MessageBox.Show("name : (" + c + ")" + "\n最高分 :" + names.Max() + "\n最低分 : " + names.Min());
        }
    }
}
