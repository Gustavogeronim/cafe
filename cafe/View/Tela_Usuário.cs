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
            MessageBox.Show("LOGIN CONCLUÍDO",
                "CONCLUÍDO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);

        }
    }
}
