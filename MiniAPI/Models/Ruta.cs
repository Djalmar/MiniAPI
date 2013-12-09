using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MiniAPI.Models
{
    public class Ruta
    {
        public int RutaID { get; set; }
        public string Numero { get; set; }
        public IEnumerable<Tramo> Rutas { get; set; }
        public IEnumerable<CoordenadasTramo> Coordenadas { get; set; }
    }
}