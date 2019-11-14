using Dirmod.Base.Interfaces;
using Dirmod.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Dirmod.Base
{
    public class CotizadorDolar : ICotizaciones
    {
        public async Task<TipoMoneda> GetCotizacionAsync()
        {
            TipoMoneda tipoMoneda = new TipoMoneda() { Moneda = "No definido", Precio = 0 };
            CambioTodayRepositorio cambioTodayRepositorio = new CambioTodayRepositorio(new CotizacionDolar());
            CotizacionRespuesta cotizacionRespuesta = await cambioTodayRepositorio.GetCotizacionAsync();

            if (cotizacionRespuesta.status.Equals("OK"))
            {
                tipoMoneda.Moneda = "dolar";
                tipoMoneda.Precio = Convert.ToDouble(cotizacionRespuesta.result.amount);
            }

            return tipoMoneda;
        }
    }
}