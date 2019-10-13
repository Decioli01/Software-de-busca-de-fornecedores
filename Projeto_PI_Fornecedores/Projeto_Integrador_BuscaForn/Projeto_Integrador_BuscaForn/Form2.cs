using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios.Net;
namespace Projeto_Integrador_BuscaForn

{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnCancCad_Click(object sender, EventArgs e)
        {
            DialogResult MsgBoxCanc = MessageBox.Show("Deseja cancelar o cadastro?", "Cancelar cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MsgBoxCanc == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
