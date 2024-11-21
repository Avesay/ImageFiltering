namespace ImageFiltering
{
    public partial class Form1 : Form
    {
        Color[,] pixelColors;
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
                /*var scale1 = (float)Canvas.Size.Width / (float)bitmap.Size.Width;
                var scale2 = (float)Canvas.Size.Height / (float)bitmap.Size.Height;
                scale1 = Math.Max(scale1, scale2);
                if(scale1 < 1) scale1 = 1;*/
                Canvas.Image = bitmap;//new Bitmap(bitmap, new Size((int)(bitmap.Size.Width * scale1), (int)(bitmap.Size.Height * scale1)));
            }
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
