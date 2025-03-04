using GestaoPecuaria.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoPecuaria
{
    public partial class FormCadastrarAnimal : Form
    {
        public FormCadastrarAnimal()
        {
            InitializeComponent();
        }

        private void btCadastrarAnimal2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNomeNumeracaoAnimal.Text.Equals("") && !txtRacaAnimal.Text.Equals("") && !cbSexoAnimal.Text.Equals(""))
                {
                    Animais a = new Animais();
                    string nomeNumeracao = txtNomeNumeracaoAnimal.Text;
                    a.NomeNumeracao(nomeNumeracao);
                    string raca = txtRacaAnimal.Text;
                    a.Raca(raca);
                    string sexo = cbSexoAnimal.Text;
                    a.Sexo(sexo);
                    DateTime dataNascimento;
                    if (!DateTime.TryParseExact(txtDataNascAnimal.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascimento))
                    {
                        MessageBox.Show("Data de nascimento inválida! Use o formato dd/MM/yyyy.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDataNascAnimal.Clear();
                        txtDataNascAnimal.Focus();
                        return;
                    }
                    a.DataNascimento(dataNascimento);
                    a.DataNascimento(dataNascimento);
                    decimal peso = Convert.ToDecimal(txtPesoAnimal.Text);
                    a.Peso(peso);
                    DateTime ultimaVacinacao;
                    if (!DateTime.TryParseExact(txtDataUltimaVascAnimal.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ultimaVacinacao))
                    {
                        MessageBox.Show("Data da última vacinação inválida! Use o formato dd/MM/yyyy.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDataUltimaVascAnimal.Clear();
                        txtDataUltimaVascAnimal.Focus();
                        return;
                    }
                    a.UltimaVacinacao(ultimaVacinacao);
                    string observacao = txtObservacaoAnimal.Text;
                    a.Observacao(observacao);

                    bool nao = a.ConfirmarDados();

                    if (!nao)
                    {
                        MessageBox.Show("Edite os dados conforme necessário.", "Editar Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    MessageBox.Show("Animal cadastrado com sucesso!", "Cadastrar Animal", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNomeNumeracaoAnimal.Clear();
                    txtRacaAnimal.Clear();
                    cbSexoAnimal.SelectedIndex = -1;
                    txtDataNascAnimal.Clear();
                    txtPesoAnimal.Clear();
                    txtDataUltimaVascAnimal.Clear();
                    txtObservacaoAnimal.Clear();
                    txtNomeNumeracaoAnimal.Focus();

                    AnimalDAO DAO = new AnimalDAO();
                    DAO.Cadastrar(a);
                }
                else
                {
                    MessageBox.Show("Preencha os campos obrigatórios!", "Cadastrar Animal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNomeNumeracaoAnimal.Clear();
                    txtRacaAnimal.Clear();
                    cbSexoAnimal.SelectedIndex = -1;
                    txtDataNascAnimal.Clear();
                    txtPesoAnimal.Clear();
                    txtDataUltimaVascAnimal.Clear();
                    txtObservacaoAnimal.Clear();
                    txtNomeNumeracaoAnimal.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar animal: " + ex.Message, "Castrar Animal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
