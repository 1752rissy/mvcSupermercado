using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvcSupermercado.Modelo;

namespace mvcSupermercado.Controller
{
    public class PedidoController
    {
        PedidoDAO pedidoDAO;

        public PedidoController()
        {
            pedidoDAO = new PedidoDAO();
        }

        /* public List<Producto> ObtenerProductosPorPeido(string pedido)
         {
            return pedidoDAO.ListarProductosPorPedido(pedido);
         }*/

        public List<Pedido> ObtenerPedidos(string pedido)
        {
            return pedidoDAO.ListarProductosPorPedido(pedido);
        }

        public bool AñadirPedido(Pedido pedido)
        {
            return pedidoDAO.AñadirPedido(pedido);
        }

    }
}
