using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using proyecto_seminario.Models;
namespace proyecto_seminario.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           
            linq_sqlDataContext db = new linq_sqlDataContext();
            List<CategoriaView> cat = db.Categoria.Select(a => new CategoriaView { id = a.IdCategoria, nombre = a.Nombre }).ToList();
            List<Libros> descr = db.Info_Libro.Select(b => new Libros { id_pub = b.IdPublicacion, titulo = b.Titulo, descripcion = b.Descripcion, categoria = b.Nombre, megusta =Convert.ToInt32( b.MeGusta.ToString()), portada = b.Portada }).ToList();
            ViewBag.catego = cat;
            ViewBag.valor = descr;
           
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Detalle_libro() {
            return View();
        }
    }
}
