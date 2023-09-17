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
    }
}