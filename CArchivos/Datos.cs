using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;


namespace CArchivos
{
    public class Datos
    {
        string xmlFilePath = "https://github.com/XxGrekoxX/Proyecto1/blob/master/CArchivos/Usuarios.xml";
        public Boolean ValidarLogin(string Usern, string Password)
        {
            XDocument ValDoc = XDocument.Load(xmlFilePath);
            
            var user = ValDoc.Descendants("User ").FirstOrDefault(u=>u.Element("Username").Value == Usern && u.Element("Password").Value == Password);
            return user != null;
        }
        
    }
}
