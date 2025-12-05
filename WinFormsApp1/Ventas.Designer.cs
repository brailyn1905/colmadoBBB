namespace CapaPresenacion
{
    partial class Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProductosDisponibles = new DataGridView();
            label1 = new Label();
            txtBuscarCodigo = new TextBox();
            btnBuscar = new Button();
            numCantidad = new NumericUpDown();
            btnAgregarCarrito = new Button();
            dgvCarrito = new DataGridView();
            btnQuitarCarrito = new Button();
            lblSubTotal = new Label();
            lblITBIS = new Label();
            lblTotal = new Label();
            btnProcesarVenta = new Button();
            btnCancelarVenta = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductosDisponibles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // dgvProductosDisponibles
            // 
            dgvProductosDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosDisponibles.Location = new Point(32, 168);
            dgvProductosDisponibles.Name = "dgvProductosDisponibles";
            dgvProductosDisponibles.Size = new Size(348, 183);
            dgvProductosDisponibles.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 92);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 1;
            label1.Text = "Buscar por codigo ";
            // 
            // txtBuscarCodigo
            // 
            txtBuscarCodigo.Location = new Point(144, 92);
            txtBuscarCodigo.Name = "txtBuscarCodigo";
            txtBuscarCodigo.Size = new Size(100, 23);
            txtBuscarCodigo.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(273, 92);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(47, 381);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(120, 23);
            numCantidad.TabIndex = 4;
            // 
            // btnAgregarCarrito
            // 
            btnAgregarCarrito.Location = new Point(65, 432);
            btnAgregarCarrito.Name = "btnAgregarCarrito";
            btnAgregarCarrito.Size = new Size(143, 23);
            btnAgregarCarrito.TabIndex = 5;
            btnAgregarCarrito.Text = "Agregar al carrito";
            btnAgregarCarrito.UseVisualStyleBackColor = true;
            btnAgregarCarrito.Click += btnAgregarCarrito_Click;
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(514, 168);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.Size = new Size(325, 183);
            dgvCarrito.TabIndex = 6;
            // 
            // btnQuitarCarrito
            // 
            btnQuitarCarrito.Location = new Point(526, 381);
            btnQuitarCarrito.Name = "btnQuitarCarrito";
            btnQuitarCarrito.Size = new Size(169, 23);
            btnQuitarCarrito.TabIndex = 7;
            btnQuitarCarrito.Text = "quitar del carrito ";
            btnQuitarCarrito.UseVisualStyleBackColor = true;
            btnQuitarCarrito.Click += btnQuitarCarrito_Click;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(301, 402);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(51, 15);
            lblSubTotal.TabIndex = 8;
            lblSubTotal.Text = "Subtotal";
            // 
            // lblITBIS
            // 
            lblITBIS.AutoSize = true;
            lblITBIS.Location = new Point(301, 440);
            lblITBIS.Name = "lblITBIS";
            lblITBIS.Size = new Size(36, 15);
            lblITBIS.TabIndex = 9;
            lblITBIS.Text = " ITBIS";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(301, 487);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 15);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "Total";
            // 
            // btnProcesarVenta
            // 
            btnProcesarVenta.Location = new Point(541, 458);
            btnProcesarVenta.Name = "btnProcesarVenta";
            btnProcesarVenta.Size = new Size(154, 23);
            btnProcesarVenta.TabIndex = 11;
            btnProcesarVenta.Text = "Procesar venta ";
            btnProcesarVenta.UseVisualStyleBackColor = true;
            btnProcesarVenta.Click += btnProcesarVenta_Click;
            // 
            // btnCancelarVenta
            // 
            btnCancelarVenta.Location = new Point(766, 454);
            btnCancelarVenta.Name = "btnCancelarVenta";
            btnCancelarVenta.Size = new Size(118, 23);
            btnCancelarVenta.TabIndex = 12;
            btnCancelarVenta.Text = "Canselar Venta ";
            btnCancelarVenta.UseVisualStyleBackColor = true;
            btnCancelarVenta.Click += btnCancelarVenta_Click;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 541);
            Controls.Add(btnCancelarVenta);
            Controls.Add(btnProcesarVenta);
            Controls.Add(lblTotal);
            Controls.Add(lblITBIS);
            Controls.Add(lblSubTotal);
            Controls.Add(btnQuitarCarrito);
            Controls.Add(dgvCarrito);
            Controls.Add(btnAgregarCarrito);
            Controls.Add(numCantidad);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarCodigo);
            Controls.Add(label1);
            Controls.Add(dgvProductosDisponibles);
            Name = "Ventas";
            Text = "Ventas";
            Load += Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductosDisponibles).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductosDisponibles;
        private Label label1;
        private TextBox txtBuscarCodigo;
        private Button btnBuscar;
        private NumericUpDown numCantidad;
        private Button btnAgregarCarrito;
        private DataGridView dgvCarrito;
        private Button btnQuitarCarrito;
        private Label lblSubTotal;
        private Label lblITBIS;
        private Label lblTotal;
        private Button btnProcesarVenta;
        private Button btnCancelarVenta;
    }
}