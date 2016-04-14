using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PwsgWinFormsLab2
{
    class Shape
    {
        public Shape(Point start,Point end, int type)
        {
            this.start = start;
            this.type = type;
            this.end = end;
        }
        public Point start;
        public Point end;
        //0 line 1 rect 2 elipse
        public int type;
    };
    public partial class Form1 : Form
    {
        private int selectedType;
        private bool startPaint;
        private System.Drawing.Color curColor = System.Drawing.Color.Yellow;
        private List<Shape> shapePositions = new List<Shape>();

        private int currentIndex;
        Graphics g;
        Pen p;

        public Form1()
        {
            InitializeComponent();
            selectedType = 0;
            currentIndex = 0;
            startPaint = false;
            g = this.splitContainer1.Panel1.CreateGraphics();
            p = new Pen(curColor, 5);
        }

        private void drawAll()
        {
            foreach (Shape shape in shapePositions)
            {
                if (shape.type == 0)
                    drawLine(shape);
                else if (shape.type == 1)
                    drawRect(shape);
                else
                    drawElipse(shape);
            }
        }
        private void drawLine(Shape pos)
        {

            g.DrawLine(p, pos.start, pos.end);
        }
        private void drawRect(Shape pos)
        {
            int width;
            int height;
            width = pos.end.X - pos.start.X;
            height = pos.end.Y - pos.start.Y;
            g.DrawRectangle(p, pos.start.X, pos.start.Y, width, height);
        }
        private void drawElipse(Shape pos)
        {
            int width;
            int height;
            width = pos.end.X - pos.start.X;
            height = pos.end.Y - pos.start.Y;
            g.DrawEllipse(p, pos.start.X, pos.start.Y, width, height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void liniaButton_Click(object sender, EventArgs e)
        {
            selectedType = 0;
        }

        private void prostokatButton_Click(object sender, EventArgs e)
        {
            selectedType = 1;
        }

        private void elipsaButton_Click(object sender, EventArgs e)
        {
            selectedType = 2;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint)
            {
                shapePositions[currentIndex].end = new Point(e.X, e.Y);
                this.splitContainer1.Panel1.Invalidate();  
            }
            drawAll();
        }

        private void splitContainer1_Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            startPaint = true;
            curColor = Color.Yellow;
            p.Color = curColor;
            shapePositions.Add(new Shape(new Point(e.X, e.Y), new Point(e.X,e.Y), selectedType));
        }

        private void splitContainer1_Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;
            currentIndex++;
            curColor = Color.Green;
            p.Color = curColor;
            //this.splitContainer1.Panel1.Invalidate();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
