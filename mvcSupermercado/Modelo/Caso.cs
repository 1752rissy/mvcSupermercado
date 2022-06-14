using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcSupermercado.Modelo
{
    public class Caso
    {
        public string CodigoCaso { get; set; }  

        public string Titulo { get; set; }  

        public List<Pedido> Pedidos { get; set; }   

        public Caso()
        {
            Pedidos = new List<Pedido>();
        }
    }
}
