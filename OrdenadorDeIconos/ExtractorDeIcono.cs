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
            var filePath = @"C:\Users\Turbioh\Desktop\balenaEtcher.lnk";
            var theIcon = IconFromFilePath(filePath);

            if (theIcon != null)
            {
                // Save it to disk, or do whatever you want with it.
                return theIcon;
                /*using (var stream = new System.IO.FileStream(@"C:\Users\Turbioh\Desktop\icono.ico", System.IO.FileMode.CreateNew))
                {
                    //theIcon.ToBitmap(); //transform to BMP
                    theIcon.Save(stream);
                    return theIcon;
                }*/
            }
            return null;
        }

        public static Icon IconFromFilePath(string filePath)
        {
            var result = (Icon)null;

            try
            {
                result = Icon.ExtractAssociatedIcon(filePath);
            }
            catch (System.Exception)
            {
                // swallow and return nothing. You could supply a default Icon here as well
            }

            return result;
        }
    }
}
