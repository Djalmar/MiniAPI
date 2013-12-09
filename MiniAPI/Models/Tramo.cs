using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniAPI.Models
{
    public class Tramo
    {
        public int TramoID { get; set; }
        public string Nombre { get; set; }
        public double XOrigen { get; set; }
        public double YOrigen { get; set; }
        public double YDestino { get; set; }
        public double XDestino { get; set; }
    }
}