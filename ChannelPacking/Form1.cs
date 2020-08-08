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

        private void SetRedChannel(string file)
        {
            Bitmap bitmap = new Bitmap(file);
            red.Image = bitmap;

            R = GetChannel(bitmap, 0);
        }

        private void SetGreenChannel(string file)
        {
            Bitmap bitmap = new Bitmap(file);
            green.Image = bitmap;

            G = GetChannel(bitmap, 1);
        }

        private void SetBlueChannel(string file)
        {
            Bitmap bitmap = new Bitmap(file);
            blue.Image = bitmap;

            B = GetChannel(bitmap, 2);
        }

        private void SetAlphaChannel(string file)
        {
            Bitmap bitmap = new Bitmap(file);
            alpha.Image = bitmap;

            A = GetChannel(bitmap, 0);
        }

        private void rLoad_Click(object sender, EventArgs e)
        {
            if (open.ShowDialog() == DialogResult.OK)
                SetRedChannel(open.FileName);
        }

        private void gLoad_Click(object sender, EventArgs e)
        {
            if (open.ShowDialog() == DialogResult.OK)
                SetGreenChannel(open.FileName);
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            if (open.ShowDialog() == DialogResult.OK)
                SetBlueChannel(open.FileName);
        }

        private void aLoad_Click(object sender, EventArgs e)
        {
            if (open.ShowDialog() == DialogResult.OK)
                SetAlphaChannel(open.FileName);
        }

        private Bitmap BlankBitmap { get => MakeBitmap(defaultColor.Checked); }

        private Bitmap MakeBitmap(bool black)
        {
            Color color;
            if (black)
                color = Color.FromArgb(0, 0, 0);
            else
                color = Color.FromArgb(255, 255, 255);

            Bitmap bitmap = new Bitmap(128, 128);
            using (Graphics gfx = Graphics.FromImage(bitmap))
            {
                using (SolidBrush brush = new SolidBrush(color))
                {
                    gfx.FillRectangle(brush, 0, 0, 128, 128);
                }
            }
            return bitmap;
        }

        private void rClear_Click(object sender, EventArgs e)
        {
            red.Image = BlankBitmap;
            R = null;
        }

        private void gClear_Click(object sender, EventArgs e)
        {
            green.Image = BlankBitmap;
            G = null;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            blue.Image = BlankBitmap;
            B = null;
        }

        private void aClear_Click(object sender, EventArgs e)
        {
            alpha.Image = MakeBitmap(false);
            A = null;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (R == null)
            {
                SetRedChannel(files[0]);
            }
            else if (G == null)
            {
                SetGreenChannel(files[0]);
            }
            else if (B == null)
            {
                SetBlueChannel(files[0]);
            }
            else if (A == null)
            {
                SetAlphaChannel(files[0]);
            }
        }

        private void defaultColor_CheckedChanged(object sender, EventArgs e)
        {
            if (R == null)
            {
                red.Image = BlankBitmap;
            }
            if (G == null)
            {
                green.Image = BlankBitmap;
            }
            if (B == null)
            {
                blue.Image = BlankBitmap;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            int r, g, b, a = 255;
            if (defaultColor.Checked)
            {
                r = 0; g = 0; b = 0;
            }
            else
            {
                r = 255; g = 255; b = 255;
            }

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
            red.Image = BlankBitmap;
            green.Image = BlankBitmap;
            blue.Image = BlankBitmap;
            alpha.Image = MakeBitmap(false);
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
