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
            Rectangle destrect = new Rectangle(10, 10, bmb.Width , bmb.Height );
            Rectangle srcrect = new Rectangle(0, 0, bmb.Width/2 , bmb.Height/2);
            this.SetClientSizeCore(bmb.Width + 20, bmb.Height + 20);
            g.DrawImage(bmb, destrect,srcrect, GraphicsUnit.Pixel);
            g.Dispose();
        }

        
    }
}
