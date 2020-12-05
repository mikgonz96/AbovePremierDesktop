using AbovePremierDesktop.Modelo;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbovePremierDesktop.DAOs
{
    class UsuariosDAO
    {
        public static List<Usuario> listaUsuarios = new List <Usuario>();

        
        /*public static void generarUsuarios()
        {
            listaUsuarios.Add(new Usuario("Homero", "123"));
            listaUsuarios.Add(new Usuario("Mik", "456"));
            listaUsuarios.Add(new Usuario("Profe", "789"));
            listaUsuarios.Add(new Usuario("Josu", "1112"));
            listaUsuarios.Add(new Usuario("1", "1"));

        }*/


        public static bool verificarUsuario(string user, string pass)
        {
            /*var usuario = listaUsuarios.Find(datosUsuario => datosUsuario.user == user && datosUsuario.pass == pass );

            if (usuario != null)
            {
                return true;
            }
            else
            {
                return false;
            }*/

            var client = new RestClient("https://localhost:44345/");

            var request = new RestRequest("api/APIAbove/" + user + "/" + pass);
            request.RequestFormat = DataFormat.Json;
            var response = client.Get(request).Content;
            var conf = System.Convert.ToBoolean(JsonConvert.DeserializeObject<dynamic>(response));
            return conf;
        }

    }
}
