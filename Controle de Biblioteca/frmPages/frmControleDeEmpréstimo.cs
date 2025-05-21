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
            inputUsuarios.DataSource = mainForm.usuarios;
            inputUsuarios.DisplayMember = "nome";
            inputUsuarios.ValueMember = "_id";

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
            string idUsuarioSelecionado = inputUsuarios.SelectedValue.ToString();
            string idLivroSelecionado = inputLivro.SelectedValue.ToString();
            string status = inputStatus.Text;

            Usuario usuarioSelecionado = mainForm.usuarios.FirstOrDefault(u => u._id.ToString() == idUsuarioSelecionado);
            Livro livroSelecionado = mainForm.livros.FirstOrDefault(l => l._id.ToString() == idLivroSelecionado);

            if (status == "Emprestado")
            {
                Emprestimo emprestimo = new Emprestimo
                {
                    usuario = usuarioSelecionado,
                    livro = livroSelecionado,
                };
                emprestimo.RegistrarEmprestimo();
                mainForm.emprestimos.Add(emprestimo);
                MessageBox.Show("Livro emprestado com sucesso!\n" + emprestimo.ExibirInformacoes());
            }
            else
            {
                Emprestimo emprestimo = new Emprestimo
                {
                    usuario = usuarioSelecionado,
                    livro = livroSelecionado,
                };
                emprestimo.RegistrarDevolucao();
                mainForm.emprestimos.Add(emprestimo);
                MessageBox.Show("Livro devolvido com sucesso!\n" + emprestimo.ExibirInformacoes());
            }
        }
    }
}
