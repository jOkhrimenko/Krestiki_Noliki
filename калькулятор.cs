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
        }

        private void button7_Click(object sender, EventArgs e)    //(0)
        {
            textBox1.Text += (sender as Button).Text; //чтобы ввыводились цыфры при нажатие ( начинаем с нуля)

        }

        double a = 0, b = 0, c = 0;
        char znak = '+';

        private void button11_Click(object sender, EventArgs e) // (+)
        {
            a = Convert.ToDouble(textBox1.Text); //(потом переводим ко всем командам)
            znak = (sender as Button).Text[0];
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)   //(=)
        {
            b = Convert.ToDouble(textBox1.Text); 
            switch (znak)
            {
                case '+': c = a + b;
                    break;
                case '-': c = a - b;
                    break;
                    case '*': c = a * b;
                    break;
                case '/': c = a / b;
                    break;
            }
            textBox1.Text = c.ToString();
        }

        private void button17_Click(object sender, EventArgs e) //( кнопка С)
        {
            textBox1.Clear();

        }

        private void button18_Click(object sender, EventArgs e) //(+\-)
        {
            if (textBox1.Text != "")
                if (textBox1.Text[0] == '-')
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                else textBox1.Text = '-' + textBox1.Text;
        }

        private void button19_Click(object sender, EventArgs e) //(<-)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

      
    }
}
