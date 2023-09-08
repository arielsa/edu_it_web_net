using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace misClases
{
    public class Persona
    {
        public string Nombre;
        public string Apellido;
        private string Documento;

        public string Telefono;
        public string Domicilio;
        public string Email;

        public Persona(string pNombre, string pApellido, string pDocumento)
        {
            
            Nombre = pNombre;
            Apellido = pApellido;
            Documento = pDocumento;
        }
        public Persona()
        {

        }

        public virtual void mostraDato()
        {
            Console.WriteLine("nombre:  {0} ", Nombre);
            Console.WriteLine("apellido:  {0} ", Apellido);
            Console.WriteLine("documento: {0}", getDocumento());
            Console.WriteLine();
        }
        public void setDocumento(string pDocumento)
        {
            Documento = pDocumento;
        }
        public string getDocumento()
        {
            return Documento;
        }
        public string getNombre()
        {
            return Nombre;
        }
        public string getApellido()
        {
            return Apellido;
        }

    }
}
