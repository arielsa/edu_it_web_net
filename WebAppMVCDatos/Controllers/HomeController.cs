using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVCDatos.Models;

namespace WebAppMVCDatos.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DatosProducto objDatos = new DatosProducto();

            return View(objDatos.GetProductos());
        }
        public ActionResult Alta()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Alta(FormCollection controles)
        {
            DatosProducto objDatos = new DatosProducto();
            Producto producto = new Producto
            {
                Id = int.Parse(controles["codigo"]),
                Nombre = controles["nombre"].ToString(),
                Precio = float.Parse(controles["precio"])
            };
            objDatos.Alta(producto);
            return RedirectToAction("Index");
        }
        public ActionResult Baja(int pId)
        {
            DatosProducto objDatos = new DatosProducto();
            objDatos.Borrar(pId);
            return RedirectToAction("Index");
        }
        public ActionResult Modificar(int pId)
        {
            DatosProducto objDatos = new DatosProducto();
            Producto producto = objDatos.GetProducto(pId);
            return View(producto);
        }
        [HttpPost]
        public ActionResult Modificar(FormCollection controles)
        {
            DatosProducto objDatos = new DatosProducto();
            Producto producto = new Producto
            {
                Id = int.Parse(controles["codigo"].ToString()),
                Nombre = controles["nombre"].ToString(),
                Precio = float.Parse(controles["precio"].ToString())
            };
            objDatos.Modificar(producto);   
            return RedirectToAction("Index");
        }
    }
}
////////////////////////////ultimo video visto : 7 minuto 55