using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sucos_Vendas.View;

namespace Sucos_Vendas.View
{
    public partial class Frm_CadastroCliente : Form
    {   Frm_Principal principal;
        public Frm_CadastroCliente(Frm_Principal principal)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.principal = principal;
        }
        public string tbc_Aplicicacoes
        {
            get { return tbc_Aplicacoes.ToString(); }
        }
        public void tbc_Aplicacoes_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var ContextMenu = new ContextMenuStrip();
                var vToolTip001 = DesenhaMenu("Apagar Aba", "_58483");
                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Show(this, new Point(e.X, e.Y));
                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
            }
        }
        public void vToolTip001_Click(Object sender1, EventArgs e1)
        {
            if (!(tbc_Aplicacoes.SelectedTab == null))
            {
                ApagarAba(tbc_Aplicacoes.SelectedTab);
            }
        }
        public void ApagarAba(TabPage TB)
        {
            if (TB.Name == "Cadastro de Clientes")
            {
                tbc_Aplicacoes.TabPages.Remove(TB);
            }
            this.principal.ControleCadastoCliente = 0;
        }
        ToolStripMenuItem DesenhaMenu(string text, string imagem)
        {
            var vToolStrip = new ToolStripMenuItem();
            Image MyImage = (Image)global::Sucos_Vendas.Properties.Resources.ResourceManager.GetObject(imagem);
            vToolStrip.Image = MyImage;
            vToolStrip.Text = text;
            return vToolStrip;
        }
    }
}