using FastBitmapLib;
using ImageFiltering.Filters;
using System.Drawing.Imaging;

namespace ImageFiltering
{
    public partial class Form1 : Form
    {
        Color[,]? pixelColors;
        bool[,]? colored;
        float[,] M = new float[3, 3] { { 0, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 } };
        float[,] nextM = new float[3, 3] { { 0, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 } };
        int brushsize = 0;
        string filepath = "../../../images/img1.png";
        float D = 1;
        float offset = 0;

        public Form1()
        {
            InitializeComponent();
            BrushSizeVal.Text = trackBarBrushSize.Value.ToString();
            LoadImage(filepath);
        }
        #region BitmapMatrixOperations
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
            if (pixelColors is null) return new Bitmap(Canvas.Size.Width, Canvas.Size.Height);
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
        #endregion
        #region FileOperations
        private void plikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Wybierz obraz",
                Filter = "png files (*.png)|*.png",
                InitialDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Images"
            };
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                filepath = ofd.FileName;
                LoadImage(filepath);
            }
        }
        private void zapiszObrazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Zapisz obraz",
                Filter = "png files (*.png)|*.png",
                InitialDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Images"
            };
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Canvas.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
            }
        }
        #endregion
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
            if (pixelColors is null) return;
            Histogram histogram = new(pixelColors);
            ChartTable.Controls.Clear();
            ChartTable.Controls.Add(histogram.GetRedChart());
            ChartTable.Controls.Add(histogram.GetGreenChart());
            ChartTable.Controls.Add(histogram.GetBlueChart());
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
            if (radioButtonCustom.Checked) M = new float[3, 3] {
                { (float)numericUpDown00.Value, (float)numericUpDown01.Value, (float)numericUpDown02.Value },
                { (float)numericUpDown10.Value, (float) numericUpDown11.Value, (float)numericUpDown12.Value },
                {(float)numericUpDown20.Value, (float)numericUpDown21.Value, (float)numericUpDown22.Value }
            };
            else M = nextM;
            if (!checkBoxAutoDivisor.Checked) D = (float)numericUpDownDivisor.Value;
            else D = (from float val in M select val).Sum();
            offset = (float)numericUpDownShift.Value;

            if (radioButtonWholePicture.Checked)
            {
                Canvas.MouseDown -= Canvas_MouseDown;
                Canvas.MouseUp -= Canvas_MouseUp;
                Canvas.MouseMove -= Canvas_MouseMove;
                pixelColors = Filters.Filter.FilterColors(pixelColors, M, D, offset);
            }
            else if (radioButtonBrush.Checked)
            {
                brushsize = trackBarBrushSize.Value;
                Canvas.MouseDown += Canvas_MouseDown;
                Canvas.MouseUp += Canvas_MouseUp;
                Canvas.MouseMove += Canvas_MouseMove;
            }
            Canvas.Image = MatrixToBitmap();
            LoadColorHistograms();
        }
        #region radiobuttons
        private void radioButtonBlur_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBlur.Checked) nextM = new float[3, 3] { { 0, 1, 0 }, { 1, 4, 1 }, { 0, 1, 0 } };
        }

        private void radioButtonIdentity_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonIdentity.Checked) nextM = new float[3, 3] { { 0, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 } };
        }

        private void radioButtonSharpen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSharpen.Checked) nextM = new float[3, 3] { { 0, -1, 0 }, { -1, 5, -1 }, { 0, -1, 0 } };
        }
        private void radioButtonRelief_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRelief.Checked) nextM = new float[3, 3] { { -1, -1, 0 }, { -1, 1, 1 }, { 0, 1, 1 } };
        }

        private void radioButtonEdgeDetect_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEdgeDetect.Checked) nextM = new float[3, 3] { { 0, -1, 0 }, { -1, 4, -1 }, { 0, -1, 0 } };
        }
        private void radioButtonCustom_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown00.Enabled = numericUpDown01.Enabled = numericUpDown02.Enabled =
                numericUpDown10.Enabled = numericUpDown11.Enabled = numericUpDown12.Enabled =
                numericUpDown20.Enabled = numericUpDown21.Enabled = numericUpDown22.Enabled = radioButtonCustom.Checked;
        }
        #endregion

        private bool mouseDown = false;
        private Color[,]? OGColors;
        private void Canvas_MouseDown(object? sender, MouseEventArgs e)
        {
            colored = new bool[Canvas.Size.Width, Canvas.Size.Height];
            mouseDown = true;
            OGColors = pixelColors;
            x = e.X; 
            y = e.Y;
            Canvas.Invalidate();
        }
        private int x = -1;
        private int y = -1;
        private void Canvas_MouseMove(object? sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            Canvas.Invalidate();
        }
        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            if (radioButtonBrush.Checked)
            {
                using (Pen p = new(Brushes.Black))
                {
                    if (x >= 0 && y >= 0) e.Graphics.DrawEllipse(p, x - brushsize / 2, y - brushsize / 2, brushsize, brushsize);
                    if (mouseDown)
                    {
                        pixelColors = Filters.Filter.FilterColors(pixelColors, OGColors, M, D, offset, x, y, brushsize / 2, colored);
                        Canvas.Image = MatrixToBitmap();
                    }
                }
            }
        }

        private void Canvas_MouseUp(object? sender, MouseEventArgs e)
        {
            mouseDown = false;
            LoadColorHistograms();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            LoadImage(filepath);
        }

        private void buttonGray_Click(object sender, EventArgs e)
        {
            pixelColors = Gray.ConvertToGrays(pixelColors);
            Canvas.Image = MatrixToBitmap();
            LoadColorHistograms();
        }
    }
}
