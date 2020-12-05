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

            ProcessStartInfo process = new ProcessStartInfo("cmd.exe", $@"/k cd {Path.GetDirectoryName(ruta)} && ffmpeg.exe -i {nombreArchivo} {nombreGuardado}");
            process.UseShellExecute = false;
            process.CreateNoWindow = true;
            Process.Start(process);
        } 

            
            

        public static void quitarAudio(string ruta, String ext)
        {
            var nombreArchivo = Path.GetFileName(ruta);
            var nombreGuardado = Path.GetFileNameWithoutExtension(ruta) + "_noSound"+ext;

            ProcessStartInfo process = new ProcessStartInfo("cmd.exe", $@"/k cd {Path.GetDirectoryName(ruta)} && ffmpeg.exe -i {nombreArchivo} -an {nombreGuardado}");
            process.UseShellExecute = false;
            process.CreateNoWindow = true;
            Process.Start(process);
        }

        public static void cambiarRes(string ruta, String res, String ext)
        {
            var nombreArchivo = Path.GetFileName(ruta);
            var nombreGuardado = Path.GetFileNameWithoutExtension(ruta) + "_Res" + res+ext;

            ProcessStartInfo process = new ProcessStartInfo("cmd.exe", $@"/k cd {Path.GetDirectoryName(ruta)} && ffmpeg.exe -i {nombreArchivo} -s {res} {nombreGuardado}");
            process.UseShellExecute = false;
            process.CreateNoWindow = true;
            Process.Start(process);
        }

        public static void obtenerImgs(string ruta, String frames)
        {
            var nombreArchivo = Path.GetFileName(ruta);
            var nombreGuardado = Path.GetFileNameWithoutExtension(ruta)+"IMG_";

            ProcessStartInfo process = new ProcessStartInfo("cmd.exe", $@"/k cd {Path.GetDirectoryName(ruta)} && ffmpeg.exe -i {nombreArchivo} -vf fps={frames} {nombreGuardado}%d.png");
            process.UseShellExecute = false;
            process.CreateNoWindow = true;
            Process.Start(process);

        }

    }
}

