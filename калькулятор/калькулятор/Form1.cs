using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox1.Text.Length != 0)
                {
                    button23.Enabled = true;
                    button8.Enabled = true;
                    button12.Enabled = true;
                    button16.Enabled = true;
                    button20.Enabled = true;
                    button21.Enabled = true;
                    button24.Enabled = true;
                }
                else
                {
                    button23.Enabled = false;
                    button8.Enabled = false;
                    button12.Enabled = false;
                    button16.Enabled = false;
                    button20.Enabled = false;
                    button21.Enabled = false;
                    button24.Enabled = false;
                }
            }
        }
        float a, b, c;
        bool znak = true;
        int count;
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            count = 0;
        }

        private void button23_Click(object sender, EventArgs e)// запятая
        {
            if (textBox1.Text.IndexOf(',') == -1)
            {
                textBox1.Text += ",";
            }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            textBox2.Text = a.ToString() + "+";
            znak = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            textBox2.Text = a.ToString() + "-";
            znak = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            textBox2.Text = a.ToString() + "*";
            znak = true;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            textBox2.Text = a.ToString() + "/";
            znak = true;
        }
        private void button24_Click(object sender, EventArgs e)
        {
            calculate();
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void calculate()
        {
            switch(count)
            {
                case 1:
                    b = float.Parse(textBox1.Text);
                    c = a + b;
                    textBox1.Text = c.ToString();
                    count = 0;
                    break;
                case 2:
                    b = float.Parse(textBox1.Text);
                    c = a - b;
                    textBox1.Text = c.ToString();
                    count = 0;
                    break;
                case 3:
                    b = float.Parse(textBox1.Text);
                    c = a * b;
                    textBox1.Text = c.ToString();
                    count = 0;
                    break;
                case 4:
                    b = float.Parse(textBox1.Text);
                    if (b==0)
                    {
                        MessageBox.Show("На ноль делить нельзя");
                        textBox1.Clear();
                        textBox2.Clear();
                        count = 0;
                        break;
                    }
                    else
                    { 
                        c = a / b;
                        textBox1.Text = c.ToString();
                        count = 0;
                        break;
                    }
                default:
                    break;
            }

        }
    }
}
