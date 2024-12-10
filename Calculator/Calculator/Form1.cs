﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            textBox1.Text += currentButton.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DataTable d = new DataTable();
            textBox1.Text = d.Compute(textBox1.Text, " ").ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string str = "";
            for(int i = 0; i < textBox1.Text.Length - 1; i++)
            {
                str += textBox1.Text[i];
            }
            textBox1.Text = str;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

       
    }
}
