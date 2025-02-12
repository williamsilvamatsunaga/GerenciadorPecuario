using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                    Animal a = new Animal();
                    string nomeNumeracao = txtNomeNumeracaoAnimal.Text;
                    a.SetNomeNumeracao(nomeNumeracao);
                    string raca = txtRacaAnimal.Text;
                    a.SetRaca(raca);
                    string sexo = cbSexoAnimal.Text;
                    a.SetSexo(sexo);
                    string dataNascimento = txtDataNascAnimal.Text;
                    a.SetDataNascimento(dataNascimento);
                    string peso = txtPesoAnimal.Text;
                    a.SetPeso(peso);
                    string UltimaVascinacao = txtDataUltimaVascAnimal.Text;
                    a.SetUltimaVacinacao(UltimaVascinacao);
                    string observacao = txtObservacaoAnimal.Text;
                    a.SetObservacao(observacao);

                    a.GetReturn();

                    MessageBox.Show("Animal cadastrado com sucesso!", "Cadastrar Animal", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNomeNumeracaoAnimal.Clear();
                    txtRacaAnimal.Clear();
                    cbSexoAnimal.SelectedIndex = -1;
                    txtDataNascAnimal.Clear();
                    txtPesoAnimal.Clear();
                    txtDataUltimaVascAnimal.Clear();
                    txtObservacaoAnimal.Clear();
                    txtNomeNumeracaoAnimal.Focus();
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
