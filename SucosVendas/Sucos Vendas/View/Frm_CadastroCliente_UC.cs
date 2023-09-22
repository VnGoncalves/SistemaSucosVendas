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
    public partial class Frm_CadastroCliente_UC : UserControl
    {
        public Frm_CadastroCliente_UC()
        {
            InitializeComponent();

            cmb_Estado.Items.Clear();
            cmb_Estado.Items.Add("Acre (AC)");
            cmb_Estado.Items.Add("Alagoas(AL)");
            cmb_Estado.Items.Add("Amapá(AP)");
            cmb_Estado.Items.Add("Amazonas(AM)");
            cmb_Estado.Items.Add("Bahia(BA)");
            cmb_Estado.Items.Add("Ceará(CE)");
            cmb_Estado.Items.Add("Distrito Federal(DF)");
            cmb_Estado.Items.Add("Espírito Santo(ES)");
            cmb_Estado.Items.Add("Goiás(GO)");
            cmb_Estado.Items.Add("Maranhão(MA)");
            cmb_Estado.Items.Add("Mato Grosso(MT)");
            cmb_Estado.Items.Add("Mato Grosso do Sul(MS)");
            cmb_Estado.Items.Add("Minas Gerais(MG)");
            cmb_Estado.Items.Add("Pará(PA)");
            cmb_Estado.Items.Add("Paraíba(PB)");
            cmb_Estado.Items.Add("Paraná(PR)");
            cmb_Estado.Items.Add("Pernambuco(PE)");
            cmb_Estado.Items.Add("Piauí(PI)");
            cmb_Estado.Items.Add("Rio de Janeiro(RJ)");
            cmb_Estado.Items.Add("Rio Grande do Norte(RN)");
            cmb_Estado.Items.Add("Rio Grande do Sul(RS)");
            cmb_Estado.Items.Add("Rondônia(RO)");
            cmb_Estado.Items.Add("Roraima(RR)");
            cmb_Estado.Items.Add("Santa Catarina(SC)");
            cmb_Estado.Items.Add("São Paulo(SP)");
            cmb_Estado.Items.Add("Sergipe(SE)");
            cmb_Estado.Items.Add("Tocantins(TO)");

            cmb_PrimeiraCompra.Items.Add("Sim");
            cmb_PrimeiraCompra.Items.Add("Não");
        }
    }
}
