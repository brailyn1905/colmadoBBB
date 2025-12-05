namespace CapaPresenacion
{
    partial class GestiónInventario
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
            btnAgregar = new Button();
            button2 = new Button();
            button3 = new Button();
            dgvProductos = new DataGridView();
            btnActualizar = new Button();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            txtStock = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCodigoProducto = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtStockMinimo = new TextBox();
            txtCosto = new TextBox();
            label6 = new Label();
            txtID = new TextBox();
            dataGridViewStockBajo = new DataGridView();
            txtBuscarID = new TextBox();
            btnBuscarID = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStockBajo).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(52, 88);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(169, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar Nuevo Producto";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(268, 88);
            button2.Name = "button2";
            button2.Size = new Size(194, 23);
            button2.TabIndex = 1;
            button2.Text = "Editar Producto Selecionado";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(508, 88);
            button3.Name = "button3";
            button3.Size = new Size(171, 23);
            button3.TabIndex = 2;
            button3.Text = "Eliminar Producto";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 144);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(593, 231);
            dgvProductos.TabIndex = 3;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(738, 88);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar inventario ";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(688, 174);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(688, 129);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(688, 219);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(632, 137);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(639, 177);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 9;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(641, 227);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 10;
            label3.Text = "Estock";
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Location = new Point(688, 268);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(100, 23);
            txtCodigoProducto.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(602, 314);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 13;
            label5.Text = "Stock Minimo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(633, 276);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 14;
            label4.Text = "Codigo";
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Location = new Point(688, 306);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(100, 23);
            txtStockMinimo.TabIndex = 15;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(688, 349);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(100, 23);
            txtCosto.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(634, 352);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 17;
            label6.Text = "Costo";
            // 
            // txtID
            // 
            txtID.Location = new Point(688, 388);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 18;
            // 
            // dataGridViewStockBajo
            // 
            dataGridViewStockBajo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStockBajo.Location = new Point(22, 406);
            dataGridViewStockBajo.Name = "dataGridViewStockBajo";
            dataGridViewStockBajo.Size = new Size(570, 150);
            dataGridViewStockBajo.TabIndex = 19;
            // 
            // txtBuscarID
            // 
            txtBuscarID.Location = new Point(713, 449);
            txtBuscarID.Name = "txtBuscarID";
            txtBuscarID.Size = new Size(100, 23);
            txtBuscarID.TabIndex = 20;
            // 
            // btnBuscarID
            // 
            btnBuscarID.Location = new Point(688, 503);
            btnBuscarID.Name = "btnBuscarID";
            btnBuscarID.Size = new Size(75, 23);
            btnBuscarID.TabIndex = 21;
            btnBuscarID.Text = "Buscar";
            btnBuscarID.UseVisualStyleBackColor = true;
            btnBuscarID.Click += btnBuscarID_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(622, 457);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 22;
            label7.Text = "Buscar po ID";
            // 
            // GestiónInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 568);
            Controls.Add(label7);
            Controls.Add(btnBuscarID);
            Controls.Add(txtBuscarID);
            Controls.Add(dataGridViewStockBajo);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(txtCosto);
            Controls.Add(txtStockMinimo);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtCodigoProducto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtStock);
            Controls.Add(txtNombre);
            Controls.Add(txtPrecio);
            Controls.Add(btnActualizar);
            Controls.Add(dgvProductos);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnAgregar);
            Name = "GestiónInventario";
            Text = "GestiónInventario";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStockBajo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button button2;
        private Button button3;
        private DataGridView dgvProductos;
        private Button btnActualizar;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private TextBox txtStock;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCodigoProducto;
        private Label label5;
        private Label label4;
        private TextBox txtStockMinimo;
        private TextBox txtCosto;
        private Label label6;
        private TextBox txtID;
        private DataGridView dataGridViewStockBajo;
        private TextBox txtBuscarID;
        private Button btnBuscarID;
        private Label label7;
    }
}