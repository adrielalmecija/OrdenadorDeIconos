using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenadorDeIconos
{
    class ExtractorDeIcono
    {
        public static Icon Extraer()
        {
            var filePath = @"C:\Users\Turbioh\Desktop\Netflix.lnk";
            var theIcon = IconFromFilePath(filePath);

            if (theIcon != null)
            {
                // Save it to disk, or do whatever you want with it.
                return theIcon;

                /*using (var stream = new System.IO.FileStream(@"C:\Users\Turbioh\Desktop\icono.ico", System.IO.FileMode.CreateNew))
                {
                    //theIcon.ToBitmap(); //transformp el icono a BMP
                    theIcon.Save(stream);
                    return theIcon;
                }*/
            }
            return null;
        }

        public static Icon IconFromFilePath(string filePath)
        {
            var result = (Icon)null;

            try //manejo de excepciones
            {
                result = Icon.ExtractAssociatedIcon(filePath);
            }
            catch (System.Exception)
            {
                
            }

            return result;
        }
    }
}
