using cafe.Controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace cafe.Model
{
    internal class UsuarioDAO
    {
        private Connection Connect { get; set; }
        private SqlCommand Command { get; set; }

        // Sempre o nome da classe
        public UsuarioDAO()
        {
            Connect = new Connection();
            Command = new SqlCommand();
        }

        public void Insert(Usuario prop)
        {
            using (SqlConnection conn = Connect.ReturnConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO Usuario (Nome, Telefone, CPF, Nome_Login, Senha) 
                                        VALUES (@nome, @telefone, @cpf, @nome_login, @senha)";
                    cmd.Parameters.AddWithValue("@nome", prop.Nome);
                    cmd.Parameters.AddWithValue("@telefone", prop.Telefone);
                    cmd.Parameters.AddWithValue("@cpf", prop.CPF);
                    cmd.Parameters.AddWithValue("@nome_login", prop.Nome_Login);
                    cmd.Parameters.AddWithValue("@senha", prop.Senha);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        throw new Exception("Erro: Problemas ao inserir cadastro no banco.\n" + err.Message);
                    }
                }
            }
        }

        public void Atualizar(Usuario usuarioAtualizado)
        {
            using (SqlConnection conn = Connect.ReturnConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"UPDATE Usuario 
                                        SET Nome = @nome, Telefone = @telefone, CPF = @cpf, 
                                            Nome_Login = @nome_login, Senha = @senha 
                                        WHERE IDusuario = @id";
                    cmd.Parameters.AddWithValue("@nome", usuarioAtualizado.Nome);
                    cmd.Parameters.AddWithValue("@telefone", usuarioAtualizado.Telefone);
                    cmd.Parameters.AddWithValue("@cpf", usuarioAtualizado.CPF);
                    cmd.Parameters.AddWithValue("@nome_login", usuarioAtualizado.Nome_Login);
                    cmd.Parameters.AddWithValue("@senha", usuarioAtualizado.Senha);
                    cmd.Parameters.AddWithValue("@id", usuarioAtualizado.IDusuario);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        throw new Exception("Erro: Problemas ao atualizar o usuário no banco.\n" + err.Message);
                    }
                }
            }
        }

        public void Excluir(int idUsuario)
        {
            using (SqlConnection conn = Connect.ReturnConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"DELETE FROM Usuario WHERE IDusuario = @id";
                    cmd.Parameters.AddWithValue("@id", idUsuario);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        throw new Exception("Erro: Problemas ao excluir o usuário no banco.\n" + err.Message);
                    }
                }
            }
        }

        public List<Usuario> ListarTodosUsuarios()
        {
            using (SqlConnection conn = Connect.ReturnConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Usuario";
                    List<Usuario> listaDeUsuarios = new List<Usuario>();

                    try
                    {
                        SqlDataReader rd = cmd.ExecuteReader();
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

                    return listaDeUsuarios;
                }
            }
        }

        public bool VerificarLogin(Usuario usuario)
        {
            using (SqlConnection conn = Connect.ReturnConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Usuario WHERE Nome_Login = @login AND Senha = @senha";
                    cmd.Parameters.AddWithValue("@login", usuario.Nome_Login);
                    cmd.Parameters.AddWithValue("@senha", usuario.Senha);

                    try
                    {
                        SqlDataReader rd = cmd.ExecuteReader();

                        if (rd.HasRows)
                        {
                            rd.Close();
                            return true;
                        }
                    }
                    catch (Exception err)
                    {
                        throw new Exception("Erro: Problemas ao verificar login de usuários no banco.\n" + err.Message);
                    }

                    return false;
                }
            }
        }
    }
}
