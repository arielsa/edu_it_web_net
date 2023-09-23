using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;

namespace WebApplicationMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Formulario()
        {
            return View();
        }
        public ActionResult CargaDatos()
        {
            string nombre = Request.Form["nombre"].ToString();
            string comentario = Request.Form["comentario"].ToString();
            Models.LibroDeVisitas libro = new Models.LibroDeVisitas();
            libro.Grabar(nombre, comentario);
            return View();
        }
        public ActionResult LibroVisitas()
        {
            Models.LibroDeVisitas libro = new Models.LibroDeVisitas();
            string contenido = libro.Leer();
            ViewData["libro"] = contenido;
            return View();
        }
    }
}