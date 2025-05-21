using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Biblioteca.frmPages
{
    public partial class Relatórios: Form
    {
        private MainForm mainForm;
        public Relatórios(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }

        private void dtGridAlunos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var grid = (DataGridView)sender;
            grid.Columns["_id"].DisplayIndex = 0;
            grid.Columns["nome"].DisplayIndex = 1;
            grid.Columns["tipo"].DisplayIndex = 2;
            grid.Columns["ra"].DisplayIndex = 3;
            grid.Columns["curso"].DisplayIndex = 4;
        }

        private void dtGridProfessores_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var grid = (DataGridView)sender;
            grid.Columns["_id"].DisplayIndex = 0;
            grid.Columns["nome"].DisplayIndex = 1;
            grid.Columns["tipo"].DisplayIndex = 2;
            grid.Columns["numeroRegistro"].DisplayIndex = 3;
            grid.Columns["departamento"].DisplayIndex = 4;
        }

        void CarregarDados()
        {
            //Alunos
            dtGridAlunos.DataSource = null;
            dtGridAlunos.DataSource = mainForm.usuarios
                .Where(u => u.tipo == TipoUsuario.Aluno)
                .Cast<Aluno>()
                .ToList();
            dtGridAlunos.Columns["nome"].HeaderText = "Nome do Aluno";
            dtGridAlunos.Columns["tipo"].HeaderText = "Tipo";
            dtGridAlunos.Columns["ra"].HeaderText = "RA do Aluno";
            dtGridAlunos.Columns["curso"].HeaderText = "Curso do Aluno";

            //Professores
            dtGridProfessores.DataSource = null;
            dtGridProfessores.DataSource = mainForm.usuarios
                .Where(u => u.tipo == TipoUsuario.Professor)
                .Cast<Professor>()
                .ToList();
            dtGridProfessores.Columns["nome"].HeaderText = "Nome do Professor";
            dtGridProfessores.Columns["tipo"].HeaderText = "Tipo";
            dtGridProfessores.Columns["numeroRegistro"].HeaderText = "Número de Registro";
            dtGridProfessores.Columns["departamento"].HeaderText = "Departamento";

            //Livros
            dtGridLivros.DataSource = null;
            dtGridLivros.DataSource = mainForm.livros.ToList();
            dtGridLivros.Columns["titulo"].HeaderText = "Título do Livro";
            dtGridLivros.Columns["autor"].HeaderText = "Autor do Livro";
            dtGridLivros.Columns["ano"].HeaderText = "Ano de Publicação";
            dtGridLivros.Columns["isbn"].HeaderText = "ISBN do Livro";
            dtGridLivros.Columns["status"].HeaderText = "Situação do Livro";

            //Livros Disponíveis
            dtGridLivrosDisponiveis.DataSource = null;
            dtGridLivrosDisponiveis.DataSource = mainForm.livros
                .Where(l => l.status == StatusLivro.Disponivel)
                .ToList();
            dtGridLivrosDisponiveis.Columns["titulo"].HeaderText = "Título do Livro";
            dtGridLivrosDisponiveis.Columns["autor"].HeaderText = "Autor do Livro";
            dtGridLivrosDisponiveis.Columns["ano"].HeaderText = "Ano de Publicação";
            dtGridLivrosDisponiveis.Columns["isbn"].HeaderText = "ISBN do Livro";
            dtGridLivrosDisponiveis.Columns["status"].HeaderText = "Situação do Livro";

            //Emprestimos
            dtGridEmprestimos.DataSource = null;
            dtGridEmprestimos.DataSource = mainForm.emprestimos.Select(e => new
            {
                ID = e._id,
                usuario = e.usuario.nome,
                livro = e.livro.titulo,
                data = e.data.ToString("d"),
                dataDevolucao = e.dataDevolucao.ToString("d"),
                status = e.status.ToString()
            }).ToList();
            dtGridEmprestimos.Columns["usuario"].HeaderText = "Nome do Usuário";
            dtGridEmprestimos.Columns["livro"].HeaderText = "Título do Livro";
            dtGridEmprestimos.Columns["data"].HeaderText = "Data de Empréstimo";
            dtGridEmprestimos.Columns["dataDevolucao"].HeaderText = "Data de Devolução";
            dtGridEmprestimos.Columns["status"].HeaderText = "Situação";
        }

        private void frmRelatorios_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
    }
}
