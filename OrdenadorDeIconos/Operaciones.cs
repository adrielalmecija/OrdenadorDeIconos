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
            int R=0, G=0, B=0, Resolucion=0, contador=0;
            Color color = icono.GetPixel(0, 0);
            Resolucion = icono.Height * icono.Width;
            for(int i=0;i< icono.Height; i++)
            {
                int min = 0;
                /*if (i>= icono.Height - 13) // elimina la flechita inflerior izquiera (shortcut)
                {
                    min = 13;
                }*/
                for(int k=min;k< icono.Width;k++)
                {
                    color = icono.GetPixel(i,k);
                    if(color.A==255)
                    {
                        R += color.R;
                        G += color.G;
                        B += color.B;
                        contador++;
                    }
                }
            }
            R /= contador;
            G /= contador;
            B /= contador;

            color = Color.FromArgb(255,R, G, B);
            return color;
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
