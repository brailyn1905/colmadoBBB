using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CapaNegocio
{
    public class VentasBLL
    {
        private VentasDAL dal = new VentasDAL();

        // Este es el método que tu formulario necesita
        public int CrearVenta(List<Productos> carrito)
        {
            decimal subtotal = carrito.Sum(x => x.Precio * x.Stock);
            decimal itbis = subtotal * 0.18m;
            decimal total = subtotal + itbis;

            // Guardar la venta
            int ventaId = dal.CrearVenta(subtotal, itbis, total);

            // Guardar cada detalle
            foreach (var p in carrito)
            {
                dal.CrearDetalle(ventaId, p);

                // Restar stock del producto vendido
                dal.RestarStock(p.ProductoID, p.Stock);
            }

            return ventaId;
        }
    }


}
