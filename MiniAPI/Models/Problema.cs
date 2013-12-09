using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniAPI.Models
{
    public class Problema
    {
        public int ProblemaID { get; set; }
        public int Latitud { get; set; }
        public int Longitud { get; set; }
        public string Tipo { get; set; }
    }
}