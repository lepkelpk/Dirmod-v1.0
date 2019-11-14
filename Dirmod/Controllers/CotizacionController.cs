using Dirmod.Base;
using Dirmod.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Dirmod.Controllers
{
    public class CotizacionController : ApiController
    {
        // GET api/cotizacion/dolar
        /// <summary>
        /// Devuelve la cotización de la moneda solicitada
        /// </summary>
        /// <param name="moneda">Valor alfanumérico que representa la moneda a cotizar</param>
        /// <returns>Devuelve un objeto de tipo moneda con la cotización</returns>
        public async Task<TipoMoneda> Get(string moneda)
        {
            TipoMoneda tipoMoneda;

            switch (moneda.ToLower())
            {
              
                case "euro":
                    tipoMoneda = await new Cotizador(new CotizadorEuros()).GetCotizacionAsync();
                    break;

                case "dolar":
                    tipoMoneda = await new Cotizador(new CotizadorDolar()).GetCotizacionAsync();
                    break;

                case "real":
                    tipoMoneda = await new Cotizador(new CotizadorReal()).GetCotizacionAsync();
                    break;

                default:
                    tipoMoneda = new TipoMoneda() { Moneda = "No definida", Precio = 0 };
                    break;
            }

            return tipoMoneda;
        }

        // GET api/cotizacion/
        /// <summary>
        /// Devuelve la lista de las cotizaciones existentes
        /// </summary>
        /// <returns>Devuelve una lista de objetos de tipo de moneda</returns>
        public async Task<IEnumerable<TipoMoneda>> Get()
        {
            return new List<TipoMoneda>
            {
                await new Cotizador(new CotizadorEuros()).GetCotizacionAsync(),
                await new Cotizador(new CotizadorDolar()).GetCotizacionAsync(),                
                await new Cotizador(new CotizadorReal()).GetCotizacionAsync()
            };
        }
    }
}
