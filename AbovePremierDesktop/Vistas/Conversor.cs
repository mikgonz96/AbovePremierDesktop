using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



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
            if (String.IsNullOrEmpty(RutaTxt.Text))
            {

                MessageBox.Show("Por favor seleccione un archivo para continuar");

            }
            else
            {
                
                switch (Opciones.SelectedItem.ToString().Trim())
                {
                    case "Convertir a .mp4":
                        MessageBox.Show("Usted va a convertir a mp4");
                        break;

                    case "Convertir a .mpeg":
                        MessageBox.Show("Usted va a convertir a mpeg");
                        break;

                    case "Convertir a .avi":
                        MessageBox.Show("Usted va a convertir a avi");
                        break;

                    case "Convertir a .flv":
                        MessageBox.Show("Usted va a convertir a flv");
                        break;

                    case "Obtener audio (.mp3)":
                        MessageBox.Show("Usted va a convertir a mp3");
                        break;

                    case "Quitar audio":
                        MessageBox.Show("Usted va a quitar audio");
                        break;

                    case "Cambiar resolución":
                        MessageBox.Show("Usted va a cambiar resolución");
                        break;

                    case "Extraer imagenes cada 'x' frames":
                        MessageBox.Show("Usted va a extraer imagen");
                        break;

                    default:
                        MessageBox.Show("Seleccione una opción para continuar");
                        break;
                }
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
