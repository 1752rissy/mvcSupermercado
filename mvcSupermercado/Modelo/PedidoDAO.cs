using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvcSupermercado.Common;

namespace mvcSupermercado.Modelo
{
    //todas las transacciones a base de datos que corresponden a pedidos 
    public class PedidoDAO
    {
        private SqlConnection _connectionDb;
        public PedidoDAO()
        {
            _connectionDb = ConnectionDBFactory.Create();
        }

        public bool AñadirPedido(Pedido pedido)
        {
            var query = "insert into Pedido(codigoPedido,fecha) values(@CodigoPedido, @Fecha)";
            var command = new SqlCommand(query, _connectionDb);
            command.Parameters.AddWithValue("@CodigoPedido", pedido.CodigoPedido);
            command.Parameters.AddWithValue("@Fecha",DateTime.Parse(pedido.Fecha));
            _connectionDb.Open();
            int result = command.ExecuteNonQuery();
            if(result == 0)
                return false;   
            else
                return true;
        }

        public List<Pedido> ListarProductosPorPedido(/*List<Producto> productos,*/  string codigoPedido /*, Producto producto*/)
        {
            // productos.FindAll(x => productos.Contains(producto));
            // return new List<Producto> { new Producto { } };

            var query = "SELECT codigoPedido, fecha from PEDIDO";

            var command = new SqlCommand(query, _connectionDb);

            var adapater = new SqlDataAdapter(command);

            var ds = new DataSet();

            adapater.Fill(ds, "PEDIDO");

            List<Pedido> listaPedido = new List<Pedido>();

            foreach(DataRow pedidoRow in ds.Tables[0].Rows)
            {
                var Pedido = new Pedido();
                Pedido.CodigoPedido = pedidoRow["codigoPedido"].ToString();
                Pedido.Fecha = pedidoRow["fecha"].ToString();
                listaPedido.Add(Pedido);
            }

            return listaPedido;
        }


    }
}
