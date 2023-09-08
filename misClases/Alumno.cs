using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace misClases
{
    public class Alumno
    {
        public Persona Datos;
        public int Legajo;
        
        public Curso Curso;
        public Carrera Carrera;

        public Alumno( Persona pDatos, int pLegajo, Curso pCurso, Carrera pCarrera)
        {
            
            Datos = pDatos;
            Legajo = pLegajo;
            Curso = pCurso;
            Carrera = pCarrera;
        }
        public Alumno()
        {

        }
        public void mostraDato()
        {
            Console.WriteLine("legajo: {0}", Legajo);
            Console.WriteLine("curso: {0}", Curso.Nombre);
            Console.WriteLine("carrera: {0}", Carrera.Nombre);
            Console.WriteLine();
        }
    }
}
