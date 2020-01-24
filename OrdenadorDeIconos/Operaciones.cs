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
        
        public static Color ColorPromedio(Bitmap icono)
        {
            int R=0, G=0, B=0, A=0, Resolucion=0;
            Color color = icono.GetPixel(0, 0);
            Resolucion = icono.Height * icono.Width;
            Console.WriteLine(icono.Height + " " + icono.Width + " " + Resolucion);
            for(int i=0;i< icono.Height; i++)
            {
                for(int k=0;k< icono.Width;k++)
                {
                    color = icono.GetPixel(i,k);
                    R += color.R;
                    G += color.G;
                    B += color.B;
                    A += color.A;
                }
            }
            R /= Resolucion;
            G /= Resolucion;
            B /= Resolucion;
            A /= Resolucion;

            color = Color.FromArgb(A,R, G, B);
            Console.WriteLine(color);
            return color;
        }
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
