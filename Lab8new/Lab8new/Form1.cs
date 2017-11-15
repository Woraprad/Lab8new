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
            Pen mypen = new Pen(Color.Black, 2);
            g.DrawRectangle(mypen, 10, 10, 100, 100);
            mypen.DashStyle = DashStyle.Dash;
            mypen.Width = 4;
            mypen.Color = Color.Pink;
            g.DrawEllipse(mypen, 10, 10, 200, 200);
            mypen.Dispose();

            
        }
    }
}
