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
        public Frm_TelaLogin()
        {
            InitializeComponent();
        }

        private void btn_Cadastro_Click(object sender, EventArgs e)
        {
            Frm_CadastroLogin cadastro = new Frm_CadastroLogin();
            cadastro.ShowDialog();
        }
    }
}
