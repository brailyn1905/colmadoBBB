using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ProductoAgotadoException : Exception
    {
        public ProductoAgotadoException(string mensaje) : base(mensaje) { }
    }
}
