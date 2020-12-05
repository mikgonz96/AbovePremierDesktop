using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbovePremierDesktop.FFmpeg;


namespace AbovePremierDesktop.Vistas
{
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void Opciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if ( Opciones.SelectedItem.ToString() == "Cambiar resolución")
            {
                ResTxt.Enabled = true;
                FramesTxt.Enabled = false;

            } else if(Opciones.SelectedItem.ToString() == "Extraer imagenes cada 'x' frames"){
               
                FramesTxt.Enabled = true;
                ResTxt.Enabled = false;

            }
            else{
                
                ResTxt.Enabled = false;
                FramesTxt.Enabled = false;

            }

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
           if(BuscadorArchivos.ShowDialog() == DialogResult.OK)
            {
                RutaTxt.Text = BuscadorArchivos.FileName;
               
            }
           
        }

        private void ConvertirButton_Click(object sender, EventArgs e)
        {
            String ext = Path.GetExtension(RutaTxt.Text);
            String[] extp = { ".mp4", ".mpeg", ".flv", ".avi" };

            if (String.IsNullOrEmpty(RutaTxt.Text))
            {
                
                MessageBox.Show("Por favor seleccione un archivo para continuar");

            }
            else if(!extp.Contains(ext)){
                MessageBox.Show("El archivo elegido debe pertenecer a uno de los siguientes tipos:\n •.mp4\n •.mpeg \n •.avi \n •.flv");
            }
            else
            {
                
                switch (Opciones.SelectedItem.ToString().Trim())
                {
                    case "Convertir a .mp4":
                       
                        
                        FFmpeg.FFmpeg.convertirVideo(RutaTxt.Text, ".mp4");
                        break;

                    case "Convertir a .mpeg":
                        
                        FFmpeg.FFmpeg.convertirVideo(RutaTxt.Text, ".mpeg");
                        break;

                    case "Convertir a .avi":

                        FFmpeg.FFmpeg.convertirVideo(RutaTxt.Text, ".avi");
                        break;

                    case "Convertir a .flv":

                        FFmpeg.FFmpeg.convertirVideo(RutaTxt.Text, ".flv");
                        break;

                    case "Obtener audio (.mp3)":

                        FFmpeg.FFmpeg.convertirVideo(RutaTxt.Text, ".mp3");
                        break;

                    case "Quitar audio":

                        FFmpeg.FFmpeg.quitarAudio(RutaTxt.Text,ext);
                        break;

                    case "Cambiar resolución":

                        FFmpeg.FFmpeg.cambiarRes(RutaTxt.Text,ResTxt.Text,ext);
                        break;

                    case "Extraer imagenes cada 'x' frames":
                        
                        FFmpeg.FFmpeg.obtenerImgs(RutaTxt.Text, FramesTxt.Text);
                        break;

                    default:
                        MessageBox.Show("Seleccione una opción para continuar");
                        break;
                }

                MessageBox.Show("¡Su archivo fue manipulado correctamente! En unos minutos podrá verlo en la carpeta del archivo original. ☺");
            }
        }

        private void FramesTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!Char.IsDigit(c) && c!=8 && c != 46)
            {
                e.Handled = true;
                MessageBox.Show("Solo puede ingresar números enteros");
            }
        }
    }
}

/*
Lista de opciones
*Convertir a .mp4 
*Convertir a .mpeg
*Convertir a .avi
*Convertir a .flv
*Obtener audio (.mp3)
*Quitar audio
*Cambiar resolución
*Extraer imagenes cada "x" frames
*/
