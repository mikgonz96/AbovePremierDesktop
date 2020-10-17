using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbovePremierDesktop.Modelo
{
    class Usuario
    {
      
        public string user { get; set; }
        public string pass { get; set; }

        public Usuario(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
        }

    }

}
