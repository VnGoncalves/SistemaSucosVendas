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
    public partial class Frm_Teste : Form
    {
        public Frm_Teste()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        public string tbc_Aplicicacoes
        {
            get { return tbc_Aplicacoes.ToString(); ; }
        }
    }
}