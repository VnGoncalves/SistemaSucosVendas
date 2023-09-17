using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucos_Vendas.Model
{
    public class Conexao
    {
        public string stringconn;
        public SqlConnection connDB;

        public Conexao()
        {
            try
            {
                stringconn = "Data Source=VINICIUS;Initial Catalog=SUCOS_VENDAS;Integrated Security=True";
                connDB = new SqlConnection(stringconn);
                connDB.Open();
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
