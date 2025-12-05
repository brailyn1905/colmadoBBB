using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   
        public class Ventas
        {
            public int VentaID { get; set; }
            public DateTime Fecha { get; set; }
            public int UsuarioID { get; set; }
            public Cliente Cliente { get; set; }
            public List<ItemVenta> Items { get; set; } = new List<ItemVenta>();
            public string MetodoPago { get; set; }

        public decimal Subtotal => Items.Sum(i => i.Subtotal);
            public decimal ITBIS => Items.Sum(i => i.ITBIS);
            public decimal Total => Items.Sum(i => i.Total);
        }
    
}
