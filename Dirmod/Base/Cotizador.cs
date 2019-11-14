using Dirmod.Base.Interfaces;
using Dirmod.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Dirmod.Base
{
    public class Cotizador
    {
        private readonly ICotizaciones _cotizaciones;

        public Cotizador(ICotizaciones cotizaciones)
        {
            _cotizaciones = cotizaciones;
        }

        public async Task<TipoMoneda> GetCotizacionAsync()
        {
            return await _cotizaciones.GetCotizacionAsync();
        }
    }
}