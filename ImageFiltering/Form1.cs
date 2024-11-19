namespace ImageFiltering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            if(result == DialogResult.OK)
            {
                var filepath = ofd.FileName;
            }
        }
    }
}
