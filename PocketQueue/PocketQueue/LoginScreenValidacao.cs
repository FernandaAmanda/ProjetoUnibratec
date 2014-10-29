using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocketQueue
{
    public class LoginScreenValidacao
    {
        protected SqlConnection conexao = new SqlConnection("Server=JEDILSON-PC;Database=PocketQueue;User Id=sa;Password=sa;");
        public string Login(string login, string password)
        {
            string ID = null;
            SqlCommand cmd = new SqlCommand("SELECT IDTipoUsuario FROM Usuarios WHERE Login='" + login + "' and Senha='" + password + "';", conexao);
            try
            {
                conexao.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                ID = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                //MessageBox.Show("ID:" + ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um Erro: " + ex.Message);
                throw;
            }
            finally
            {
                conexao.Close();
            }

            return ID;
        }

        public string TipoUsuario(string IDTipo)
        {
            string Descricao = null;

            SqlCommand cmd = new SqlCommand("SELECT DescricaoUsuario FROM TipoUsuarios WHERE IDTipoUsuario='" + IDTipo + "';", conexao);
            try
            {
                conexao.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                Descricao = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                //MessageBox.Show("Descrição:" + Descricao);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um Erro: " + ex.Message);
                throw;
            }
            finally
            {
                conexao.Close();
            }

            return Descricao;
        }
    }

}
