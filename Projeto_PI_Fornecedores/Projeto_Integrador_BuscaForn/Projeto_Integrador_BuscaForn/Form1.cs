using System;
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
    public partial class FormPagIni : Form
    {
        public FormPagIni()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DialogResult MsgBoxCad = MessageBox.Show("Iniciar novo cadastro?", "Novo cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MsgBoxCad == DialogResult.Yes)
            {
                MessageBox.Show("Começando novo cadastro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var Form2 = new FormCadastro();
                Form2.Show();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult MsgBoxSair = MessageBox.Show("Deseja realmente sair?","Sair",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MsgBoxSair == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
              var FormLogin = new FormLogin();
              FormLogin.Show();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            var FormBusca = new FormBusca();
            FormBusca.Show();
        }
      
     }
}
