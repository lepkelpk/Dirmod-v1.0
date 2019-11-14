using Dirmod.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace Dirmod.Repositorio
{
    public class CotizacionEuro : ICotizaciones
    {
        public async Task<CotizacionRespuesta> GetCotizacion()
        {
            CotizacionRespuesta cotizacionRespuesta = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://api.currencies.zone/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                HttpResponseMessage response = await client.GetAsync("v1/quotes/EUR/ARS/json?quantity=1&key=2358|6*QEMwV3uJXUHKw5sDe8noXB15cKFeuz");
                if (response.IsSuccessStatusCode)
                {
                    cotizacionRespuesta = await response.Content.ReadAsAsync<CotizacionRespuesta>();
                }
                else
                {
                    cotizacionRespuesta = new CotizacionRespuesta() { status = "Error" };
                }
            }

            return cotizacionRespuesta;
        }
    }
}