using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvcSupermercado.Controller;
using mvcSupermercado.Modelo;

namespace mvcSupermercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PedidoController controllerPedido = new PedidoController();
            string numeroPedido = "458747";

            Pedido pedido = new Pedido();
            pedido.CodigoPedido = "00005";
            pedido.Fecha = DateTime.Now.ToString();
            
            bool flag = controllerPedido.AñadirPedido(pedido);
            if(flag)
            {
                Console.WriteLine("pedido añadido correctamente");
            }
            else
            {
                Console.WriteLine("algo paso, no se inserto ");
            }



            var productos = controllerPedido.ObtenerPedidos(numeroPedido);




        }
    }
}
