namespace cafe
{
    partial class Tela_Usuário
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.txb_senha = new System.Windows.Forms.TextBox();
            this.txb_Login = new System.Windows.Forms.TextBox();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txb_tel = new System.Windows.Forms.TextBox();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listUsuario = new System.Windows.Forms.ListView();
            this.clmNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLogin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSenha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.clmid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txb_senha);
            this.panel2.Controls.Add(this.txb_Login);
            this.panel2.Controls.Add(this.txbCPF);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txb_tel);
            this.panel2.Controls.Add(this.txbUser);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(35, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 482);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txb_senha
            // 
            this.txb_senha.Location = new System.Drawing.Point(109, 368);
            this.txb_senha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_senha.Name = "txb_senha";
            this.txb_senha.Size = new System.Drawing.Size(132, 22);
            this.txb_senha.TabIndex = 12;
            // 
            // txb_Login
            // 
            this.txb_Login.Location = new System.Drawing.Point(109, 331);
            this.txb_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_Login.Name = "txb_Login";
            this.txb_Login.Size = new System.Drawing.Size(132, 22);
            this.txb_Login.TabIndex = 11;
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(109, 295);
            this.txbCPF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(132, 22);
            this.txbCPF.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 297);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 332);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome_Login:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 369);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Senha:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(109, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 431);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Concluir Cadastro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_tel
            // 
            this.txb_tel.Location = new System.Drawing.Point(109, 261);
            this.txb_tel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_tel.Name = "txb_tel";
            this.txb_tel.Size = new System.Drawing.Size(132, 22);
            this.txb_tel.TabIndex = 3;
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(109, 229);
            this.txbUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(132, 22);
            this.txbUser.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // listUsuario
            // 
            this.listUsuario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmid,
            this.clmNome,
            this.clmTelefone,
            this.clmCPF,
            this.clmLogin,
            this.clmSenha});
            this.listUsuario.HideSelection = false;
            this.listUsuario.Location = new System.Drawing.Point(399, 167);
            this.listUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listUsuario.Name = "listUsuario";
            this.listUsuario.Size = new System.Drawing.Size(620, 258);
            this.listUsuario.TabIndex = 3;
            this.listUsuario.UseCompatibleStateImageBehavior = false;
            this.listUsuario.View = System.Windows.Forms.View.Details;
            this.listUsuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listUsuario_MouseClick);
            // 
            // clmNome
            // 
            this.clmNome.DisplayIndex = 0;
            this.clmNome.Text = "Nome";
            // 
            // clmTelefone
            // 
            this.clmTelefone.DisplayIndex = 1;
            this.clmTelefone.Text = "Tel";
            // 
            // clmCPF
            // 
            this.clmCPF.DisplayIndex = 2;
            this.clmCPF.Text = "CPF";
            // 
            // clmLogin
            // 
            this.clmLogin.DisplayIndex = 3;
            this.clmLogin.Text = "Login";
            // 
            // clmSenha
            // 
            this.clmSenha.DisplayIndex = 4;
            this.clmSenha.Text = "Senha";
            this.clmSenha.Width = 61;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(491, 464);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(151, 52);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Apagar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(765, 465);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(151, 50);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // clmid
            // 
            this.clmid.DisplayIndex = 5;
            this.clmid.Text = "ID";
            // 
            // Tela_Usuário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listUsuario);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tela_Usuário";
            this.Text = "Tela_Usuário";
            this.Load += new System.EventHandler(this.Tela_Usuário_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txb_senha;
        private System.Windows.Forms.TextBox txb_Login;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txb_tel;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listUsuario;
        private System.Windows.Forms.ColumnHeader clmNome;
        private System.Windows.Forms.ColumnHeader clmTelefone;
        private System.Windows.Forms.ColumnHeader clmCPF;
        private System.Windows.Forms.ColumnHeader clmLogin;
        private System.Windows.Forms.ColumnHeader clmSenha;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ColumnHeader clmid;
    }
}
