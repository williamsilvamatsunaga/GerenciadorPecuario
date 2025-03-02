using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestaoPecuaria.Data
{
    internal class Conexao
    {
        static MySqlConnection _conexao;
        static string strconexao = "server=localhost; uid=root; pwd=root; database=GestaoPecuaria";

        public static MySqlConnection Conectar()
        {
            try
            {
                _conexao = new MySqlConnection(strconexao);
                _conexao.Open();
                return _conexao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar. " + ex.Message);
            }
        }
        public static void FecharConexao()
        {
            _conexao.Close();
        }
    }
}
