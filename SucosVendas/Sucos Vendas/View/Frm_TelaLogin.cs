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

        private void txt_Usuario_TextChanged(object sender, EventArgs e)
        {
            if(txt_Usuario.Text == string.Empty)
            {
                txt_Usuario.Text = "Usuario";
            }
        }
    }
}
