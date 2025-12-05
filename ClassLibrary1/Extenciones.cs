using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public static class Extensiones
    {
        public static string FormatoRD(this decimal monto)
        {
            return monto.ToString("C",
                new CultureInfo("es-DO"));
        }
    }
}
