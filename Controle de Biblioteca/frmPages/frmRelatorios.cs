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
    public partial class frmRelatorios: Form
    {
        private MainForm mainForm;
        public frmRelatorios(MainForm form)
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
            dtGridAlunos.DataSource = null;
            dtGridAlunos.DataSource = mainForm.usuarios
                .Where(u => u.tipo == TipoUsuario.Aluno)
                .Cast<Aluno>()
                .ToList();

            dtGridProfessores.DataSource = null;
            dtGridProfessores.DataSource = mainForm.usuarios
                .Where(u => u.tipo == TipoUsuario.Professor)
                .Cast<Professor>()
                .ToList();

            dtGridLivros.DataSource = null;
            dtGridLivros.DataSource = mainForm.livros.ToList();
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
