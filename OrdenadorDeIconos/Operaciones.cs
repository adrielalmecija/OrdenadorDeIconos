using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenadorDeIconos
{
    class Operaciones
    {
        
       
        public static Color AverageColor(string fileName)
        {
            using (var bmp = new Bitmap(fileName))
            {
                int width = bmp.Width;
                int height = bmp.Height;
                int red = 0;
                int green = 0;
                int blue = 0;
                int alpha = 0;
                for (int x = 0; x < width; x++)
                    for (int y = 0; y < height; y++)
                    {
                        var pixel = bmp.GetPixel(x, y);
                        red += pixel.R;
                        green += pixel.G;
                        blue += pixel.B;
                        alpha += pixel.A;
                    }

                Func<int, int> avg = c => c / (width * height);

                red = avg(red);
                green = avg(green);
                blue = avg(blue);
                alpha = avg(alpha);

                var color = Color.FromArgb(alpha, red, green, blue);

                return color;
            }
        }

        public static void ListarEscritorio()
        {
            DirectoryInfo DesktopPath = new DirectoryInfo(@"C:\Users\Turbioh\Desktop"); //Ruta de lectura
            FileInfo[] DesktopFiles = DesktopPath.GetFiles(); //Tomando los archivos
            foreach (FileInfo file in DesktopFiles)
            {
                Console.WriteLine( file.Name);
            }
        }
    }
}
