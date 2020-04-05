using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpWeekSeven
{
    public class DrawTree
    {
        private int n;
        private double length,perLeft, perRight, thLeft, thRight;
        private Pen pen;

        public int N
        {
            get
            {
                return n;
            }
            set
            {
                this.n = value;
                //this.n = 10;
            }
        }
        public double Length
        {
            get
            {
                return this.length;
            }
            set
            {
                this.length = value;
                //this.length = 100;
            }
        }
        public double PerLeft
        {
            get
            {
                return perLeft;
            }
            set
            {
                this.perLeft = value;
                //this.perLeft = 0.6;
            }
        }
        public double PerRight
        {
            get
            {
                return this.perRight;
            }
            set
            {
                this.perRight = value;
                //perRight = 0.7;
            }
        }

        public double ThLeft
        {
            get
            {
                return this.thLeft;
            }
            set
            {
                this.thLeft = value;
                //this.thLeft = 30 * Math.PI / 180;
            }
        }

        public double ThRight
        {
            get
            {
                return thRight;
            }
            set
            {
                this.thRight = value;
                //this.thRight = 20 * Math.PI / 180;
            }
        }
       
        public Pen Pen
        {
            set
            {
                this.pen = value;
            }
        }

        //绘制图像
        public void drawCayleyTree(int n, double x0, double y0, double length, double th, Graphics graphics)
        {
            if (n == 0)
            {
                return;
            }
            double x1 = x0 + length * Math.Cos(th);
            double y1 = y0 + length * Math.Sin(th);

            this.drawLine(x0, y0, x1, y1, graphics);
            drawCayleyTree(n - 1, x1, y1, this.perLeft * length, th + thLeft, graphics);
            drawCayleyTree(n - 1, x1, y1, this.perRight * length, th - thRight, graphics);
        }

        //绘制直线
        private void drawLine(double x0, double y0, double x1, double y1, Graphics graphics)
        {
            if (x0 < 1189 && x1 < 1189&&y0<511&&y1<511)
            {
                graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
            }
        }
    }
}
