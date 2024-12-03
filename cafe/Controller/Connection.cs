using System;
using System.Data.SqlClient;

namespace cafe.Controller
{
    internal class Connection
    {
        private SqlConnection con;
        private static string DataBase = "PR2CJ3022374CAFETERIA";
        private static string Server = @"MUSHU";

        public Connection()
        {
            string stringConnection =
            @"Data Source=" + Server
            + "; Initial Catalog=" + DataBase
            + "; Integrated Security=True; Encrypt=false";
            con = new SqlConnection(stringConnection);
            con.Open(); // Abrir a conexão com o banco
        }

        // Tenta fechar a conexão que foi aberta
        public void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }

        // Retorna a conexão que foi aberta
        public SqlConnection ReturnConnection()
        {
            return con;
        }
    }
}
