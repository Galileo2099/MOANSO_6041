using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prueba11
{
    public class Conexion
    {
        public SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-5080M8C;Initial Catalog=dbo.Productos;Integrated Security=True";
            return cn;
        }
    }
}
