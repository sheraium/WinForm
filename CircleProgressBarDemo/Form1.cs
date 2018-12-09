﻿using System;
using System.Threading;
using System.Windows.Forms;

namespace CircleProgressBarDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(5);
                circularProgressBar1.Value = i;
                circularProgressBar1.Update();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
        }
    }
}