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
        private int Id = -1;

        public Tela_Usuário()
        {
            InitializeComponent();
        }

        //Metodo para limpar Campos
        private void ClearFields()
        {
            txbUser.Clear();
            txb_tel.Clear();
            txbCPF.Clear();
            txb_Login.Clear();
            txb_senha.Clear();
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
        }

        private bool ValidateFields()
        {
            if (txb_Login.Text.Length == 0 || txb_senha.Text.Length == 0)
            {
                MessageBox.Show("Os campos de login e Senha são obrigatórios", "ATENÇÃO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
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

        private void Tela_Usuário_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void UpdateListView()
        {
            listUsuario.Items.Clear();

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            List<Usuario> usuarios = usuarioDAO.ListarTodosUsuarios();

            //This code part access all brokers received from database and iterate by them.
            foreach (Usuario usuario in usuarios)
            {
                //Creating a fully line of listview with items from database.
                ListViewItem item = new ListViewItem(usuario.IDusuario.ToString());
                item.SubItems.Add(usuario.Nome);
                item.SubItems.Add(usuario.Telefone);
                item.SubItems.Add(usuario.CPF);
                item.SubItems.Add(usuario.Nome_Login);
                item.SubItems.Add(usuario.Senha);
                //Adding the fully line to the listview.
                listUsuario.Items.Add(item);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            UsuarioDAO brokerDao = new UsuarioDAO();

            DialogResult resultado = MessageBox.Show("Tem certeza" +
            " que deseja excluir?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    brokerDao.Excluir(Id);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateListView();
                ClearFields();
            }
        }


        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                try
                {
                    //Capture inputed text from fields.
                    new UsuarioDAO().Atualizar(new Usuario(
                        txbUser.Text, txb_tel.Text, txbCPF.Text, 
                        txb_Login.Text, txb_senha.Text));
                    MessageBox.Show("Usuario atualizado!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateListView();
                ClearFields();
            }
        }

        private void listUsuario_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            try
            {
                index = listUsuario.FocusedItem.Index;
                txbUser.Text = listUsuario.Items[index].SubItems[1].Text;
                txb_tel.Text = listUsuario.Items[index].SubItems[2].Text;
                txbCPF.Text = listUsuario.Items[index].SubItems[3].Text;
                txb_Login.Text = listUsuario.Items[index].SubItems[4].Text;
                txb_senha.Text = listUsuario.Items[index].SubItems[5].Text;

                btnDelete.Visible = true;
                btnUpdate.Visible = true;

            }

            catch (Exception)
            {
                MessageBox.Show("Você precisa selecionar uma linha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
        

    

