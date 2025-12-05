using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using colmadoBBB;
using Microsoft.Data.SqlClient;


namespace CapaNegocio
{
    public class VentasDAL
    {
        public int CrearVenta(decimal subtotal, decimal itbis, decimal total)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Ventas (SubTotal, ITBIS, Total) OUTPUT INSERTED.VentaID VALUES (@sub, @itbis, @total)",
                    con);

                cmd.Parameters.AddWithValue("@sub", subtotal);
                cmd.Parameters.AddWithValue("@itbis", itbis);
                cmd.Parameters.AddWithValue("@total", total);

                int id = (int)cmd.ExecuteScalar();
                return id;
            }
        }

        public void CrearDetalle(int ventaId, Productos p)
        {
            using(SqlConnection con = Conexion.ObtenerConexion())
    {
                con.Open();

                decimal subtotal = p.Stock * p.Precio;      // Cantidad * PrecioUnitario
                decimal itbis = subtotal * 0.18m;

                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO DetalleVenta 
              (VentaID, ProductoID, Cantidad, PrecioUnitario, Subtotal, ITBIS)
              VALUES (@venta, @prod, @cant, @precio, @sub, @itbis)",
                    con);

                cmd.Parameters.AddWithValue("@venta", ventaId);
                cmd.Parameters.AddWithValue("@prod", p.ProductoID);
                cmd.Parameters.AddWithValue("@cant", p.Stock);
                cmd.Parameters.AddWithValue("@precio", p.Precio);
                cmd.Parameters.AddWithValue("@sub", subtotal);
                cmd.Parameters.AddWithValue("@itbis", itbis);

                cmd.ExecuteNonQuery();
            }
        }

        public void RestarStock(int productoId, int cantidad)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE Productos SET Stock = Stock - @cantidad WHERE ProductoID = @id",
                    con);

                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@id", productoId);

                cmd.ExecuteNonQuery();
            }
        }
    }

}
