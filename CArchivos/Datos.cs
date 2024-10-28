using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace CArchivos
{
    public class Datos
    {
        private string xmlFilePath = "CArchivos\\Usuarios.xml";
        public Boolean ValidarLogin(string Usern, string Password) 
        {
            XDocument ValDoc = XDocument.Load(xmlFilePath);

            var user = ValDoc.Descendants("User ").FirstOrDefault(u=>u.Element("Username").Value == Usern && u.Element("Password").Value == Password);
            return user != null;
        }
        
    }
}
