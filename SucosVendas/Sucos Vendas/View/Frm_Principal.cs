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
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        int ControleCadastoCliente = 0;

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ControleCadastoCliente == 0)
            {
                ControleCadastoCliente += 1;
                Frm_CadastroCliente_UC U = new Frm_CadastroCliente_UC();
                TabPage TB = new TabPage();
                U.Dock = DockStyle.Fill;
                TB.Name = "Cadatro Cliente ";
                TB.Text = "Cadastro Cliente ";
                TB.ImageIndex = 5;
                TB.Controls.Add(U);
                tbc_Aplicacoes.TabPages.Add(TB);
            } else
            {
                MessageBox.Show("Cadastro de clientes já está em aberto","ATENÇÃO",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}