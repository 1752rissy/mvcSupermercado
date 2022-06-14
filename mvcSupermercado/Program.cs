using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvcSupermercado.Controller;

namespace mvcSupermercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroPedido = "458747";
            

            PedidoController controllerPedido = new PedidoController();

            var productos = controllerPedido.ObtenerProductosPorPeido(numeroPedido);




        }
    }
}
