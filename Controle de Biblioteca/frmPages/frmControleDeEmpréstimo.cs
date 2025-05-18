using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Controle_de_Biblioteca.frmPages
{
    public partial class frmControleDeEmpréstimo : Form
    {
        private MainForm mainForm;

        public frmControleDeEmpréstimo(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }

        private void frmControleDeEmpréstimo_Load(object sender, EventArgs e)
        {
            inputLivro.DataSource = mainForm.livros;
            inputLivro.DisplayMember = "titulo";
            inputLivro.ValueMember = "_id";
            AtualizarStatus();
        }

        private void inputLivro_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarStatus();
        }

        void AtualizarStatus()
        {
            var livroSelecionado = inputLivro.SelectedItem as Livro;

            if (livroSelecionado != null)
            {
                if (livroSelecionado.status == StatusLivro.Disponivel)
                {
                    inputStatus.Text = "Emprestado";
                }
                else
                {
                    inputStatus.Text = "Disponivel";
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var livroSelecionado = inputLivro.SelectedItem as Livro;
            string status = inputStatus.Text;

            if (status == "Emprestado")
            {
                livroSelecionado.MarcarComoEmprestado();
                MessageBox.Show("Livro emprestado com sucesso!");
            }
            else
            {
                livroSelecionado.MarcarComoDisponivel();
                MessageBox.Show("Livro devolvido com sucesso!");
            }
        }
    }
}
