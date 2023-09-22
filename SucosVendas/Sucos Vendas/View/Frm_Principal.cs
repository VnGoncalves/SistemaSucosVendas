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

        int ControleCadastoCliente = 0;
        public void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Teste teste = new Frm_Teste();
            teste.MdiParent = this;
            teste.ControlBox = false;
            teste.Show();


            if (ControleCadastoCliente == 0)
            {
                ControleCadastoCliente += 1;
                Frm_CadastroCliente_UC U = new Frm_CadastroCliente_UC();
                TabPage TB = new TabPage();
                U.Dock = DockStyle.Fill;
                TB.Name = "Cadastro de Clientes ";
                TB.Text = "Cadastro de Clientes ";
                TB.ImageIndex = 0;
                TB.Controls.Add(U);
                teste.tbc_Aplicacoes.TabPages.Add(TB);
            }
            else
            {
                MessageBox.Show("Cadastro de clientes já está em aberto", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}