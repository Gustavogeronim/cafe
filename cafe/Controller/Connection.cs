using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe.Controller
{
    internal class Connection
    {
        private SqlConnection con;
        private string DataBase = "PR2CJ3022374CAFETERIA";
        private string Server = "sqlexpress";
        private string Username = "aluno";
        private string Password = "aluno";

        public Connection()
        {
            string stringConnection =
            @"Data Source =" + Server
            + "; Initial Catalog =" + DataBase
            + "; User Id =" + Username
            + "; password =" + Password
            + "; Encrypt = false";
            con = new SqlConnection(stringConnection);
            con.Open(); // Abrir a conexão com o banco
        }

        // Tenta fechar  a conexão que foi aberta 
        public void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open) 
                con.Close();
        }
        //Retorna a conexão que foi aberta 
        public SqlConnection ReturnConnection()
        {
            return con;
        }
    }
}
