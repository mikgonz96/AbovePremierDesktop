using AbovePremierDesktop.DAOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbovePremierDesktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            var user = UserTxt.Text;
            var pass = PassTxt.Text;

            if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(pass))
            {
                Error.Text = "Faltan datos, por favor complete todos los campos.";
                Error.Visible = true;

            }
            else if (UsuariosDAO.verificarUsuario(user, pass))
            {
                Form conversor = new Vistas.Conversor();
                conversor.Show();
                this.Hide();
            }
            else
            {
                Error.Text = "Los datos ingresados son incorrectos o el usuario no existe.";
                Error.Visible = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            BienvenidoTxt.BackColor = Color.Transparent;
            Inicie.BackColor = Color.Transparent;
            UsuarioTxt.BackColor = Color.Transparent;
            ContraseñaTxt.BackColor = Color.Transparent;
            Error.BackColor = Color.Transparent;
        }
    }
}