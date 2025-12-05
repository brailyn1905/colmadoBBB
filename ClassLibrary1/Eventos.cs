using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public static class Eventos
    {
        public delegate void ProductoAgregadoHandler(Productos p);
        public delegate void VentaCompletadaHandler(Ventas v);
        public delegate void InventarioBajoHandler(Productos p);
    };
}
