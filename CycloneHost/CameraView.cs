using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WebCam_Capture;

namespace CycloneHost
{
    public partial class CameraView : Form
    {
        public CameraView()
        {
            InitializeComponent();
        }
        private Graphics g;
        Pen mypen = new Pen(Brushes.Black);


        private Capture capture;  //takes images from camera as image frames
        private bool captureInProgress;

        private void ProcessFrame(object sender, EventArgs arg)
        {
            Image<Bgr, Byte> ImageFrame = capture.QueryFrame();  //line 1
           pictureBox1.Image = ImageFrame.ToBitmap();  //line 2
        }

        private void CameraView_Load(object sender, EventArgs e)
        {
            if (capture == null)
            {
                try
                {
                    capture = new Capture();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }

            if (capture != null)
            {
                if (captureInProgress)
                { 
                    Application.Idle -= ProcessFrame;
                }
                else
                {
                    Application.Idle += ProcessFrame;
                }
                captureInProgress = !captureInProgress;
            }
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawLine(mypen, pictureBox1.Width / 2, 0, pictureBox1.Width / 2, pictureBox1.Height);
            g.DrawLine(mypen, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);
            g.DrawEllipse(mypen, pictureBox1.Width/2 - 10, pictureBox1.Height/2 - 10, 20, 20);
            g.DrawEllipse(mypen, pictureBox1.Width / 2 - 40, pictureBox1.Height / 2 - 40, 80, 80);
            g.DrawEllipse(mypen, pictureBox1.Width / 2 - 70, pictureBox1.Height / 2 - 70, 140, 140);
            g.DrawEllipse(mypen, pictureBox1.Width / 2 - 100, pictureBox1.Height / 2 - 100, 200, 200);
        }
    }
}
