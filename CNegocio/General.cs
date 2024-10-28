using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio
{
    public class General
    {
        private string _name;
        private string _contrasena;
        public General() 
        {
            if (Name.Equals("") && Contrasena.Equals("")) 
            {

            }
        }

        public string Name { get => _name; set => _name = value; }
        public string Contrasena { get => _contrasena; set => _contrasena = value; }
    }
}
