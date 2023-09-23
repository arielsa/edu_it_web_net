using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppMVC_helpers.Models
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido{ get; set; }
        public string Email { get; set; }
    }
}