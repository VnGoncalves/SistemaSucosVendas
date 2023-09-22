using Sucos_Vendas.Controller;
using Sucos_Vendas.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sucos_Vendas
{
    public partial class Frm_TelaLogin : Form
    {
        public string nome;
        public Frm_TelaLogin()
        {
            InitializeComponent();
            
        }

        private void btn_Cadastro_Click(object sender, EventArgs e)
        {
            Frm_CadastroLogin cadastro = new Frm_CadastroLogin();
            cadastro.ShowDialog();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            
            nome = txt_Usuario.Text;


            Login login = new Login();
            login.login(txt_Usuario.Text, txt_Senha.Text);

            if (txt_Usuario.Text == string.Empty || txt_Senha.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (login.tem)
                {
                    MessageBox.Show("Login efetuado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm_Principal principal = new Frm_Principal();
                    principal.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Login não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}