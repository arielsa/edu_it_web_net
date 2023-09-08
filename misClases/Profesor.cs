using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace misClases
{
    public class Profesor : Persona
    {
        public int Codigo { get; set; }
        public Profesor() { }

        public Profesor(string pNombre, string pApellido, int pCodigo, string pDocumento ) 
        {
            Nombre = pNombre;
            Apellido = pApellido;
            Codigo = pCodigo;
            setDocumento(pDocumento);
        }
        public override void mostraDato()
        {
            Console.WriteLine("nombre:  {0} ", Nombre);
            Console.WriteLine("apellido:  {0} ", Apellido);
            Console.WriteLine("codigo: {0}", Codigo);
            Console.WriteLine("documento: {0}", getDocumento());
            Console.WriteLine();
        }
    }
}
