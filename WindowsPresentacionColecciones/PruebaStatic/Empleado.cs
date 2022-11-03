using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsPresentacionColecciones.PruebaStatic
{
    public class Empleado
    {       
            public Empleado(int id,string nombre,string apellido)
            {
                ID = id;
                Nombre = nombre;
                Apellido = apellido;
                
            }
            public int ID { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }

            private static decimal comision_;

            public static decimal GetComision
            {
                get { return comision_; }
            }
            public static void SetComision(decimal comision)
            {
                comision_ = comision;
            }
        
    }
}
