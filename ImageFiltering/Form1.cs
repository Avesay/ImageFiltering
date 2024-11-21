using System.Drawing.Imaging;

namespace ImageFiltering
{
    public partial class Form1 : Form
    {
        //Color[,] pixelColors;
        public Form1()
        {
            InitializeComponent();
            BrushSizeVal.Text = trackBarBrushSize.Value.ToString();
            LoadImage("../../../images/park.png");
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
                LoadColorHistograms(clone);
            }
        }
        private void LoadColorHistograms(Bitmap bitmap)
        {
            Histogram histogram = new Histogram(bitmap);
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
    }
}
