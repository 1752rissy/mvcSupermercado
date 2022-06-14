using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcSupermercado.Modelo
{
    public class Pedido
    {
        public string  CodigoPedido { get; set; }
        
        public string Fecha { get; set; }

        public List<Producto> productos { get; set; }
    }
}
