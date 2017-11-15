using System;
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
            Bitmap bmb = new Bitmap("D:\\Capture.PNG");
            this.SetClientSizeCore(bmb.Width + 20, bmb.Height + 20);
            g.DrawImage(bmb, 10, 10);
            g.Dispose();
        }

        
    }
}
