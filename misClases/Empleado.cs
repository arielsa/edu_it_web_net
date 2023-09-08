using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace misClases
{
    public class Empleado
    {
        public int Id {get; set;}
        public string Nombre { get; set;}
        public string Apellido { get; set;}

        public Empleado(){        }

        public Empleado(int pId, string pNombre, string pApellido)
        {            
            Id = pId;
            Nombre = pNombre;
            Apellido = pApellido;
        }
        public Empleado( string pNombre, string pApellido)
        {            
            Nombre = pNombre;
            Apellido = pApellido;
        }
        public Empleado(int pId )
        {
            Id = pId;
        }
    }
}
