using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    internal class ShellSortAscendente
    {
        public static void ShellSort(List<Floreria> pedidosUrgentes)
        {
            int pedidos = pedidosUrgentes.Count; // Cantidad de elementos en la lista
            int gap = pedidos / 2; // Distancia inicial entre elementos comparados

            // Mientras el salto (gap) sea mayor que cero
            while (gap > 0)
            {
                // Recorremos la lista desde el índice 'gap' hasta el final
                for (int i = gap; i < pedidos; i++)
                {
                    Floreria temp = pedidosUrgentes[i]; // Guardamos el pedido actual
                    int j = i; //Al inicio de cada iteración, j se iguala a i porque vamos a comparar desde esa posición hacia atrás.

                    // Comparamos fechas: si el pedido anterior tiene fecha más lejana, lo movemos
                    while (j >= gap && pedidosUrgentes[j - gap].FechaEntrega > temp.FechaEntrega)
                    {
                        pedidosUrgentes[j] = pedidosUrgentes[j - gap]; // Movemos el pedido con fecha más lejana
                        j -= gap;                  // Retrocedemos para seguir comparando
                    }

                    pedidosUrgentes[j] = temp; // Insertamos el pedido en su nueva posición
                }

                gap /= 2; // Reducimos el salto para la siguiente pasada
            }

            MessageBox.Show("Pedidos ordenados por fecha de entrega en orden ascendente", "PRACTICA-ITSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
