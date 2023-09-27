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
    {   
        Frm_Principal principal;
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