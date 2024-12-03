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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(75, Color.Gray);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txbUser.Text, txbPass.Text);
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            if (usuarioDAO.VerificarLogin(usuario))
            {
                txbUser.Text = String.Empty; // Limpa o campo do usúario
                txbPass.Text = String.Empty; // Limpa o campo de senha
                txbUser.Focus(); // Coloca o foco no campo do usúario
                this.Hide(); // Esconder o Form1
                Tela_Usuário telaUsuario = new Tela_Usuário();
                telaUsuario.ShowDialog(); // Abre a tela de usuários
                this.Show(); // Mostrar o Form1 após fechar a tela de usuários
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha incorretos",
                    "ERRO NO LOGIN",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
