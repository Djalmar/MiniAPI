using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MiniAPI.Models
{
    public class MiniContext : DbContext
    {
        private static MiniContext db=new MiniContext();

        public static MiniContext DB
        {
            get { return db; }
            set { db = value; }
        }

        public DbSet<Ruta> Ruta { get; set; }
        public DbSet<Tramo> Tramo { get; set; }
        public DbSet<Problema> Problema { get; set; }

        public MiniContext()
            : base()
        {

        }
    }
    public class MiniInitaializer : CreateDatabaseIfNotExists<MiniContext>
    {
        protected override void Seed(MiniContext context)
        {
            context.Ruta.Add(
                new Ruta()
                {
                    Numero = "331",
                    Tramos = new List<Tramo>()
                    {
                        new Tramo()
                        {
                            Nombre="Camacho",
                            XOrigen=0,
                            YOrigen=0,
                            XDestino=1,
                            YDestino=1
                        },
                        new Tramo()
                        {
                            Nombre="Stadium",
                            XOrigen=1,
                            YOrigen=1,
                            XDestino=2,
                            YDestino=2
                        }
                    }
                }
                );
            context.SaveChanges();
        }
    }
}