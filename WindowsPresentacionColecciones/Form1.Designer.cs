namespace WindowsPresentacionColecciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuardarAlumnoLista = new System.Windows.Forms.Button();
            this.btnMostrarProductos = new System.Windows.Forms.Button();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.lstPrecioProducto = new System.Windows.Forms.ListBox();
            this.btnCrearCliente = new System.Windows.Forms.Button();
            this.btnCrearEmpleado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarAlumnoLista
            // 
            this.btnGuardarAlumnoLista.Location = new System.Drawing.Point(232, 160);
            this.btnGuardarAlumnoLista.Name = "btnGuardarAlumnoLista";
            this.btnGuardarAlumnoLista.Size = new System.Drawing.Size(159, 23);
            this.btnGuardarAlumnoLista.TabIndex = 0;
            this.btnGuardarAlumnoLista.Text = "Guardar Productos Lista";
            this.btnGuardarAlumnoLista.UseVisualStyleBackColor = true;
            this.btnGuardarAlumnoLista.Click += new System.EventHandler(this.btnGuardarAlumnoLista_Click);
            // 
            // btnMostrarProductos
            // 
            this.btnMostrarProductos.Location = new System.Drawing.Point(232, 207);
            this.btnMostrarProductos.Name = "btnMostrarProductos";
            this.btnMostrarProductos.Size = new System.Drawing.Size(159, 23);
            this.btnMostrarProductos.TabIndex = 1;
            this.btnMostrarProductos.Text = "Mostrar Productos Lista";
            this.btnMostrarProductos.UseVisualStyleBackColor = true;
            this.btnMostrarProductos.Click += new System.EventHandler(this.btnMostrarProductos_Click);
            // 
            // gridProductos
            // 
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Location = new System.Drawing.Point(195, 251);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(240, 150);
            this.gridProductos.TabIndex = 2;
            // 
            // lstPrecioProducto
            // 
            this.lstPrecioProducto.FormattingEnabled = true;
            this.lstPrecioProducto.Location = new System.Drawing.Point(455, 251);
            this.lstPrecioProducto.Name = "lstPrecioProducto";
            this.lstPrecioProducto.Size = new System.Drawing.Size(136, 147);
            this.lstPrecioProducto.TabIndex = 3;
            // 
            // btnCrearCliente
            // 
            this.btnCrearCliente.Location = new System.Drawing.Point(455, 160);
            this.btnCrearCliente.Name = "btnCrearCliente";
            this.btnCrearCliente.Size = new System.Drawing.Size(106, 38);
            this.btnCrearCliente.TabIndex = 4;
            this.btnCrearCliente.Text = "Crear Clientes";
            this.btnCrearCliente.UseVisualStyleBackColor = true;
            this.btnCrearCliente.Click += new System.EventHandler(this.btnCrearCliente_Click);
            // 
            // btnCrearEmpleado
            // 
            this.btnCrearEmpleado.Location = new System.Drawing.Point(626, 160);
            this.btnCrearEmpleado.Name = "btnCrearEmpleado";
            this.btnCrearEmpleado.Size = new System.Drawing.Size(108, 38);
            this.btnCrearEmpleado.TabIndex = 5;
            this.btnCrearEmpleado.Text = "Crear Empleado";
            this.btnCrearEmpleado.UseVisualStyleBackColor = true;
            this.btnCrearEmpleado.Click += new System.EventHandler(this.btnCrearEmpleado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearEmpleado);
            this.Controls.Add(this.btnCrearCliente);
            this.Controls.Add(this.lstPrecioProducto);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.btnMostrarProductos);
            this.Controls.Add(this.btnGuardarAlumnoLista);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarAlumnoLista;
        private System.Windows.Forms.Button btnMostrarProductos;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.ListBox lstPrecioProducto;
        private System.Windows.Forms.Button btnCrearCliente;
        private System.Windows.Forms.Button btnCrearEmpleado;
    }
}

