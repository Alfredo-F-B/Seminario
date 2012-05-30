using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto_seminario.Models
{
    public class Libros
    {
        
        public int id_pub { set; get; }
        public string titulo { set; get; }
        public string descripcion { set; get; }
        public string portada { set; get; }
        public int megusta { set; get; }
        public string categoria { set; get; }

    }
}