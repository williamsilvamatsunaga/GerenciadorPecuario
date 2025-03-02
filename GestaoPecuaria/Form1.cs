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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrarAnimal_Click(object sender, EventArgs e)
        {
            FormCadastrarAnimal form = new FormCadastrarAnimal();
            form.ShowDialog();
        }

        private void btAtualizarAnimal_Click(object sender, EventArgs e)
        {
            FormAtualizarFuncionario form = new FormAtualizarFuncionario();
            form.ShowDialog();
        }

        private void btListarAnimal_Click(object sender, EventArgs e)
        {
            FormListarAnimal form = new FormListarAnimal();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormExcluirAnimal form = new FormExcluirAnimal();
            form.ShowDialog();
        }

        private void btExcluirAnimal_Click(object sender, EventArgs e)
        {
            FormExcluirAnimal form = new FormExcluirAnimal();
            form.ShowDialog();
        }
    }
}
