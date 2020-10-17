using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbovePremierDesktop.FFmpeg
{
    class FFmpeg
    {

        public static void convertirVideo(string ruta, string nuevoFormato)
        {
            var nombreArchivo = Path.GetFileName(ruta);
            var nombreGuardado = Path.GetFileNameWithoutExtension(ruta) + nuevoFormato;
            
            Process process = Process.Start("cmd.exe", $@"/k cd {Path.GetDirectoryName(ruta)} && ffmpeg.exe -i {nombreArchivo} {nombreGuardado}")

        }


        public static void quitarAudio(string ruta)
        {

        }
        public static void cambiarRes(string ruta)
        {

        }

        public static void obtenerImgs(string ruta)
        {

        }
    }
}
