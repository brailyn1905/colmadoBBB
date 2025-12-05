using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using colmadoBBB;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapaNegocio
{
    public class ProductosDAL
    {
        // ✔ Obtener todos los productos
        public List<Productos> ObtenerProductos()
        {
            List<Productos> lista = new List<Productos>();

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Productos", con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Productos
                    {
                        ProductoID = Convert.ToInt32(dr["ProductoID"]),
                        Codigo = dr["Codigo"].ToString(),
                        Nombre = dr["Nombre"].ToString(),
                        Precio = Convert.ToDecimal(dr["Precio"]),
                        Costo = Convert.ToDecimal(dr["Costo"]),
                        Stock = Convert.ToInt32(dr["Stock"]),
                        StockMinimo = Convert.ToInt32(dr["StockMinimo"])
                    });
                }
            }

            return lista;
        }

        // ✔ Insertar nuevo producto
        public void InsertarProducto(Productos p)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO dbo.Productos (Codigo, Nombre, Precio, Costo, Stock, StockMinimo) " +
                    "VALUES (@c, @n, @p, @co, @s, @sm)", con);

                cmd.Parameters.AddWithValue("@c", p.Codigo);
                cmd.Parameters.AddWithValue("@n", p.Nombre);
                cmd.Parameters.AddWithValue("@p", p.Precio);
                cmd.Parameters.AddWithValue("@co", p.Costo);
                cmd.Parameters.AddWithValue("@s", p.Stock);
                cmd.Parameters.AddWithValue("@sm", p.StockMinimo);

                cmd.ExecuteNonQuery();
            }
        }

        // ✔ Editar producto existente
        public void ActualizarProducto(Productos p)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                "UPDATE Productos SET Codigo=@c, Nombre=@n, Precio=@p, Costo=@co, Stock=@s, StockMinimo=@sm " +
                "WHERE ProductoID = @id", con);

                cmd.Parameters.AddWithValue("@id", p.ProductoID);
                cmd.Parameters.AddWithValue("@c", p.Codigo);
                cmd.Parameters.AddWithValue("@n", p.Nombre);
                cmd.Parameters.AddWithValue("@p", p.Precio);
                cmd.Parameters.AddWithValue("@co", p.Costo);
                cmd.Parameters.AddWithValue("@s", p.Stock);
                cmd.Parameters.AddWithValue("@sm", p.StockMinimo);

                cmd.ExecuteNonQuery();
            }
        }

        // ✔ Eliminar producto
        public void EliminarProducto(int id)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM dbo.Productos WHERE ProductoID=@id", con);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }


        public Productos ObtenerProductoPorId(int id)
        {
            using (var connection = Conexion.ObtenerConexion())
            {
                string query = "SELECT * FROM Productos WHERE ProductoID = @Id";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Productos
                            {
                                ProductoID = Convert.ToInt32(reader["ProductoID"]),
                                Codigo = reader["Codigo"].ToString(),
                                Nombre = reader["Nombre"].ToString(),
                                Precio = Convert.ToDecimal(reader["Precio"]),
                                Stock = Convert.ToInt32(reader["Stock"]),
                                StockMinimo = Convert.ToInt32(reader["StockMinimo"]),
                                Costo = Convert.ToDecimal(reader["Costo"]),
                               
                            };
                        }
                    }
                }
            }

            return null;
        }


    }
}
