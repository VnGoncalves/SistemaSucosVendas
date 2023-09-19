using Sucos_Vendas.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sucos_Vendas.Controller
{
    public class Login
    {
        public bool tem;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool login(string usuario, string senha) 
        {
            cmd.CommandText = "select * from usuarios where login = @usuario and senha = @senha";
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return tem;
        }
    }
}