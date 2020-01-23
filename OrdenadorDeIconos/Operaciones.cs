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
