﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador_BuscaForn
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
             Close();
        }
        private void mudarLabelLogin(object sender, EventArgs e)
        {
            if (comboBoxLogin.SelectedItem == "- Comprador")
            {
                labLogin.Text = "CPF:";
            }
            if (comboBoxLogin.SelectedItem == "- Fornecedor" )
            {
                labLogin.Text = "CNPJ:";
            }
        }
    }
}
