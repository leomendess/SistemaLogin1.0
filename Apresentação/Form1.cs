using ProjetoTelaDeLogin.Apresentação;
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

namespace ProjetoTelaDeLogin
{
    public partial class Form1 : Form
    {
        private object f;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click_1(object sender, EventArgs e)

        {
            Controle controle = new Controle();
            controle.acessar(txbLogin.Text, txbSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)

                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                    Bem_Vindo bv = new Bem_Vindo();
                    bv.Show();
                   
                                    }
                else
                {
                    MessageBox.Show("Login não encontrado", "ERRO!", MessageBoxButtons.OK);

                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
                }
            
        
                
          
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.Show();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
       { 
            Application.Exit();
        }

        private void txbLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
