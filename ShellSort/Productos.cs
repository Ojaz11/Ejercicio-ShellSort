using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    public class Productos
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Productos(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}
