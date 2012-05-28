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
            SqlConnection con = new SqlConnection("Data Source=ILLUSION_V2;Initial Catalog=semi2;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("select detalle,ruta_imagen from libro", con);
            SqlDataReader reader = com.ExecuteReader();
            List<Libro> x= new List<Libro>();
            while (reader.Read())
            {
                Libro l = new Libro();
                l.ruta = reader.GetString(1);
                l.detalle = reader.GetString(0);
                x.Add(l);
            }
            ViewBag.valor = x;
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
