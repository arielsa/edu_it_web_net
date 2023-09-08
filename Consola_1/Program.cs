using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using misClases;
using System.Threading.Tasks;


namespace Consola_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            Alumno a = new Alumno();

            p.Apellido = "Perez";
            p.Nombre = "Juan";

            a.Datos = p;    

            a.Datos.mostraDato();
        }
    }
}
