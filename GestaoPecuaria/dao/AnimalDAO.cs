﻿using GestaoPecuaria.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                throw new Exception("Erro ao cadastrar animal " + ex.Message);
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
                throw new Exception("Erro ao atualizar animal" + ex.Message);
            }
        }
    }
}
