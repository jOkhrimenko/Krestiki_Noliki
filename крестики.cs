using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        bool xTurn = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e) //переименовать все на батонклик
        {
            Button senderB = (Button)sender;
            if (xTurn) //true = 1;
            {
                senderB.Text = "X";
            }
            else
            {
                senderB.Text = "O";
            }
            xTurn = !xTurn; //true = false
            senderB.Enabled = false;//блокирует кнопку
            checkWin(senderB);
            checkDraw();
        }
        void checkWin(Button pressedButton) // сами пишем функцию
        {
            if (but1.Text == but2.Text && but2.Text == but3.Text && but2.Enabled == false)
            {
                MessageBox.Show("Win " + pressedButton.Text);
                Application.Restart();
            }
            if (but4.Text == but5.Text && but5.Text == but6.Text && but5.Enabled == false)
            {
                MessageBox.Show("Win " + pressedButton.Text);
                Application.Restart();
            }
            if (but7.Text == but8.Text && but8.Text == but9.Text && but8.Enabled == false)
            {
                MessageBox.Show("Win " + pressedButton.Text);
                Application.Restart();
            }
            if (but1.Text == but4.Text && but4.Text == but7.Text && but4.Enabled == false)
            {
                MessageBox.Show("Win " + pressedButton.Text);
                Application.Restart();
            }
            if (but2.Text == but5.Text && but5.Text == but8.Text && but5.Enabled == false)
            {
                MessageBox.Show("Win " + pressedButton.Text);
                Application.Restart();
            }
            if (but3.Text == but6.Text && but6.Text == but9.Text && but6.Enabled == false)
            {
                MessageBox.Show("Win " + pressedButton.Text);
                Application.Restart();
            }
            if (but1.Text == but5.Text && but5.Text == but9.Text && but5.Enabled == false)
            {
                MessageBox.Show("Win " + pressedButton.Text);
                Application.Restart();
            }
            if (but3.Text == but5.Text && but5.Text == but7.Text && but5.Enabled == false)
            {
                MessageBox.Show("Win " + pressedButton.Text);
                Application.Restart();
            }

        }
        void checkDraw() //сами делаем 
        {
            if (but1.Enabled == false &&
                but2.Enabled == false &&
                but3.Enabled == false &&
                but4.Enabled == false &&
                but5.Enabled == false &&
                but6.Enabled == false &&
                but7.Enabled == false &&
                but8.Enabled == false &&
                but9.Enabled == false)
            {
                MessageBox.Show("Draw!");
                Application.Restart();
            }
        }
            private void сначалаToolStripMenuItem_Click(object sender, EventArgs e) //нажимаем сначала
        {
            Application.Restart();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e) //выбор х
        {
            xTurn = true;
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e) // выбор 0
        {
            xTurn = !true;
        }
    }
    }

