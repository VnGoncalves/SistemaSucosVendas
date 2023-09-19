using Sucos_Vendas.Controller.Metodos_Tela_Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sucos_Vendas.View
{
    public partial class Frm_CadastroLogin : Form
    {
        public Frm_CadastroLogin()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            TelaLoginCadastro cadastro = new TelaLoginCadastro();

            if (txt_Nome.Text.Equals(string.Empty) || txt_Login.Text.Equals(string.Empty)
            || txt_Senha.Text.Equals(string.Empty) || txt_ConfirmaSenha.Text.Equals(string.Empty))
            {
                MessageBox.Show("Preencha todos os campos.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cadastro.verificaLogin(txt_Login.Text))
                {
                    MessageBox.Show("Usuário já existe", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cadastro.Cadastrar(txt_Nome.Text, txt_Login.Text, txt_Senha.Text, txt_ConfirmaSenha.Text);
                    txt_Nome.Text = string.Empty;
                    txt_Login.Text = string.Empty;
                    txt_Senha.Text = string.Empty;
                    txt_ConfirmaSenha.Text = string.Empty;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_Senha.PasswordChar == '*')
            {
                txt_Senha.PasswordChar = '\0';
                button1.ImageIndex = 8;
            }
            else
            {
                txt_Senha.PasswordChar = '*';
                button1.ImageIndex = 7;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_ConfirmaSenha.PasswordChar == '*')
            {
                txt_ConfirmaSenha.PasswordChar = '\0';
                button2.ImageIndex = 8;
            }
            else
            {
                txt_ConfirmaSenha.PasswordChar = '*';
                button2.ImageIndex = 7;
            }
        }
    }
}