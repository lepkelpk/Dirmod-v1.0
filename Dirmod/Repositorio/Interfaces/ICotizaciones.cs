using Dirmod.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Dirmod.Repositorio.Interfaces
{
    public interface ICotizaciones
    {
        Task<CotizacionRespuesta> GetCotizacion();
    }
}