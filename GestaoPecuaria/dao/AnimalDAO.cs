using GestaoPecuaria.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoPecuaria.dao
{
    internal class AnimalDAO
    {
        public void Cadastrar(Animais animais)
        {
            try
            {
                string sql = "INSERT INTO Animais (nomeNumeracao, raca, sexo, dataNascimento," +
                    "peso, ultimaVacinacao, observacao) VALUES" +
                "(@nomeNumeracao, @raca, @sexo, @dataNascimento, @peso," +
                "@ultimaVacinacao, @observacao)";


                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());

                

                comando.Parameters.AddWithValue("nomeNumeracao", animais.nomeNumeracao);
                comando.Parameters.AddWithValue("raca", animais.raca);
                comando.Parameters.AddWithValue("sexo", animais.sexo);
                comando.Parameters.AddWithValue("dataNascimento", animais.dataNascimento);
                comando.Parameters.AddWithValue("peso", animais.peso);
                comando.Parameters.AddWithValue("ultimaVacinacao", animais.ultimaVacinacao);
                comando.Parameters.AddWithValue("observacao", animais.observacao);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar com o banco de dados: " + ex.Message);
            }
        }
        public void Atualizar(Animais animais)
        {
            try
            {
                string sql = "UPDATE Animais SET nomeNumeracao = @nomeNumeracao, raca = @raca, sexo = @sexo, dataNascimento = @dataNascimento," +
                    "peso = @peso, ultimaVacinacao = @ultimaVacinacao, observacao = @observacao " +
                    "WHERE nomeNumeracao = @nomeNumeracao";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());

                comando.Parameters.AddWithValue("nomeNumeracao", animais.nomeNumeracao);
                comando.Parameters.AddWithValue("raca", animais.raca);
                comando.Parameters.AddWithValue("sexo", animais.sexo);
                comando.Parameters.AddWithValue("dataNascimento", animais.dataNascimento);
                comando.Parameters.AddWithValue("peso", animais.peso);
                comando.Parameters.AddWithValue("ultimaVacinacao", animais.ultimaVacinacao);
                comando.Parameters.AddWithValue("observacao", animais.observacao);

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar com o banco de dados: " + ex.Message);
            }
        }
        public DataTable ListarAnimais()
        {
            DataTable dt = new DataTable();

            try
            {
                string select = "SELECT * FROM Animais ORDER BY nomeNumeracao";

                MySqlCommand comando = new MySqlCommand(select, Conexao.Conectar());
                MySqlDataAdapter da = new MySqlDataAdapter(comando);

                da.Fill(dt);



            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar com o banco de dados: " + ex.Message);

            }

            return dt;
        }
        public void ExcluirAnimal(string nomeNomeracao)
        {
            try
            {
                string sql = "DELETE FROM Animais WHERE nomeNumeracao = @nomeNumeracao";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@nomeNumeracao", nomeNomeracao);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar ao banco de dados " + ex.Message);
            }
        }
    }
}
