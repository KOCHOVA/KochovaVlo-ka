using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KochovaVlocka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        // Coordinates of the points in the initiator.
        private List<PointF> Initiator;

        // Angles and distances for the generator.
        private float ScaleFactor;
        private List<float> GeneratorDTheta;

        private void btnSpusti_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            // Define an initiator and generator.
            Initiator = new List<PointF>();
            float height = 0.75f * (Math.Min(
                picCanvas.ClientSize.Width,
                picCanvas.ClientSize.Height) - 20);
            float width = (float)(height / Math.Sqrt(3.0) * 2);
            float y3 = picCanvas.ClientSize.Height - 10;
            float y1 = y3 - height;
            float x3 = picCanvas.ClientSize.Height / 2;
            float x1 = x3 - width / 2;
            float x2 = x1 + width;
            Initiator.Add(new PointF(x1, y1));
            Initiator.Add(new PointF(x2, y1));
            Initiator.Add(new PointF(x3, y3));
            Initiator.Add(new PointF(x1, y1));

            ScaleFactor = 1 / 3f;                   // Make subsegments 1/3 size.

            GeneratorDTheta = new List<float>();
            float pi_over_3 = (float)(Math.PI / 3f);
            GeneratorDTheta.Add(0);                 // Draw in the original direction.
            GeneratorDTheta.Add(-pi_over_3);        // Turn -60 degrees.
            GeneratorDTheta.Add(2 * pi_over_3);     // Turn 120 degrees.
            GeneratorDTheta.Add(-pi_over_3);        // Turn -60 degrees.

            // Get the parameters.
            int depth = int.Parse(txtDepth.Text);

            Bitmap bm = new Bitmap(picCanvas.ClientSize.Width, picCanvas.ClientSize.Height);
            picCanvas.Image = bm;

            // Draw the snowflake.
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                DrawSnowflake(gr, depth);
            }

            this.Cursor = Cursors.Default;
        }

        // Draw the complete snowflake.
        public void DrawSnowflake(Graphics gr, int depth)
        {
            int Pozadie = int.Parse(txtFarba.Text);
            if (Pozadie == 1)
            {
                gr.Clear(picCanvas.BackColor=Color.Black);
            }
            if (Pozadie == 2)
            {
                gr.Clear(picCanvas.BackColor = Color.White);
            }
            if (Pozadie == 3)
            {
                gr.Clear(picCanvas.BackColor = Color.Aqua);
            }
            if (Pozadie == 4)
            {
                gr.Clear(picCanvas.BackColor = Color.Red);
            }
            // gr.Clear(picCanvas.BackColor);

            // Draw the snowflake.
            for (int i = 1; i < Initiator.Count; i++)
            {
                PointF p1 = Initiator[i - 1];
                PointF p2 = Initiator[i];

                float dx = p2.X - p1.X;
                float dy = p2.Y - p1.Y;
                float length = (float)Math.Sqrt(dx * dx + dy * dy);
                float theta = (float)Math.Atan2(dy, dx);
                DrawSnowflakeEdge(gr, depth, ref p1, theta, length);
            }
        }

        // Recursively draw a snowflake edge starting at
        // (x1, y1) in direction theta and distance dist.
        // Leave the coordinates of the endpoint in
        // (x1, y1).
        private void DrawSnowflakeEdge(Graphics gr, int depth, ref PointF p1, float theta, float dist)
        {
            if (depth == 1)
            {
                int Ciara = int.Parse(txtFarbaCiary.Text);

                PointF p2 = new PointF(
                    (float)(p1.X + dist * Math.Cos(theta)),
                    (float)(p1.Y + dist * Math.Sin(theta)));
                
                
                if (Ciara == 1)
                {
                    gr.DrawLine(Pens.Black, p1, p2);
                }

                if (Ciara == 2)
                {
                    gr.DrawLine(Pens.Blue, p1, p2);
                }

                if (Ciara == 3)
                {
                    gr.DrawLine(Pens.Yellow, p1, p2);
                }

                if (Ciara == 4)
                {
                    gr.DrawLine(Pens.Red, p1, p2);
                }

                p1 = p2;
                return;
            }

            // Recursively draw the edge.
            dist *= ScaleFactor;
            for (int i = 0; i < GeneratorDTheta.Count; i++)
            {
                theta += GeneratorDTheta[i];
                DrawSnowflakeEdge(gr, depth - 1, ref p1, theta, dist);
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void picCanvas_Click(object sender,EventArgs e)
        {
            
        }
        private void txtDepth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFarbaCiary_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
