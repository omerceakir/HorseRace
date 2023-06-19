using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atyarisiUyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int at1 = 0, at2 = 0, at3 = 0, at4 = 0, at5 = 0, bitis = 0;
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            at1 = pictureBox1.Left;
            at2 = pictureBox2.Left;
            at3 = pictureBox3.Left;
            at4 = pictureBox4.Left;
            at5 = pictureBox5.Left;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Visible = false;
        }

        private void dur()
        {
            timer1.Enabled = false;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
        }

        private void reset()
        {
            label7.Text = "........";
            pictureBox1.Left = at1;
            pictureBox2.Left = at2;
            pictureBox3.Left = at3;
            pictureBox4.Left = at4;
            pictureBox5.Left = at5;
            pictureBox6.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bitis = label1.Left;
            if (pictureBox1.Right>=bitis)
            {
                label7.Text = "1.At Kazandi";
                dur();
            }
            if (pictureBox2.Right>=bitis)
            {
                label7.Text = "2.At Kazandi";
                dur();
            }
            if (pictureBox3.Right >= bitis)
            {
                label7.Text = "3.At Kazandi";
                dur();
            }
            if (pictureBox4.Right >= bitis)
            {
                label7.Text = "4.At Kazandi";
                dur();
            }
            if (pictureBox5.Right >= bitis)
            {
                label7.Text = "5.At Kazandi";
                dur();
            }
            else
            {
                pictureBox1.Left += rnd.Next(2, 15);
                pictureBox2.Left += rnd.Next(2, 15);
                pictureBox3.Left += rnd.Next(2, 15);
                pictureBox4.Left += rnd.Next(2, 15);
                pictureBox5.Left += rnd.Next(2, 15);
            }
        }


    }
}
