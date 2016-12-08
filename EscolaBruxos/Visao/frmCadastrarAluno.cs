using EscolaBruxos.Controle;
using EscolaBruxos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EscolaBruxos.Modelo;

namespace EscolaBruxos.visão
{
    public partial class frmCadastrarAluno : Form
    {
        public frmCadastrarAluno()
        {
            InitializeComponent();
            txtIDAluno.Enabled = false;
            btnPesquisar.Enabled = false;
        }

        private void frmCadastrarAluno_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPaisOrigemAluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPaisOrigem_Click(object sender, EventArgs e)
        {

        }

        private void lblNomeAluno_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblNserie_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btmCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("porra louca");

            /*
            Aluno al = new Entidades.Aluno();
            //CreateAlunos
            al.Nome = txtNomedoAluno.Text;
            al.Idade = Convert.ToInt32(txtIdadeAluno.Text);
            AlunoModel alModel = new AlunoModel();
            */ 


            /*
            //DAdos da Entidade BRUXOS
            string nome = txtNomedoAluno.Text;
            string pais = txtPaisOrigemAluno.Text;
            string dataNasc = txtDataNascimentoAluno.Text;
            int idade = Convert.ToInt32(txtIdadeAluno.Text);
            string email = txtEmailAluno.Text;

            //Dados da Entidade ALUNO
            int anoIngresso = Convert.ToInt32(txtAnoIngressoAluno.Text);
            int registroAcad = Convert.ToInt32(txtRegistroAcademicoAluno.Text);
            string casa = txtCasaAluno.Text;
            string magia = txtMagiaAluno.Text;

            // Dados da Entidade VASSOURA VOADORA
            int nroserie = Convert.ToInt32(txtNSerieAluno.Text);
            string nomeVass = txtNomeVsAluno.Text;
            double potencia = Convert.ToDouble(txtPotenciaAluno.Text);

            // Encapsulando os dados em um objeto aluno para enviar à camada de controle
            Aluno aluno = new Aluno();
            aluno.Nome = nome;
            aluno.PaisOrigem = pais;
            aluno.DataNasc = dataNasc;
            aluno.Idade = idade;
            aluno.Email = email;
            aluno.AnoIngresso = anoIngresso;
            aluno.Ra = registroAcad;
            aluno.Casa = casa;
            aluno.Magia = magia;
            aluno.VassouraVoadora.Numero = nroserie;
            aluno.VassouraVoadora.Nome = nomeVass;
            aluno.VassouraVoadora.Potencia = potencia;

            // Criando um objeto de controle para chamar a execução dos métodos de inserção de dados no banco de dados escolaBruxosDB
            AlunoControle alunocontrole = new AlunoControle();
            alunocontrole.inserirAluno(aluno);
            */
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIDAluno.Text = null;
            txtNomedoAluno.Text = null;
            txtPaisOrigemAluno.Text = null;
            txtDataNascimentoAluno.Text = null;
            txtIdadeAluno.Text = null;
            txtEmailAluno.Text = null;
            txtAnoIngressoAluno.Text = null;
            txtRegistroAcademicoAluno.Text = null;
            txtCasaAluno.Text = null;
            txtMagiaAluno.Text = null;
            txtNomeVsAluno.Text = null;
            txtNSerieAluno.Text = null;
            txtPotenciaAluno.Text = null;
            txtNomedoAluno.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            txtIDAluno.Enabled = true;
            btnPesquisar.Enabled = true;

            txtNomedoAluno.Enabled = false;
            txtPaisOrigemAluno.Enabled = false;
            txtDataNascimentoAluno.Enabled = false;
            txtIdadeAluno.Enabled = false;
            txtEmailAluno.Enabled = false;
            txtAnoIngressoAluno.Enabled = false;
            txtRegistroAcademicoAluno.Enabled = false;
            txtCasaAluno.Enabled = false;
            txtMagiaAluno.Enabled = false;
            txtNomeVsAluno.Enabled = false;
            txtNSerieAluno.Enabled = false;
            txtPotenciaAluno.Enabled = false;

            btnCadastrarAluno.Enabled = false;
            btnConsultarAluno.Enabled = false;
            btnLimparAluno.Enabled = false;

            txtIDAluno.Focus();
        }
        private void habilitaDesabilita()
        {
            txtIDAluno.Enabled = !txtIDAluno.Enabled;
            btnPesquisar.Enabled = !btnPesquisar.Enabled;
            txtNomedoAluno.Enabled = !txtNomedoAluno.Enabled;
            txtPaisOrigemAluno.Enabled = !txtPaisOrigemAluno.Enabled;
            txtAnoIngressoAluno.Enabled = !txtAnoIngressoAluno.Enabled;
            txtCasaAluno.Enabled = !txtCasaAluno.Enabled;
            txtDataNascimentoAluno.Enabled = !txtDataNascimentoAluno.Enabled;
            txtEmailAluno.Enabled = !txtEmailAluno.Enabled;
            txtIdadeAluno.Enabled = !txtIdadeAluno.Enabled;
            txtMagiaAluno.Enabled = !txtMagiaAluno.Enabled;
            txtNomeVsAluno.Enabled = !txtNomeVsAluno.Enabled;
            txtPotenciaAluno.Enable = !txtPotenciaAluno.Enabled;
            txtNSerieAluno.Enabled = !txtNSerieAluno.Enabled;
            txtRegistroAcademicoAluno.Enabled = !txtRegistroAcademicoAluno.Enabled;
            btnCadastrarAluno.Enabled = !btnCadastrarAluno.Enabled;
            btnConsultarAluno.Enabled = !btnConsultarAluno.Enabled;
            btnAtualizar.Enabled = !btnAtualizar.Enabled;
            btnExcluir.Enabled = !btnExcluir.Enabled;
            btnLimparAluno.Enabled = !btnLimparAluno.Enabled;
            
         }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDAluno.Text);

            Aluno aluno = new Aluno();
            aluno.Id = id;

            AlunoControle alunocontrole = new AlunoControle();

            if (alunocontrole.consultarAluno(aluno))
            {
                txtIDAluno.Text = aluno.Id.ToString();
                txtNomedoAluno.Text = aluno.Nome;
                txtPaisOrigemAluno.Text = aluno.PaisOrigem;
                txtDataNascimentoAluno.Text = aluno.DataNasc;
                txtIdadeAluno.Text = aluno.Idade.ToString();
                txtEmailAluno.Text = aluno.Email;
                txtAnoIngressoAluno.Text = aluno.AnoIngresso.ToString();
                txtRegistroAcademicoAluno.Text = aluno.Ra.ToString();
                txtCasaAluno.Text = aluno.Casa;
                txtMagiaAluno.Text = aluno.Magia;
                txtNomeVsAluno.Text = aluno.VassouraVoadora.Nome;
                txtNSerieAluno.Text = aluno.VassouraVoadora.Numero.ToString();
                txtPotenciaAluno.Text = aluno.VassouraVoadora.Potencia.ToString();
            }
            else
            {
                MessageBox.Show("Aluno não encontrado");
                habilitaDesabilita();
            }
            }
        private void txtIDAluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDAluno.Text);

            Aluno aluno = new Aluno();
            aluno.Id = id;

            AlunoControle alunocontrole = new AlunoControle();
            alunocontrole.excluirAluno(aluno);
        }
    }
}

