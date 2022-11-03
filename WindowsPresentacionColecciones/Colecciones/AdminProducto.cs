using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsPresentacionColecciones.Models;

namespace WindowsPresentacionColecciones.Colecciones
{
    public static class AdminProducto
    {

        static List<Producto> productos;

        public static List<Producto> Carga()
        {
            productos = new List<Producto>();


            //crear objeto producto
            Producto producto = new Producto() { Nombre = "teclado", Categoria = "hardware", Precio = 222 };
            productos.Add(producto);


            //agregar el producto a la lista
            productos.Add(new Producto() { Nombre = "Monitor", Categoria = "Hardware", Precio = 44 });
            productos.Add(new Producto() { Nombre = "Impresora", Categoria = "Hardware", Precio = 414 });
            productos.Add(new Producto() { Nombre = "Corel", Categoria = "Software", Precio = 12 });
            productos.Add(new Producto() { Nombre = "Office", Categoria = "Software", Precio = 15 });
            return productos;
        }

        public static List<Producto> TraerPorCategoria(Producto producto)
        {
            //TODO Falta programar el metodo Insertar
            return null;
        }

        public static int Insertar(Producto producto)
        {
            //TODO Falta programar el metodo Insertar
            return 0;
        }

        public static int Eliminar(Producto producto)
        {
            //TODO Falta programar el metodo Insertar
            return 0;
        }

    }
}
