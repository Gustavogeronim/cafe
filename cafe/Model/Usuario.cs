using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace cafe.Model
{
    internal class Usuario
    {
        public int IDusuario  { get; set; }  
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Nome_Login { get; set; }
        public string Senha {  get; set; }

        public Usuario(int idusuario, string nome, string telefone, string cpf, string nome_login, string senha):this(nome, telefone, 
            cpf, nome_login, senha)
        {
            IDusuario = idusuario;
        }
        public Usuario(
            string nome, string telefone, string cpf, string nome_login, string senha)

        {

            Nome = nome;
            Telefone = telefone;
            CPF = cpf;
            Nome_Login = nome_login;
            Senha = senha;
        }
    }
}
