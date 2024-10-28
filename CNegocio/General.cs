using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CArchivos;

namespace CNegocio
{
    public class General
    {
        Datos d = new Datos();
        public Boolean AutenLogin(string Usern, string Password) 
        {
            return d.ValidarLogin(Usern, Password);
        }
    }
}
