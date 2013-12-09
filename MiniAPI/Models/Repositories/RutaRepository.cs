using MiniAPI.Controllers.API.ErrorHandler;
using MiniAPI.Models.APIHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniAPI.Models.Repositories
{
    public class RutaRepository
    {
        public object GetAll()
        {
            var data = MiniContext.DB.Ruta.ToList();
            return APIFunctions.SuccessResult(data, JsonMessage.Success);
        }
        public object Get(int rutaID)
        {
            var data = MiniContext.DB.Ruta.Find(rutaID);
            if (data == null)
                return APIFunctions.ErrorResult(JsonMessage.NotFound);
            return APIFunctions.SuccessResult(data, JsonMessage.Success);
        }
        public object GetByNumero(string numero)
        {
            var data = (from x in MiniContext.DB.Ruta.ToList() where x.Numero.Equals(numero) select x).ToList();
            if (data == null)
                return APIFunctions.ErrorResult(JsonMessage.NotFound);
            return APIFunctions.SuccessResult(data.First(), JsonMessage.Success);
        }
    }
}