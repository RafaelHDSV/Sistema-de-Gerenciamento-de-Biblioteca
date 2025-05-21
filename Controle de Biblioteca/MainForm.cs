using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Biblioteca
{
    public partial class MainForm : Form
    {
        public List<Usuario> usuarios { get; set; } = new List<Usuario>();
        public List<Livro> livros { get; set; } = new List<Livro>();
        public List<Emprestimo> emprestimos { get; set; } = new List<Emprestimo>();

        public MainForm()
        {
            InitializeComponent();

            livros.Add(new Livro
            {
                titulo = "O Senhor dos Anéis",
                autor = "J.R.R. Tolkien",
                ano = 1954,
                isbn = "978-0007525546",
                status = StatusLivro.Disponivel
            });

            livros.Add(new Livro
            {
                titulo = "1984",
                autor = "George Orwell",
                ano = 1949,
                isbn = "978-0451524935",
                status = StatusLivro.Emprestado
            });

            usuarios.Add(new Aluno
            {
                _id = Guid.NewGuid().ToString(),
                nome = "João da Silva",
                tipo = TipoUsuario.Aluno,
                ra = 123456,
                curso = "Ciência da Computação"
            });

            usuarios.Add(new Professor
            {
                _id = Guid.NewGuid().ToString(),
                nome = "Dra. Maria Oliveira",
                tipo = TipoUsuario.Professor,
                numeroRegistro = 98765,
                departamento = "Matemática Aplicada"
            });
        }

        private void cadastroDeLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPages.frmCadastroDeLivros frmCadastroDeLivros = new frmPages.frmCadastroDeLivros(this);
            frmCadastroDeLivros.MdiParent = this;
            frmCadastroDeLivros.Show();
        }

        private void cadastroDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPages.frmCadastroDeUsuarios frmCadastroDeUsuarios = new frmPages.frmCadastroDeUsuarios(this);
            frmCadastroDeUsuarios.MdiParent = this;
            frmCadastroDeUsuarios.Show();
        }

        private void controleDeEmpréstimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (livros.Count == 0)
            {
                MessageBox.Show("Não há livros cadastrados.");
                return;
            } else
            {
                frmPages.frmControleDeEmpréstimo frmControleDeEmpréstimo = new frmPages.frmControleDeEmpréstimo(this);
                frmControleDeEmpréstimo.MdiParent = this;
                frmControleDeEmpréstimo.Show();
            }
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPages.frmRelatorios frmRelatorios = new frmPages.frmRelatorios(this);
            frmRelatorios.MdiParent = this;
            frmRelatorios.Show();
        }
    }
}
