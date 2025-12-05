using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;

namespace CapaNegocio
{

    public class ItemVenta
    {
        public Productos Producto { get; set; }
        public int Cantidad { get; set; }

        public decimal Subtotal => Producto.Precio * Cantidad;
        public decimal ITBIS => Subtotal * 0.18m;
        public decimal Total => Subtotal + ITBIS;
    }
}

