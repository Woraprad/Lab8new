﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Lab8new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen bluepen = new Pen(Color.Blue, 2);
            g.DrawRectangle(bluepen, 10, 10, 100, 100);
            bluepen.Dispose();

            Pen somepen = new Pen(Color.FromArgb(225, 120, 200));
            g.DrawEllipse(somepen, 20, 20, 200, 200);
            somepen.Dispose();
        }
    }
}