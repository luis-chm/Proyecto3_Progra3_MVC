using Microsoft.Data.SqlClient;

namespace DataAccess.ACME
{
    public class Conexion
    {
        public readonly string? _cadenaConexion;

        public Conexion()
        {
            string? cadenaConexion;
            //obtiene la cadena de conexion de la variable añadida manualmente
            cadenaConexion = Environment.GetEnvironmentVariable("SQLServeEX-MVC");
            _cadenaConexion = cadenaConexion;
        }

        public SqlConnection Conectar()
        {
            SqlConnection sqlConn;
            sqlConn = new SqlConnection(_cadenaConexion);//instancia
            return sqlConn;
        }
    }
}
