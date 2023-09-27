using Sucos_Vendas.Controller.Metodos_Cadastro_Cliente;
using Sucos_Vendas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sucos_Vendas.View
{
    public partial class Frm_AlteraCadastroCliente_UC : UserControl
    {

        Frm_Principal principal;
        public Frm_AlteraCadastroCliente_UC(Frm_Principal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string nome = txt_Nome.Text;
            ConsultaCliente cliente = new ConsultaCliente();
            cliente.CarregarDados(nome, dt_Consulta);
        }

        private void dt_Consulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dt_Consulta.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}