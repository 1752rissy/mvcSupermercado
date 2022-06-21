using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcSupermercado.Common
{
    internal class ConnectionDBFactory
    {
        private static SqlConnection _connection;

        public static SqlConnection Create()
        {
            var retobj = _connection ?? new SqlConnection("Data Source=DESKTOP-IJN6793;Initial Catalog=SuperMercado;Integrated Security=True");
            return retobj;
        }

#if DEBUG
        /// <summary>
        /// Sólo para Unit Testing y en modo DEBUG.
        /// </summary>
      /*  public static void Set(SqlConnection connection)
        {
            _connection = connection;
        }*/
#endif
    }
}
