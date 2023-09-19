using Sucos_Vendas.Model;
using Sucos_Vendas.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sucos_Vendas.Controller.Metodos_Tela_Login
{
    public class TelaLoginCadastro
    {
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        bool tem = false;

        public bool verificaLogin(string login)
        {
            cmd.CommandText = "select login from usuarios where login = @lo";
            cmd.Parameters.AddWithValue("@lo", login);
            cmd.Connection = con.conectar();
            dr = cmd.ExecuteReader();
            try
            {
                if (dr.HasRows)
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
        public void Cadastrar(string nome, string login, string senha, string confSenha)
        {
            if (!senha.Equals(confSenha))
            {
                MessageBox.Show("Senhas não conferem.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    cmd.CommandText = "insert into usuarios values (@nome, @login, @senha)";
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    MessageBox.Show("Usuário cadastro com sucesso", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
    }
}