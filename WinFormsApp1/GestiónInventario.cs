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
    public partial class GestiónInventario : Form
    {

        ProductosBLL negocio = new ProductosBLL();
        private int productoSeleccionadoID = 0;
        public GestiónInventario()
        {
            InitializeComponent();
            CargarProductos();
            CargarProductosStockBajo();


        }

        private void CargarProductosStockBajo()
        {
            dataGridViewStockBajo.DataSource = negocio.ObtenerProductosStockBajo();
        }
        private void CargarProductos()
        {
            dgvProductos.DataSource = negocio.ObtenerProductos();
        }


        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return; // evita errores si haces clic en el header

            var fila = dgvProductos.Rows[e.RowIndex];

            //txtID.Text = fila.Cells["ProductoID"].Value?.ToString();
            txtCodigoProducto.Text = fila.Cells["Código"].Value?.ToString();
            txtNombre.Text = fila.Cells["Nombre"].Value?.ToString();
            txtPrecio.Text = fila.Cells["Precio"].Value?.ToString();
            txtStock.Text = fila.Cells["Stock"].Value?.ToString();
            txtStockMinimo.Text = fila.Cells["StockMinimo"].Value?.ToString();
            txtCosto.Text = fila.Cells["Costo"].Value?.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //if (string.IsNullOrWhiteSpace(txtID.Text))
                  //  throw new Exception("Debe seleccionar un producto de la tabla.");

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                    throw new Exception("El campo NOMBRE no puede estar vacío.");

                if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
                    throw new Exception("El precio no es válido.");

                if (!int.TryParse(txtStock.Text, out int stock))
                    throw new Exception("El stock no es válido.");

                if (!decimal.TryParse(txtCosto.Text, out decimal costo))
                    throw new Exception("El costo no es válido.");

                if (!int.TryParse(txtStockMinimo.Text, out int stockMinimo))
                    throw new Exception("El stock mínimo no es válido.");

                Productos p = new Productos
                {
                   // ProductoID = int.Parse(txtID.Text),            // 🔥 ID correcto
                    Codigo = txtCodigoProducto.Text.Trim(),        // Código
                    Nombre = txtNombre.Text.Trim(),
                    Precio = precio,
                    Stock = stock,
                    Costo = costo,
                    StockMinimo = stockMinimo
                };

                negocio.ActualizarProducto(p);

                MessageBox.Show("Producto actualizado correctamente.");

                CargarProductos();
                Limpiar();
                CargarProductosStockBajo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                    throw new Exception("El campo NOMBRE no puede estar vacío.");

                if (string.IsNullOrWhiteSpace(txtPrecio.Text))
                    throw new Exception("El campo PRECIO no puede estar vacío.");

                if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
                    throw new Exception("El formato del PRECIO no es válido.");

                if (string.IsNullOrWhiteSpace(txtStock.Text))
                    throw new Exception("El campo STOCK no puede estar vacío.");

                if (!int.TryParse(txtStock.Text, out int stock))
                    throw new Exception("El formato del STOCK no es válido.");

                if (string.IsNullOrWhiteSpace(txtCosto.Text))
                    throw new Exception("El campo COSTO no puede estar vacío.");

                if (!decimal.TryParse(txtCosto.Text, out decimal costo))
                    throw new Exception("El formato del COSTO no es válido.");

                if (string.IsNullOrWhiteSpace(txtStockMinimo.Text))
                    throw new Exception("El campo STOCK MÍNIMO no puede estar vacío.");

                if (!int.TryParse(txtStockMinimo.Text, out int stockMinimo))
                    throw new Exception("El formato del STOCK MÍNIMO no es válido.");

                // Crear producto
                Productos p = new Productos
                {

                    Codigo = txtCodigoProducto.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Precio = precio,
                    Stock = stock,
                    Costo = costo,
                    StockMinimo = stockMinimo
                };


                negocio.AgregarProducto(p);

                MessageBox.Show("Producto agregado correctamente.");

                Limpiar();
                CargarProductos();
                CargarProductosStockBajo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠ Error: " + ex.Message);
            }
        }

        //boton para editar  producto 
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de ID
                //if (string.IsNullOrWhiteSpace(txtID.Text))
                   // throw new Exception("Debe seleccionar un producto de la tabla.");

                // Validaciones de campos
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                    throw new Exception("El campo NOMBRE no puede estar vacío.");

                if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
                    throw new Exception("El formato del PRECIO no es válido.");

                if (!int.TryParse(txtStock.Text, out int stock))
                    throw new Exception("El formato del STOCK no es válido.");

                if (!decimal.TryParse(txtCosto.Text, out decimal costo))
                    throw new Exception("El formato del COSTO no es válido.");

                if (!int.TryParse(txtStockMinimo.Text, out int stockMinimo))
                    throw new Exception("El formato del STOCK MÍNIMO no es válido.");

                // Crear producto
                Productos p = new Productos
                {
                   // ProductoID = int.Parse(txtID.Text),   // ← CORREGIDO
                    Codigo = txtCodigoProducto.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Precio = precio,
                    Stock = stock,
                    Costo = costo,
                    StockMinimo = stockMinimo
                };

                negocio.ActualizarProducto(p);

                MessageBox.Show("Producto actualizado correctamente.");

                Limpiar();
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        //boton para eliminar producto 
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que haya una fila seleccionada
                if (dgvProductos.SelectedRows.Count == 0)
                    throw new Exception("Debe seleccionar un producto para eliminar.");

                // Tomar el ID desde la fila seleccionada del DataGridView
                int id = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["ProductoID"].Value);

                DialogResult r = MessageBox.Show(
                    "¿Desea eliminar este producto?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (r == DialogResult.No) return;

                // Eliminar desde la capa negocio
                negocio.EliminarProducto(id);

                MessageBox.Show("Producto eliminado correctamente.");

                // Refrescar tablas
                CargarProductos();
                CargarProductosStockBajo();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Limpiar()
        {
            txtCodigoProducto.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtCosto.Clear();
            txtStockMinimo.Clear();
        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtBuscarID.Text, out int id))
                {
                    MessageBox.Show("Debe escribir un ID válido.");
                    return;
                }

                var producto = negocio.BuscarProductoPorId(id);

                if (producto == null)
                {
                    MessageBox.Show("No se encontró ningún producto con ese ID.");
                    return;
                }

                // llenar los campos
                txtID.Text = producto.ProductoID.ToString();
                txtCodigoProducto.Text = producto.Codigo;
                txtNombre.Text = producto.Nombre;
                txtPrecio.Text = producto.Precio.ToString();
                txtCosto.Text = producto.Costo.ToString();
                txtStock.Text = producto.Stock.ToString();
                txtStockMinimo.Text = producto.StockMinimo.ToString();

                MessageBox.Show("Producto encontrado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
