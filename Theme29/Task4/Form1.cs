using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        private Bitmap _skyImage;
        private Bitmap _planeImage;
        private Graphics _graphics;
        private Rectangle _planeRectangle;
        private int _dx;
        private readonly Timer _timer = new Timer();
        private readonly Random _random = new Random();

        public Form1()
        {
            InitializeComponent();

            LoadImages();
            InitializeGraphics();
            InitializeTimer();
        }

        private void LoadImages()
        {
            try
            {
                _skyImage = new Bitmap("source\\sky.bmp");
                _planeImage = new Bitmap("source\\plane.bmp");
                _planeImage.MakeTransparent();
                BackgroundImage = _skyImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load images: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void InitializeGraphics()
        {
            _graphics = Graphics.FromImage(BackgroundImage);
        }

        private void InitializeTimer()
        {
            _timer.Interval = 20;
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdatePlanePosition();
            DrawSkyAndPlane();
        }

        private void UpdatePlanePosition()
        {
            _planeRectangle.X += _dx;
            if (_planeRectangle.X >= ClientSize.Width)
            {
                _planeRectangle.X = -_planeRectangle.Width;
                _planeRectangle.Y = 20 + _random.Next(ClientSize.Height - 40 - _planeRectangle.Height);
                _dx = 2 + _random.Next(4);
            }
        }

        private void DrawSkyAndPlane()
        {
            _graphics.DrawImage(_skyImage, Point.Empty);
            _graphics.DrawImage(_planeImage, _planeRectangle.Location);
            Invalidate(_planeRectangle);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Do not paint here, all drawing is handled in DrawSkyAndPlane method
        }

    }
}
