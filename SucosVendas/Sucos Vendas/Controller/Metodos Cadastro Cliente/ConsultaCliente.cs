using Sucos_Vendas.Model;
using Sucos_Vendas.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sucos_Vendas.Controller.Metodos_Cadastro_Cliente
{
    public class ConsultaCliente
    {
        public void CarregarDados(string nome, DataGridView dtGrid)
        {
            string sql = "select * from [TABELA DE CLIENTES] where nome like '" + "%" + @nome + "%" + "'";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString: "Data Source=VINICIUS;Initial Catalog=SUCOS_VENDAS;Integrated Security=True"))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dtGrid.DataSource = dt;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao carregar os dados: " + e.Message);
            }
        }
    }
}