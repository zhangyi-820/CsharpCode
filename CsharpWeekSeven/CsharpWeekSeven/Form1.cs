using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpWeekSeven
{
    public partial class Form1 : Form
    {

        private Graphics graphics;
        private DrawTree drawTree;

        public Form1()
        {
            InitializeComponent();
            drawTree = new DrawTree();
        }

        private void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double temp = Double.Parse(this.nTextBox.Text);
                if (temp > 0)
                {
                    drawTree.Length = temp;
                }
                else
                {
                    MessageBox.Show("请输入大于0的长度", "Error", MessageBoxButtons.OKCancel);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("输入类型错误，请重试", "Error", MessageBoxButtons.OKCancel);
            }
        }

        private void thLeftTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = Int32.Parse(this.thLeftTextBox.Text);
                if (temp >= 0 && temp <= 90)
                {
                    drawTree.ThLeft = temp * Math.PI / 180;
                }
                else
                {
                    MessageBox.Show("请输入0-90之间的角度", "Error", MessageBoxButtons.OKCancel);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("输入类型错误，请重试", "Error", MessageBoxButtons.OKCancel);
            }
        }

        private void thRightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = Int32.Parse(this.thRightTextBox.Text);
                if (temp > 0)
                {
                    drawTree.ThRight = temp * Math.PI / 180;
                }
                else
                {
                    MessageBox.Show("请输入0-90之间的角度", "Error", MessageBoxButtons.OKCancel);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("输入类型错误，请重试", "Error", MessageBoxButtons.OKCancel);
            }
        }

        private void creataButton_Click_1(object sender, EventArgs e)
        {
            graphics = PicturePanel.CreateGraphics();
            graphics.Clear(Color.White);
            drawTree.drawCayleyTree(10, 180, 300, 100, -Math.PI / 2, this.graphics);
        }

        private void controlPanel_Paint(object sender, PaintEventArgs e)
        {
            return;
        }

        private void PicturePaint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = Int32.Parse(this.lengthTextBox.Text);
                if (temp > 0)
                {
                    drawTree.N = temp;
                }
                else
                {
                    MessageBox.Show("请输入大于0的长度", "Error", MessageBoxButtons.OKCancel);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("输入类型错误，请重试", "Error", MessageBoxButtons.OKCancel);
            }
        }

        private void LineColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pen pen;
            string temp = this.LineColorComboBox.Text;
            switch (temp)
            {
                case "RED":
                    pen = new Pen(Color.Red, 2);
                    break;
                case "BLUE":
                    pen = new Pen(Color.Blue, 2);
                    break;
                case "BLACK":
                    pen = new Pen(Color.Black, 2);
                    break;
                case "PINK":
                    pen = new Pen(Color.Pink, 2);
                    break;
                case "YELLOW":
                    pen = new Pen(Color.Yellow, 2);
                    break;
                case "GREEN":
                    pen = new Pen(Color.Green, 2);
                    break;
                default:
                    pen = new Pen(Color.Red, 2);
                    break;
            }
            this.drawTree.Pen = pen;
        }

        private void nTrackBar_Scroll(object sender, EventArgs e)
        {
            this.nTextBox.Text = this.nTrackBar.Value.ToString();
            this.drawTree.N = this.nTrackBar.Value;
        }

        private void lengthTrackBar_Scroll(object sender, EventArgs e)
        {
            this.lengthTextBox.Text = this.lengthTrackBar.Value.ToString();
            this.drawTree.Length = this.lengthTrackBar.Value;
        }

        private void perLeftTrackBar_Scroll(object sender, EventArgs e)
        {
            double temp = this.perLeftTrackBar.Value / 100.0;
            this.perLeftTextBox.Text = string.Format("{0:F}", temp);
            this.drawTree.PerLeft = this.perLeftTrackBar.Value;
        }

        private void perRightTrackBar_Scroll(object sender, EventArgs e)
        {
            double temp = this.perRightTrackBar.Value / 100.0;
            this.perRightTextBox.Text =string.Format("{0:F}",temp);
            this.drawTree.PerRight = this.perRightTrackBar.Value;
        }

        private void thLeftTrackBar_Scroll(object sender, EventArgs e)
        {
            this.thLeftTextBox.Text = this.thLeftTrackBar.Value.ToString();
            this.drawTree.ThLeft = this.thLeftTrackBar.Value;
        }

        private void thRightTrackBar_Scroll(object sender, EventArgs e)
        {
            this.thRightTextBox.Text = this.thRightTrackBar.Value.ToString();
            this.drawTree.ThRight = this.thRightTrackBar.Value;
        }

        private void perRightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double temp = Double.Parse(this.perRightTextBox.Text);
                string a= this.perRightTextBox.Text;
                if ((temp >= 0 && temp < 1)||a.Contains("."))
                {
                    drawTree.PerRight = temp;
                }
                else
                {
                    MessageBox.Show("请输入0-1之间的比例", "Error", MessageBoxButtons.OKCancel);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("输入类型错误，请重试", "Error", MessageBoxButtons.OKCancel);
            }
        }

        private void perLeftTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double temp = Double.Parse(this.perLeftTextBox.Text);
                string a = this.perRightTextBox.Text;
                if ((temp >= 0 && temp < 1)||a.Contains("."))
                {
                    drawTree.PerLeft = temp;
                }
                else
                {
                    MessageBox.Show("请输入0-1之间的比例", "Error", MessageBoxButtons.OKCancel);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("输入类型错误，请重试", "Error", MessageBoxButtons.OKCancel);
            }
        }
    }
}
