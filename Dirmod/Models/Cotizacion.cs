using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dirmod.Repositorio
{
    public class Cotizacion
    {
        public string update { get; set; }

        public string source { get; set; }

        public string target { get; set; }

        public double value { get; set; }

        public double quantity { get; set; }

        public double amount { get; set; }
    }
}