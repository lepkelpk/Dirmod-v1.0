using Dirmod.Repositorio;
using Dirmod.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Dirmod.Repositorio
{
    public class CambioTodayRepositorio
    {
        private readonly ICotizaciones _cotizaciones;

        public CambioTodayRepositorio(ICotizaciones cotizaciones)
        {
            _cotizaciones = cotizaciones;
        }

        public async Task<CotizacionRespuesta> GetCotizacionAsync()
        {
            return await _cotizaciones.GetCotizacion();
        }
    }
}