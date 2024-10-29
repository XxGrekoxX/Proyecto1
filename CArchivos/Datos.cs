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
       
        private static string rutaBase = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CArchivos");
        private static string rutaArchivo = Path.Combine(rutaBase, "Usuarios.xml");

        public static void InicializarDirectorios()
        {
            if (!Directory.Exists(rutaBase))
            {
                Directory.CreateDirectory(rutaBase);
            }
        }

        public Boolean ValidarLogin(string Usern, string Password)
        {
            try
            {
                InicializarDirectorios();

                if (rutaArchivo == null)
                {
                    CrearArchivoXMLInicial();
                }

         
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(rutaArchivo);
                XmlNode usuario = xmldoc.SelectSingleNode($"/Users/User[Username='{Usern}']");
                if (usuario.SelectSingleNode("Username").Value == Usern && usuario.SelectSingleNode("Password").Value == Password)
                {
                    return true;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en ValidarLogin: {ex.Message}");
                return false;
            }
        }

        private static void CrearArchivoXMLInicial()
        {
            XDocument doc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("Users",
                    new XElement("User",
                        new XElement("Username", "admin"),
                        new XElement("Password", "admin123")
                    )
                )
            );
            doc.Save(rutaArchivo);
        }
    }
        
    
}
