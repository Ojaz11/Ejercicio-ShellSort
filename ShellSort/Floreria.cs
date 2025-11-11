using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    public class Floreria
    {
        public string NombreCliente { get; set; }
        public List<Productos> NombreProducto { get; set; } 
        public DateTime FechaEntrega { get; set; }

        public Floreria(string nombreCliente, DateTime fechaEntrega)
        {
            NombreCliente=nombreCliente;
            NombreProducto = new List<Productos>();
            FechaEntrega=fechaEntrega;
        }

        public List<Productos> productosDisponibles = new List<Productos>
        {
            new Productos("Paz y Recuerdo", 220),
            new Productos("Serenidad Blanca", 250),
            new Productos("Abrazo Floral", 280),
            new Productos("Toque de Distinción", 300),
            new Productos("Armonía Floral", 270),
            new Productos("Elegancia Natural", 320),
            new Productos("Amor Eterno", 250),
            new Productos("Susurros de Rosas", 260),
            new Productos("Te Amo Hoy y Siempre", 280)
        };
    }
}
