using EscolaBruxos.visão;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaBruxos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarAluno frmcadaluno = new frmCadastrarAluno();
            frmcadaluno.Show();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfessor frmprofessor = new frmProfessor();
            frmprofessor.Show();

        }

        private void reitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReitor frmreitor = new frmReitor();
            frmreitor.Show();
        }
    }
 }
