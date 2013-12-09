using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniAPI.Models
{
    public class Tiene
    {
        public int TieneID { get; set; }

        public int RutaID { get; set; }
        public int TramoID { get; set; }
        public int CoordenadasTramoID { get; set; }

        public virtual Ruta Ruta { get; set; }
        public virtual Tramo Tramo { get; set; }
        public virtual CoordenadasTramo CoordenadasTramo { get; set; }
    }
}