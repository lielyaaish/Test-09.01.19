using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.9.0", "File Explorer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const int MAX = 10;
            Random r = new Random();
            int[] array = new int[MAX];

            for (int i = 1; i < MAX; i++)
            {
                array[i] = r.Next(11);
                label1.Text = array[i].ToString();
            }
            for (int i = 1; i < MAX; i++)
            {
                array[i] = r.Next(11);
                label2.Text = array[i].ToString();
            }
            for (int i = 1; i < MAX; i++)
            {
                array[i] = r.Next(11);
                label3.Text = array[i].ToString();
            }
            for (int i = 1; i < MAX; i++)
            {
                array[i] = r.Next(11);
                label4.Text = array[i].ToString();
            }
            for (int i = 1; i < MAX; i++)
            {
                array[i] = r.Next(11);
                label5.Text = array[i].ToString();
            }
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear();

        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            if (label1.Text == textBox1.Text && label2.Text == textBox2.Text 
                && label3.Text == textBox3.Text && label4.Text == textBox4.Text && label5.Text == textBox5.Text)
            {
                MessageBox.Show("You Won!", "Great Job", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear();
                int score = 0;
                score++;
                ScoreListBox.Text = score.ToString(); // Didn't work for me
            }
            else
            {
                MessageBox.Show("Error", "Try Again", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear();
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const int MAX = 10;
            Random r = new Random();
            int[] array = new int[MAX];

            for (int i = 1; i < MAX; i++)
            {
                array[i] = r.Next(11);
                label1.Text = array[i].ToString();
            }
            for (int i = 1; i < MAX; i++)
            {
                array[i] = r.Next(11);
                label2.Text = array[i].ToString();
            }
            for (int i = 1; i < MAX; i++)
            {
                array[i] = r.Next(11);
                label3.Text = array[i].ToString();
            }
            for (int i = 1; i < MAX; i++)
            {
                array[i] = r.Next(11);
                label4.Text = array[i].ToString();
            }
            for (int i = 1; i < MAX; i++)
            {
                array[i] = r.Next(11);
                label5.Text = array[i].ToString();
            }
        }
    }
}
