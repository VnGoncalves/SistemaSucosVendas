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
            this.BackgroundImage = Properties.Resources._3409297;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadastroCliente cliente = new Frm_CadastroCliente(this);
            cliente.MdiParent = this;
            cliente.Show();
            Frm_CadastroCliente_UC U = new Frm_CadastroCliente_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Cadastro de Clientes";
            TB.Text = "Cadastro de Clientes";
            TB.ImageIndex = 0;
            TB.Controls.Add(U);
            cliente.tbc_Aplicacoes.TabPages.Add(TB);


            Frm_AlteraCadastroCliente altera = new Frm_AlteraCadastroCliente(this);
            altera.Dock = DockStyle.Fill;
            TabPage TB2 = new TabPage();
            TB2.Name = "Alterar cadastro de Clientes";
            TB2.Text = "Alterar cadastro de Clientes";
            TB2.ImageIndex = 1;
            TB2.Controls.Add(altera);
            cliente.tbc_Aplicacoes.TabPages.Add(TB2);
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema ?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}