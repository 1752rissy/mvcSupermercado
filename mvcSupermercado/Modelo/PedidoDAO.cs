using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcSupermercado.Modelo
{
    //todas las transacciones a base de datos que corresponden a pedidos 
    public class PedidoDAO
    {
        public List<Producto> ListarProductosPorPedido(/*List<Producto> productos,*/  string codigoPedido /*, Producto producto*/)
        {
           // productos.FindAll(x => productos.Contains(producto));
            return new List<Producto> { new Producto { } };
        }


    }
}
