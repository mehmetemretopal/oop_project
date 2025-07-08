/*
 * NAME SURNAME : MEHMET EMRE TOPAL
 * NUMBER : B221202075
 * HONOR CODE
 */ 
using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection.Metadata;

namespace oopdeneme
{
    public partial class Form1 : Form
    {
        private Point2D point;
        private Polygon polygon;
        private RGBColor color;
       


        public Form1()
        {
            InitializeComponent();
            point = new Point2D();
            polygon = new Polygon();
            color = new RGBColor();

        }
        // Draw the polygon
        private void Draw_Click(object sender, EventArgs e)
        {
            Random rn = new Random();
            var (X, Y) = Point2D.printCoordinate();
            xrotate.Text = Point2D.X.ToString();
            yrotate.Text = Point2D.Y.ToString();
            Point2D.calculatePolarCoordinates();
            Point2D.calculateCartesianCoordinates();
            polygon.Center(X, Y);
            Polygon.calculateEdgeCoordinates();
            edge.Text = Polygon.numberOfEdges.ToString();
            length.Text = Polygon.length.ToString();


            double startAngle = rn.Next(0, 360);
            angel.Text = startAngle.ToString();
            double angleStep = 2 * Math.PI / Polygon.numberOfEdges;

            // Calculate the coordinates of each vertex

            List<PointF> vertices = new List<PointF>();

            for (int i = 0; i < Polygon.numberOfEdges; i++)
            {
                double currentAngle = startAngle + (i * angleStep);
                float x_coo_edge = (float)(Polygon.r * Math.Cos(currentAngle) + X);
                float y_coo_edge = (float)(Polygon.r * Math.Sin(currentAngle) + Y);
                vertices.Add(new PointF(x_coo_edge, y_coo_edge));
            }

            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);

            Pen pen = new Pen(Color.Red, 2);

            for (int i = 0; i < vertices.Count; i++)
            {
                PointF startPoint = vertices[i];
                PointF endPoint = vertices[(i + 1) % vertices.Count];
                g.DrawLine(pen, startPoint, endPoint);
            }

            listBox1.Items.Clear();
            foreach (var vertex in vertices)
            {
                listBox1.Items.Add($"Vertex: ({vertex.X:F2}, {vertex.Y:F2})");
            }

        }
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {

            color.red = trackBar1.Value;
            Pen pen_k = new Pen(Color.Red, color.red);
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor); 


            List<PointF> vertices = new List<PointF>();
            double angleStep = 2 * Math.PI / Polygon.numberOfEdges;
            for (int i = 0; i < Polygon.numberOfEdges; i++)
            {
                double currentAngle = i * angleStep;
                float x_coo_edge = (float)(Polygon.r * Math.Cos(currentAngle) + Point2D.X);
                float y_coo_edge = (float)(Polygon.r * Math.Sin(currentAngle) + Point2D.Y);
                vertices.Add(new PointF(x_coo_edge, y_coo_edge));
            }

            // Draw the polygon
            for (int i = 0; i < vertices.Count; i++)
            {
                PointF startPoint = vertices[i];
                PointF endPoint = vertices[(i + 1) % vertices.Count];
                g.DrawLine(pen_k, startPoint, endPoint);
            }

            g.Dispose();
        }
        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            color.green = trackBar3.Value;
            Pen pen_k = new Pen(Color.Green, color.green);
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor); 


            List<PointF> vertices = new List<PointF>();
            double angleStep = 2 * Math.PI / Polygon.numberOfEdges;
            for (int i = 0; i < Polygon.numberOfEdges; i++)
            {
                double currentAngle = i * angleStep;
                float x_coo_edge = (float)(Polygon.r * Math.Cos(currentAngle) + Point2D.X);
                float y_coo_edge = (float)(Polygon.r * Math.Sin(currentAngle) + Point2D.Y);
                vertices.Add(new PointF(x_coo_edge, y_coo_edge));
            }

            // Draw the polygon
            for (int i = 0; i < vertices.Count; i++)
            {
                PointF startPoint = vertices[i];
                PointF endPoint = vertices[(i + 1) % vertices.Count];
                g.DrawLine(pen_k, startPoint, endPoint);
            }

            g.Dispose();
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            color.blue = trackBar2.Value;
            Pen pen_k = new Pen(Color.Blue, color.blue);
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor); //clean previous drawing


            List<PointF> vertices = new List<PointF>();
            double angleStep = 2 * Math.PI / Polygon.numberOfEdges;
            for (int i = 0; i < Polygon.numberOfEdges; i++)
            {
                double currentAngle = i * angleStep;
                float x_coo_edge = (float)(Polygon.r * Math.Cos(currentAngle) + Point2D.X);
                float y_coo_edge = (float)(Polygon.r * Math.Sin(currentAngle) + Point2D.Y);
                vertices.Add(new PointF(x_coo_edge, y_coo_edge));
            }

            // Draw the polygon
            for (int i = 0; i < vertices.Count; i++)
            {
                PointF startPoint = vertices[i];
                PointF endPoint = vertices[(i + 1) % vertices.Count];
                g.DrawLine(pen_k, startPoint, endPoint);
            }

            g.Dispose();
        }
        private void rotate_Click(object sender, EventArgs e)
        {
            // Get X and Y coordinates from Point2D class
            int X = Point2D.X;
            int Y = Point2D.Y;

            Random random = new Random();
            int angle = random.Next(1, 360);
            angel.Text = angle.ToString();

            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor); // Clear previous drawing

            // To rotate a polygon smoothly:

            double angleStep = 2 * Math.PI / Polygon.numberOfEdges;
            List<PointF> vertices = new List<PointF>();

            for (int i = 0; i < Polygon.numberOfEdges; i++)
            {
                // Açýyý radyana çevir ve her kenar için hesapla
                double currentAngle = (i * angleStep) + (angle * Math.PI / 180); // Burada açýyý radyana çeviriyor ve ekliyoruz
                float x_coo_edge = (float)(Polygon.r * Math.Cos(currentAngle) + X);
                float y_coo_edge = (float)(Polygon.r * Math.Sin(currentAngle) + Y);
                vertices.Add(new PointF(x_coo_edge, y_coo_edge));
            }

            Pen pen = new Pen(Color.Green, 2);

            for (int i = 0; i < vertices.Count; i++)
            {
                PointF startPoint = vertices[i];
                PointF endPoint = vertices[(i + 1) % vertices.Count];
                g.DrawLine(pen, startPoint, endPoint);
            }
            //rotate reverse clock size
            if (checkBox1.Checked)
            {
                angle = -angle;
            }

            // ListBox updated
            listBox1.Items.Clear();
            foreach (var vertex in vertices)
            {
                listBox1.Items.Add($"Vertex: ({vertex.X:F2}, {vertex.Y:F2})");
            }
        }
        //reset all methods
        private void reset_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            pictureBox1.Image = null;
            xrotate.Text = "";
            yrotate.Text = "";
            edge.Text = "";
            angel.Text = "";
            length.Text = "";
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            g.Dispose();
        }
    }
}
