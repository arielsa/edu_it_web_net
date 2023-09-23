using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace WebApplicationMVC.Models
{
    public class LibroDeVisitas
    {
        public void Grabar(string pNombre, string pComentario)
        {
            StreamWriter archivo = new StreamWriter(HostingEnvironment.MapPath("~") + "App_Data/datos.txt", true);
            archivo.WriteLine("nombre: " + pNombre + "<br />" + pComentario + "<hr />");
            archivo.Close();
        }
        public string Leer() {
        
            StreamReader archivo = new StreamReader(HostingEnvironment.MapPath("~") + "App_Data/datos.txt");

            string contenido = archivo.ReadToEnd() ;

            return contenido;
        }
    }
}



        