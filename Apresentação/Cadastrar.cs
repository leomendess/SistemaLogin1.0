using ProjetoTelaDeLogin.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTelaDeLogin.Apresentação
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(txbLoginCadastro.Text, txbSenhaCadastro.Text, txbConfirmar.Text);
            if(controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
            {
                Close();
                Form1 cad = new Form1();
                
            }
        }

        private void txbConfirmar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbSenhaCadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbLoginCadastro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
