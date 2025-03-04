using GestaoPecuaria.dao;
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
    public partial class FormExcluirAnimal: Form
    {
        public FormExcluirAnimal()
        {
            InitializeComponent();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                AnimalDAO dao = new AnimalDAO();

                string nomeNumeracao = txtNomeNumeracaoAnimal2.Text;
                dao.ExcluirAnimal(nomeNumeracao);

                txtNomeNumeracaoAnimal2.Clear();

                MessageBox.Show("Animal excluído com sucesso!", "Excluir Animal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao excluir animal: " + ex.Message);
            }
        }
    }
}
