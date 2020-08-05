using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace TexturesToRGBchannels
{
    public partial class Form1 : Form
    {
        byte[,] R, G, B, A;

        OpenFileDialog open;
        public Form1()
        {
            InitializeComponent();
            open = new OpenFileDialog();
            open.Title = "Open";
            open.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png; | All files (*.*)|*.*";
        }

        private void rLoad_Click(object sender, EventArgs e)
        {
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(open.FileName);
                red.Image = bitmap;

                R = GetChannel(bitmap, 0);
            }
        }

        private void gLoad_Click(object sender, EventArgs e)
        {
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(open.FileName);
                green.Image = bitmap;

                G = GetChannel(bitmap, 1);
            }
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(open.FileName);
                blue.Image = bitmap;

                B = GetChannel(bitmap, 2);
            }
        }

        private void aLoad_Click(object sender, EventArgs e)
        {
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(open.FileName);
                alpha.Image = bitmap;

                A = GetChannel(bitmap, 0);
            }
        }

        private void rClear_Click(object sender, EventArgs e)
        {
            red.Image = new Bitmap(128, 128);
            R = null;
        }

        private void gClear_Click(object sender, EventArgs e)
        {
            green.Image = new Bitmap(128, 128);
            G = null;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            blue.Image = new Bitmap(128, 128);
            B = null;
        }

        private void aClear_Click(object sender, EventArgs e)
        {
            alpha.Image = new Bitmap(128, 128);
            A = null;
        }

        private void save_Click(object sender, EventArgs e)
        {
            int r = 0, g = 0, b = 0, a = 255;
            Bitmap bitmap;

            if (A == null)
                bitmap = new Bitmap(R.GetLength(0), R.GetLength(1), PixelFormat.Format24bppRgb);
            else
                bitmap = new Bitmap(R.GetLength(0), R.GetLength(1), PixelFormat.Format32bppArgb);

            FastBitmap fb = new FastBitmap(bitmap);
            fb.LockBits();

            for (int y = 0; y < R.GetLength(1); y++)
            {
                for (int x = 0; x < R.GetLength(0); x++)
                {
                    if (R != null)
                        r = R[x, y];
                    if (G != null)
                        g = G[x, y];
                    if (B != null)
                        b = B[x, y];
                    if (A != null)
                        a = A[x, y];

                    fb.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }

            fb.UnlockBits();

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PNG image (*.png)|*.png";
            if (save.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(save.FileName, ImageFormat.Png);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private byte[,] GetChannel(Bitmap bitmap, byte channel)
        {
            byte[,] arr = new byte[bitmap.Width, bitmap.Height];
            FastBitmap fb = new FastBitmap(bitmap);
            fb.LockBits();

            for (int y = 0; y < fb.Height; y++)
            {
                for (int x = 0; x < fb.Width; x++)
                {
                    if (channel == 0)
                        arr[x, y] = fb.GetPixel(x, y).R;
                    if (channel == 1)
                        arr[x, y] = fb.GetPixel(x, y).G;
                    if (channel == 2)
                        arr[x, y] = fb.GetPixel(x, y).B;
                    if (channel == 3)
                        arr[x, y] = fb.GetPixel(x, y).A;
                }
            }
            fb.UnlockBits();
            return arr;
        }
    }
}
