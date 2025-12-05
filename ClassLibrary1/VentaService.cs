using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaNegocio.Eventos;
using System.Data;
using Microsoft.Data.SqlClient;
using colmadoBBB;

namespace CapaNegocio
{
    
    public class VentaService
    {
        public event VentaCompletadaHandler VentaCompletada;

        public async Task<int> ProcesarVentaAsync(Ventas venta)
        {
            int ventaID = 0;

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                await con.OpenAsync();

                SqlCommand cmd = new SqlCommand("sp_ProcesarVenta", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UsuarioID", venta.UsuarioID);
                cmd.Parameters.AddWithValue("@ClienteID", venta.Cliente?.ClienteID ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Subtotal", venta.Subtotal);
                cmd.Parameters.AddWithValue("@ITBIS", venta.ITBIS);
                cmd.Parameters.AddWithValue("@Descuento", 0);
                cmd.Parameters.AddWithValue("@Total", venta.Total);
                cmd.Parameters.AddWithValue("@MetodoPago", venta.MetodoPago ?? "Efectivo");

                SqlParameter output = new SqlParameter("@VentaID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(output);

                await cmd.ExecuteNonQueryAsync();

                ventaID = Convert.ToInt32(output.Value);

                VentaCompletada?.Invoke(venta);
            }

            return ventaID;
        }
    }

}
