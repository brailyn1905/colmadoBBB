using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresenacion
{
    public partial class Ventas : Form
    {
        private ProductosBLL negocio = new ProductosBLL();
        // Lista interna para manejar los productos que el cliente agrega al carrito
        private List<Productos> carrito = new List<Productos>();
        VentasBLL ventasBLL = new VentasBLL();
        public Ventas()
        {
            InitializeComponent();
            CargarProductosDisponibles();
        }

        private void CargarProductosDisponibles()
        {
            dgvProductosDisponibles.DataSource = negocio.ObtenerProductos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                string codigo = txtBuscarCodigo.Text.Trim();

                // Si quieres mostrar todos los productos cuando la caja está vacía:
                if (string.IsNullOrEmpty(codigo))
                {
                    dgvProductosDisponibles.DataSource = negocio.ObtenerProductos();
                    return;
                }

                var resultados = negocio.BuscarPorCodigo(codigo);

                // Evitar asignar null al DataSource
                dgvProductosDisponibles.DataSource = resultados ?? new List<Productos>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }
        private void CalcularTotales()
        {
            decimal subtotal = carrito.Sum(x => x.Precio * x.Stock);
            decimal itbis = subtotal * 0.18m;
            decimal total = subtotal + itbis;

            lblSubTotal.Text = subtotal.ToString("C");
            lblITBIS.Text = itbis.ToString("C");
            lblTotal.Text = total.ToString("C");
        }
        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            if (dgvProductosDisponibles.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            var fila = dgvProductosDisponibles.CurrentRow;

            Productos p = new Productos
            {
                ProductoID = Convert.ToInt32(fila.Cells["ProductoID"].Value),
                Nombre = fila.Cells["Nombre"].Value.ToString(),
                Precio = Convert.ToDecimal(fila.Cells["Precio"].Value),
                Stock = Convert.ToInt32(numCantidad.Value) // cantidad a vender
            };

            carrito.Add(p);

            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = carrito;

            CalcularTotales();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void btnQuitarCarrito_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.CurrentRow == null) return;

            int index = dgvCarrito.CurrentRow.Index;
            carrito.RemoveAt(index);

            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = carrito;

            CalcularTotales();
        }

        private void btnProcesarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (carrito.Count == 0)
                {
                    MessageBox.Show("No hay productos en el carrito.");
                    return;
                }

                // Procesar la venta
                int ventaId = ventasBLL.CrearVenta(carrito);

                MessageBox.Show($"Venta procesada correctamente. ID: {ventaId}");

                // Limpiar carrito
                carrito.Clear();
                dgvCarrito.DataSource = null;

                // Recalcular totales
                CalcularTotales();

                // Recargar productos en inventario
                CargarProductosDisponibles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la venta: " + ex.Message);
            }
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            carrito.Clear();
            dgvCarrito.DataSource = null;
            CalcularTotales();
        }
    }
}
