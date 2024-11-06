using cafe.Controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe.Model
{
    internal class UsuarioDAO
    {
        private Connection Connect { get; set; }
        private SqlCommand Command { get; set; }
        //Sempre o nome da classe
        public UsuarioDAO()
        {
            Connect = new Connection();
            Command = new SqlCommand();
        }
        public void Insert(Usuario prop)
        {
            //definir a conexão
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"INSERT INTO Usuario VALUES 
            (@nome, @telefone, @cpf, @nome_login, @senha)";

            Command.Parameters.AddWithValue("@Nome", prop.Nome);
            Command.Parameters.AddWithValue("@Telefone", prop.Telefone);
            Command.Parameters.AddWithValue("@CPF", prop.CPF);
            Command.Parameters.AddWithValue("Nome_login", prop.Nome_Login);
            Command.Parameters.AddWithValue("Senha", prop.Senha);

            try
            {
                //Executa query definida acima.
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir " +
                    "cadastro no banco.\n" + err.Message);
            }
            finally
            { 
                Connect.CloseConnection();
            }
        }

        public void Atualizar(Usuario usuarioAtualizado)
        {
            Command.Connection = Connect.ReturnConnection();

            Command.CommandText = @"UPDATE Usuario SET Nome = @nome, Telefone = @tel,
    CPF = @cpf, Nome_Login = @nome_login, Senha = @senha 
    WHERE IDusuario = @id";
            Command.Parameters.AddWithValue("@nome", usuarioAtualizado.Nome);
            Command.Parameters.AddWithValue("@tel", usuarioAtualizado.Telefone);
            Command.Parameters.AddWithValue("@CPF", usuarioAtualizado.CPF);
            Command.Parameters.AddWithValue("@nome_login", usuarioAtualizado.Nome_Login);
            Command.Parameters.AddWithValue("@senha", usuarioAtualizado.Senha);
            Command.Parameters.AddWithValue("@id", usuarioAtualizado.IDusuario);
            
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar atualização de usuário no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }

        public void Excluir(int idUsuario)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"DELETE FROM Usuario WHERE IDusuario = @id";
            Command.Parameters.AddWithValue("@id", idUsuario);
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        public List<Usuario> ListarTodosUsuarios()
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Usuarios";

            List<Usuario> listaDeUsuarios = new List<Usuario>(); //Instancia a lista com o tamanho padrão.
            try
            {
                SqlDataReader rd = Command.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Usuario usuario = new Usuario(
                        (int)rd["IDusuario"],
                        (string)rd["Nome"],
                        (string)rd["Telefone"], 
                        (string)rd["CPF"],
                        (string)rd["Nome_Login"],
                        (string)rd["Senha"]);
                    listaDeUsuarios.Add(usuario);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }

            return listaDeUsuarios;
        }
        public bool Verificarlogin(Usuario usuario)
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Usuario where Nome_Login =@login AND Senha = @senha";
            Command.Parameters.AddWithValue("@login", usuario.Nome_Login);
            Command.Parameters.AddWithValue("@senha", usuario.Senha);

            try
            {
                SqlDataReader rd = Command.ExecuteReader();

                if (rd.HasRows)
                {
                    rd.Close();
                    return true;
                }

            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }

            return false;
        }
    }
}
