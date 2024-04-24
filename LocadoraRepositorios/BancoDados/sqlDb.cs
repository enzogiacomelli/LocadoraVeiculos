using Microsoft.Data.SqlClient;

namespace LocadoraRepositorios.BancoDados
{
    public class sqlDb
    {
        public static SqlConnection CreateConnection()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\egiac\\source\\repos\\LocadoraVeiculos\\LocadoraRepositorios\\BancoDados\\LocadoraVeiculos.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
