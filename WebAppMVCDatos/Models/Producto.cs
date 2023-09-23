using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppMVCDatos.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
    }
}