using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolarSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeTimer()
        {
          //  timer1.Interval = 30;
        }

        SolidBrush brushSun = new SolidBrush(Color.Yellow);
        SolidBrush brushPlanet = new SolidBrush(Color.PowderBlue);
        Pen pen = new Pen(Color.Black, 2);

        Planet Planet = new Planet(335, 257, 250,250,2000,0.0f,0.1f,4.8f,0,0);
            
        void Drawing(float bodyX,float bodyY)
        {
            Bitmap myBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            float W = pictureBox1.Width/2;
            float H = pictureBox1.Height/2;
           //DoubleBuffered = true;
            Graphics g = Graphics.FromImage(myBitmap);
            pictureBox1.Image = myBitmap;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            g.DrawEllipse(pen, 335, 257, 50, 50); //солнце
            g.FillEllipse(brushSun, 335, 257, 50, 50);

            g.DrawEllipse(pen, bodyX, bodyY, 10, 10);   //планета
            g.FillEllipse(brushPlanet, bodyX, bodyY, 10, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
             timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float bX, bY;
            Planet.BodyPosCalc(out bX, out bY);
            Drawing(bX,bY);
        }
    }
}
