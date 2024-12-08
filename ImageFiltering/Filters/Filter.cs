using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFiltering.Filters
{
    internal static class Filter
    {
        public static Color[,]? FilterColors(Color[,]? pixels, float[,] M, float D, float offset)
        {
            if (pixels is null) return null;
            if (D == 0) D = 1;
            int width = pixels.GetLength(0);
            int height = pixels.GetLength(1);
            Color[,] outPixels = new Color[width, height];
            Parallel.For(0, width, x =>
            {
                for (int y = 0; y < height; ++y)
                {
                    float R = 0, G = 0, B = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            int idx = x + i - 1;
                            int idy = y + j - 1;
                            if (idx < 0) idx++;
                            else if (idx >= width) idx--;
                            if (idy < 0) idy++;
                            else if (idy >= height) idy--;
                            R += M[i, j] * pixels[idx, idy].R;
                            G += M[i, j] * pixels[idx, idy].G;
                            B += M[i, j] * pixels[idx, idy].B;
                        }
                    }
                    outPixels[x, y] = Color.FromArgb((int)Math.Clamp(R / D + offset, 0, 255), (int)Math.Clamp(G / D + offset, 0, 255), (int)Math.Clamp(B / D + offset, 0, 255));
                }
            });
            return outPixels;
        }
        public static Color[,]? FilterColors(Color[,]? currpixels, Color[,]? pixels, float[,] M, float D, float offset, int xCenter, int yCenter, int r, bool[,] colored)
        {
            if (pixels is null) return null;
            if (D == 0) D = 1;
            int width = pixels.GetLength(0);
            int height = pixels.GetLength(1);
            Color[,] outPixels = (Color[,])currpixels.Clone();
            Parallel.For(xCenter - r > 0 ? xCenter - r : 0, xCenter + r < width ? xCenter + r : width - 1, x =>
            {
                for (int y = yCenter - r > 0 ? yCenter - r : 0; y <= yCenter + r && y < height; ++y)
                {
                    float R = 0, G = 0, B = 0;
                    if (!colored[x, y] && ((x - xCenter) * (x - xCenter) + (y - yCenter) * (y - yCenter) <= r * r))
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                int idx = x + i - 1;
                                int idy = y + j - 1;
                                if (idx < 0) idx++;
                                else if (idx >= width) idx--;
                                if (idy < 0) idy++;
                                else if (idy >= height) idy--;
                                R += M[i, j] * pixels[idx, idy].R;
                                G += M[i, j] * pixels[idx, idy].G;
                                B += M[i, j] * pixels[idx, idy].B;
                            }
                        }
                        outPixels[x, y] = Color.FromArgb((int)Math.Clamp(R / D + offset, 0, 255), (int)Math.Clamp(G / D + offset, 0, 255), (int)Math.Clamp(B / D + offset, 0, 255));
                        colored[x, y] = true;
                    }
                }
            });
            return outPixels;
        }
    }
}
