using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.Nombre = "pepe";
            p.setDocumento("37183698");
            p.mostraDato();

            Console.ReadKey();  
            Console.Clear();    
            Alumno a = new Alumno();
            
            a.Datos = crearPersona();
            a.Datos.mostraDato();

        }
        static Persona crearPersona()
        {
            Persona p = new Persona();
            Console.WriteLine("ingrese nombre:");
            p.Nombre = Console.ReadLine();
            Console.WriteLine("ingrese apellido:");
            p.Apellido = Console.ReadLine();
            Console.WriteLine("ingrese dni:");
            p.setDocumento(Console.ReadLine());
            return p;
        }
    }
    class Persona
    {
        public string Nombre;
        public string Apellido;
        private string Documento;

        public void mostraDato() 
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
    }
    class Alumno
    {
        public Persona Datos;
        public int Legajo;
        public string Mail;



    }
    class Participante
    {
        private int _codigo;
        private string _nombre;

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        
    }
    class Profesor
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; } 
    }
}
