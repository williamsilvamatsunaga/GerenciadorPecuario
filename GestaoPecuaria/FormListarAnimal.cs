﻿using GestaoPecuaria.dao;
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
    public partial class FormListarAnimal: Form
    {
        public FormListarAnimal()
        {
            InitializeComponent();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            try
            {
                AnimalDAO dao = new AnimalDAO();

              
                dgvListarAnimais.DataSource = dao.ListarAnimais();
                dgvListarAnimais.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar animais: " + ex.Message);
            }
        }
    }
}
