using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaNegocio.Eventos;

namespace CapaNegocio
{
    public class Inventario
    {
        public event InventarioBajoHandler InventarioBajo;

        private Dictionary<string, Productos> productos = new Dictionary<string, Productos>();

        public Dictionary<string, Productos> ObtenerTodo() => productos;

        public void CargarProductosParallel(List<Productos> lista)
        {
            lista.AsParallel().ForAll(p =>
            {
                productos[p.Codigo] = p;
                if (p.InventarioBajo)
                    InventarioBajo?.Invoke(p);
            });
        }

        public Productos Buscar(string codigo)
        {
            if (!productos.ContainsKey(codigo))
                throw new CodigoInvalidoException("Producto no encontrado");

            return productos[codigo];
        }
    }
}
