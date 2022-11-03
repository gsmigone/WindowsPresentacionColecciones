using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsPresentacionColecciones.Models;
using WindowsPresentacionColecciones.Colecciones;
using WindowsPresentacionColecciones.PruebaStatic;

namespace WindowsPresentacionColecciones
{
    public partial class Form1 : Form
    {
        //declarar y crear la lista
        List<Producto> productos; 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardarAlumnoLista_Click(object sender, EventArgs e)
        {

           /* productos = new List<Producto>();


            //crear objeto producto
            Producto producto = new Producto() { Nombre = "teclado", Categoria = "hardware", Precio = 222 };
            productos.Add(producto);


            //agregar el producto a la lista
            productos.Add(new Producto() { Nombre = "Monitor", Categoria = "Hardware", Precio = 44 });
            productos.Add(new Producto() { Nombre = "Impresora", Categoria = "Hardware", Precio = 414 });
           */
        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {

            List<Producto> lista;

            
            //AdminProducto adminProducto = new AdminProducto();
            lista = AdminProducto.Carga();
            

            gridProductos.DataSource = lista;

            foreach(Producto producto in lista)
            {
                lstPrecioProducto.Items.Add(producto.Nombre + " Precio:" + producto.Precio.ToString());
            }
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente1 = new Cliente("Gaby");
            Cliente cliente2 = new Cliente("Gustavo");

            MessageBox.Show(Cliente.Instancias.ToString());

            Cliente cliente3 = new Cliente("Tongas");
            Cliente cliente4 = new Cliente("Gastongas");

            MessageBox.Show(Cliente.Instancias.ToString());
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            Empleado empleado1 = new Empleado(1,"Gaby","G");
            Empleado empleado2 = new Empleado(2,"Gustavo","S");
            Empleado.SetComision(20);

            MessageBox.Show(Empleado.GetComision.ToString());

            Empleado empleado3 = new Empleado(3,"Tongas","M");
            Empleado empleado4 = new Empleado(4,"Gastongas","I");
            Empleado.SetComision(30);

            MessageBox.Show(Empleado.GetComision.ToString());

        }
    }
}
