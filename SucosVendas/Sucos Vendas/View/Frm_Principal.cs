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

        public int ControleCadastoCliente = 0;
        public void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ControleCadastoCliente == 0)
            {
                ControleCadastoCliente++;
                Frm_Teste teste = new Frm_Teste(this);
                teste.MdiParent = this; 
                teste.Show();
                Frm_CadastroCliente_UC U = new Frm_CadastroCliente_UC();
                U.Dock = DockStyle.Fill;
                TabPage TB = new TabPage();
                TB.Name = "Cadastro de Clientes";
                TB.Text = "Cadastro de Clientes";
                TB.ImageIndex = 0;
                TB.Controls.Add(U);
                teste.tbc_Aplicacoes.TabPages.Add(TB);
            }
            else
            {
                MessageBox.Show("Cadastro de clientes já está em aberto", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}