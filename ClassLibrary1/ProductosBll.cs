using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ProductosBLL
    {
        private ProductosDAL datos = new ProductosDAL();

        // ✔ Obtener productos
        public List<Productos> ObtenerProductos()
        {
            return datos.ObtenerProductos();
        }

        // ✔ Agregar nuevo producto
        public void AgregarProducto(Productos p)
        {
            // Validaciones antes de guardar
            if (string.IsNullOrWhiteSpace(p.Codigo))
                throw new Exception("El código del producto es obligatorio.");

            if (string.IsNullOrWhiteSpace(p.Nombre))
                throw new Exception("El nombre del producto es obligatorio.");

            if (p.Precio <= 0)
                throw new Exception("El precio debe ser mayor a 0.");

            if (p.Costo < 0)
                throw new Exception("El costo no puede ser negativo.");

            if (p.Stock < 0)
                throw new Exception("El stock no puede ser negativo.");

            if (p.StockMinimo < 0)
                throw new Exception("El stock mínimo no puede ser negativo.");

            datos.InsertarProducto(p);
        }

        // ✔ Actualizar producto
        public void ActualizarProducto(Productos p)
        {
            if (p.ProductoID <= 0)
                throw new Exception("ID de producto inválido.");

            // Validaciones
            if (string.IsNullOrWhiteSpace(p.Codigo))
                throw new Exception("El código del producto es obligatorio.");

            if (string.IsNullOrWhiteSpace(p.Nombre))
                throw new Exception("El nombre del producto es obligatorio.");

            if (p.Precio <= 0)
                throw new Exception("El precio debe ser mayor a 0.");

            if (p.Costo < 0)
                throw new Exception("El costo no puede ser negativo.");

            if (p.Stock < 0)
                throw new Exception("El stock no puede ser negativo.");

            if (p.StockMinimo < 0)
                throw new Exception("El stock mínimo no puede ser negativo.");

            datos.ActualizarProducto(p);
        }

        // ✔ Eliminar producto
        public void EliminarProducto(int id)
        {
            if (id <= 0)
                throw new Exception("ID inválido para eliminar.");

            datos.EliminarProducto(id);
        }
        //étodo que solo devuelva la lista filtrada por el stock bajo
        public List<Productos> ObtenerProductosStockBajo()
        {
            var productos = datos.ObtenerProductos();

            return productos
                .Where(p => p.InventarioBajo)
                .ToList();
        }

        public Productos BuscarProductoPorId(int id)
        {
            if (id <= 0)
                throw new Exception("El ID debe ser mayor que 0.");

            return datos.ObtenerProductoPorId(id);
        }

        
        // metodo para buscar por codigo
        public List<Productos> BuscarPorCodigo(string codigo)
        {
            codigo = codigo?.Trim() ?? string.Empty;
            return datos.BuscarPorCodigo(codigo);
        }
    }
}
