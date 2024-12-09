namespace ImageFiltering.Filters
{
    internal static class Gray
    {
        public static Color[,]? ConvertToGrays(Color[,]? pixels)
        {
            if (pixels is null) return null;
            int width = pixels.GetLength(0);
            int height = pixels.GetLength(1);
            Color[,] outPixels = new Color[width, height];
            Parallel.For(0, width * height, xy =>
            {
                int x = xy % width;
                int y = xy / width;
                Color C = pixels[x, y];
                double Y = C.R * 0.299 + C.G * 0.587 + C.B * 0.114;
                int color = (int)Y;
                outPixels[x, y] = Color.FromArgb(color, color, color);
            });
            return outPixels;
        }
    }
}
