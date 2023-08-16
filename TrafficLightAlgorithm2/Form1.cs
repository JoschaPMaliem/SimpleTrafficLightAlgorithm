using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TrafficLightAlgorithm2
{
    public partial class Form1 : Form
    {
        private Color semaforo1Red = Color.Black;
        private Color semaforo1Laranja = Color.Black;
        private Color semaforo1Verde = Color.Black;

        private Color semaforo2Red = Color.Black;
        private Color semaforo2Laranja = Color.Black;
        private Color semaforo2Verde = Color.Black;

        private Timer redTimer = new Timer();
        private Timer orangeTimer = new Timer();
        private Timer greenTimer = new Timer();

        private Timer redTimer2 = new Timer();
        private Timer orangeTimer2 = new Timer();
        private Timer greenTimer2 = new Timer();

        public Form1()
        {
            InitializeComponent();
            InitializeTimers();
            InitializeTimers2();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int circleRadius = 30;
            int spacing = 20;

            int centerX = panel1.Width / 2;

            int centerY1 = circleRadius + spacing;
            int centerY2 = centerY1 + circleRadius * 2 + spacing;
            int centerY3 = centerY2 + circleRadius * 2 + spacing;

            using (SolidBrush brush = new SolidBrush(semaforo1Red))
            {
                e.Graphics.FillEllipse(brush, centerX - circleRadius, centerY1 - circleRadius, circleRadius * 2, circleRadius * 2);
            }

            using (SolidBrush brush = new SolidBrush(semaforo1Laranja))
            {
                e.Graphics.FillEllipse(brush, centerX - circleRadius, centerY2 - circleRadius, circleRadius * 2, circleRadius * 2);
            }

            using (SolidBrush brush = new SolidBrush(semaforo1Verde))
            {
                e.Graphics.FillEllipse(brush, centerX - circleRadius, centerY3 - circleRadius, circleRadius * 2, circleRadius * 2);
            }

        }

        private void InitializeTimers()
        {
            redTimer.Interval = 15000;
            redTimer.Tick += RedTimer_Tick;

            orangeTimer.Interval = 3000; 
            orangeTimer.Tick += OrangeTimer_Tick;

            greenTimer.Interval = 9000; 
            greenTimer.Tick += GreenTimer_Tick;
        }

        private void InitializeTimers2()
        {
            redTimer2.Interval = 15000;
            redTimer2.Tick += RedTimer2_Tick;

            orangeTimer2.Interval = 3000;
            orangeTimer2.Tick += OrangeTimer2_Tick;

            greenTimer2.Interval = 9000;
            greenTimer2.Tick += GreenTimer2_Tick;
        }

        private void TurnAllCirclesBlack()
        {
            semaforo1Red = Color.Black;
            semaforo1Laranja = Color.Black;
            semaforo1Verde = Color.Black;
            panel1.Invalidate();
        }


        private void RedTimer_Tick(object sender, EventArgs e)
        {
            TurnAllCirclesBlack();
            paint_green();
            greenTimer.Start();
            redTimer.Stop();
        }

        private void OrangeTimer_Tick(object sender, EventArgs e)
        {
            TurnAllCirclesBlack();
            paint_red();
            redTimer.Start();
            orangeTimer.Stop();
        }

        private void GreenTimer_Tick(object sender, EventArgs e)
        {
            TurnAllCirclesBlack();
            paint_orange();
            orangeTimer.Start();
            greenTimer.Stop();
        }

        private void paint_red()
        {
            panel1.Invalidate();
            semaforo1Red = Color.Red;



        }

        private void paint_orange()
        {
            panel1.Invalidate();
            semaforo1Laranja = Color.Orange;



        }

        private void paint_green()
        {
            panel1.Invalidate();
            semaforo1Verde = Color.Green;


        }



        private void button1_Click(object sender, EventArgs e)
        {
            paint_red();
            redTimer.Start();

            paint_green2();
            greenTimer2.Start();




        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            int circleRadius = 30;
            int spacing = 20;

            int centerX = panel1.Width / 2;

            int centerY1 = circleRadius + spacing;
            int centerY2 = centerY1 + circleRadius * 2 + spacing;
            int centerY3 = centerY2 + circleRadius * 2 + spacing;

            using (SolidBrush brush = new SolidBrush(semaforo2Red))
            {
                e.Graphics.FillEllipse(brush, centerX - circleRadius, centerY1 - circleRadius, circleRadius * 2, circleRadius * 2);
            }

            using (SolidBrush brush = new SolidBrush(semaforo2Laranja))
            {
                e.Graphics.FillEllipse(brush, centerX - circleRadius, centerY2 - circleRadius, circleRadius * 2, circleRadius * 2);
            }

            using (SolidBrush brush = new SolidBrush(semaforo2Verde))
            {
                e.Graphics.FillEllipse(brush, centerX - circleRadius, centerY3 - circleRadius, circleRadius * 2, circleRadius * 2);
            }

        }

        private void TurnAllCirclesBlack2()
        {
            semaforo2Red = Color.Black;
            semaforo2Laranja = Color.Black;
            semaforo2Verde = Color.Black;
            panel2.Invalidate();
        }

        private void RedTimer2_Tick(object sender, EventArgs e)
        {
            TurnAllCirclesBlack2();
            paint_green2();
            greenTimer2.Start();
            redTimer2.Stop();
        }

        private void OrangeTimer2_Tick(object sender, EventArgs e)
        {
            TurnAllCirclesBlack2();
            paint_red2();
            redTimer2.Start();
            orangeTimer2.Stop();
        }

        private void GreenTimer2_Tick(object sender, EventArgs e)
        {
            TurnAllCirclesBlack2();
            paint_orange2();
            orangeTimer2.Start();
            greenTimer2.Stop();
        }

        private void paint_red2()
        {
            panel2.Invalidate();
            semaforo2Red = Color.Red;
        }

        private void paint_orange2()
        {
            panel2.Invalidate();
            semaforo2Laranja = Color.Orange;
        }

        private void paint_green2()
        {
            panel2.Invalidate();
            semaforo2Verde = Color.Green;
        }
    }
}
