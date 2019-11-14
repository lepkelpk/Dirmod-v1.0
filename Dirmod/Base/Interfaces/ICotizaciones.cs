using Dirmod.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dirmod.Base.Interfaces
{
    public interface ICotizaciones
    {
        Task<TipoMoneda> GetCotizacionAsync();
    }
}
