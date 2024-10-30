using cafe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe
{
    public partial class Tela_Usuário : Form
    {
        public Tela_Usuário()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(75, Color.Gray);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txbUser.Text;
            string telefone = txb_tel.Text;
            string cpf = txbCPF.Text;
            string nome_login = txb_Login.Text;
            string senha = txb_senha.Text;


            //cria objeto do tipo da entidade manipulada.
            Usuario usuario = new Usuario(nome, telefone, cpf, nome_login, senha);

            //cria objeto para interação com o banco de dados.
            UsuarioDAO usuarioDAO = new UsuarioDAO();

            //chama o insert
            usuarioDAO.Insert(usuario);
                 

         
            MessageBox.Show("LOGIN CONCLUÍDO",
                "CONCLUÍDO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);

        }
    }
}
