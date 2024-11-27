using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFiltering.Filters
{
    internal static class Filter
    {
        public static Color[,] FilterColors(Color[,] pixels, float[,] M, float D, float offset)
        {
            if (D == 0) D = 1;
            int width = pixels.GetLength(0);
            int height = pixels.GetLength(1);
            Color[,] outPixels = new Color[width, height];
            Parallel.For(0, width, x =>
            {
                Parallel.For(0, height, y =>
                {
                    float R = 0, G = 0, B = 0;
                    for(int i = 0; i < 3; i++)
                    {
                        for(int j = 0; j < 3; j++)
                        {
                            if(x + i - 1 >= 0 && y + j - 1 >= 0 && x + i - 1 < width && y + j - 1 < height)
                            {
                                R += M[i, j] * pixels[x + i - 1, y + j - 1].R;
                                G += M[i, j] * pixels[x + i - 1, y + j - 1].G;
                                B += M[i, j] * pixels[x + i - 1, y + j - 1].B;
                            }
                        }
                    }
                    outPixels[x, y] = Color.FromArgb((int)Math.Clamp(R/D + offset, 0, 255), (int)Math.Clamp(G / D + offset,0 , 255), (int)Math.Clamp(B / D + offset, 0 , 255));
                });
            });
            /*for(int x = 0;  x < width; x++)
            {
                for(int y = 0; y < height; y++)
                {
                    
                }
            }*/
            return outPixels;
        }
    }
}
