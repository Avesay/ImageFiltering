using FastBitmapLib;
using System.Drawing.Imaging;

namespace ImageFiltering
{
    public partial class Form1 : Form
    {
        Color[,] pixelColors;
        float[,] M = new float[3, 3] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };

        public Form1()
        {
            InitializeComponent();
            BrushSizeVal.Text = trackBarBrushSize.Value.ToString();
            string filepath = "../../../images/park.png";
            LoadImage(filepath);
        }
        private Color[,] BitmapToMatrix(Bitmap bitmap)
        {
            int width = bitmap.Size.Width;
            int height = bitmap.Size.Height;
            Color[,] colors = new Color[width, height];
            using (FastBitmap fastbitmap = bitmap.FastLock())
            {
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        colors[i, j] = fastbitmap.GetPixel(i, j);
                    }
                }
            }
            return colors;
        }
        private Bitmap MatrixToBitmap()
        {
            int width = pixelColors.GetLength(0);
            int height = pixelColors.GetLength(1);
            Bitmap bitmap = new Bitmap(width, height);
            using (FastBitmap fastbitmap = bitmap.FastLock())
            {
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        fastbitmap.SetPixel(i, j, pixelColors[i, j]);
                    }
                }
            }
            return bitmap;
        }
        private void plikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Wybierz obraz",
                Filter = "png files (*.png)|*.png",
                InitialDirectory = "C:\\"
            };
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                var filepath = ofd.FileName;
                LoadImage(filepath);
            }
        }
        private void LoadImage(string filepath)
        {
            if (File.Exists(filepath))
            {
                Bitmap bitmap = new Bitmap(filepath);
                Bitmap clone = new Bitmap(bitmap.Width, bitmap.Height,
                                    System.Drawing.Imaging.PixelFormat.Format32bppPArgb);

                using (Graphics gr = Graphics.FromImage(clone))
                {
                    gr.DrawImage(bitmap, new Rectangle(0, 0, clone.Width, clone.Height));
                }
                Canvas.Image = clone;
                pixelColors = BitmapToMatrix(clone);
                LoadColorHistograms();
            }
        }
        private void LoadColorHistograms()
        {
            Histogram histogram = new(pixelColors);
            ChartTable.Controls.Clear();
            ChartTable.Controls.Add(histogram.GetRedChart());
            ChartTable.Controls.Add(histogram.GetGreenChart());
            ChartTable.Controls.Add(histogram.GetBlueChart());
        }

        private void radioButtonCustom_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown00.Enabled = numericUpDown01.Enabled = numericUpDown02.Enabled =
                numericUpDown10.Enabled = numericUpDown11.Enabled = numericUpDown12.Enabled =
                numericUpDown20.Enabled = numericUpDown21.Enabled = numericUpDown22.Enabled = radioButtonCustom.Checked;
        }

        private void trackBarBrushSize_Scroll(object sender, EventArgs e)
        {
            BrushSizeVal.Text = trackBarBrushSize.Value.ToString();
        }

        private void checkBoxAutoDivisor_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownDivisor.Enabled = labelDzielnik.Enabled = !checkBoxAutoDivisor.Checked;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if(radioButtonCustom.Checked) M = new float[3, 3] { 
                { (float)numericUpDown00.Value, (float)numericUpDown01.Value, (float)numericUpDown02.Value },
                { (float)numericUpDown10.Value, (float) numericUpDown11.Value, (float)numericUpDown12.Value },
                {(float)numericUpDown20.Value, (float)numericUpDown21.Value, (float)numericUpDown22.Value }
            };
            if (radioButtonWholePicture.Checked)
            {
                pixelColors = Filters.Filter.FilterColors(pixelColors, M, (from float val in M select val).Sum(), (float)numericUpDownShift.Value);
            }
            Canvas.Image = MatrixToBitmap();
            LoadColorHistograms();
        }

        private void radioButtonBlur_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBlur.Checked) M = new float[3, 3] { { 0, 1, 0 }, { 1, 4, 1 }, { 0, 1, 0 } };
        }

        private void radioButtonIdentity_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonIdentity.Checked) M = new float[3, 3] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
        }

        private void radioButtonSharpen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSharpen.Checked) M = new float[3, 3] { { 0, -1, 0 }, { -1, 5, -1 }, { 0, -1, 0 } };
        }
        private void radioButtonRelief_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonRelief.Checked) M = new float[3, 3] { { -1,-1,0 }, { -1,1,1 }, { 0,1,1 } };
        }

        private void radioButtonEdgeDetect_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEdgeDetect.Checked) M = new float[3, 3] { { 0, -1, 0 }, { -1, 4, -1 }, { 0, -1, 0 } };
        }

        
    }
}
