﻿using System;
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

            List<Livro> mockedLivros = Constantes.ObterLivros();
            livros.AddRange(Constantes.ObterLivros());

            List<Usuario> mockedUsuarios = Constantes.ObterUsuarios();
            usuarios.AddRange(Constantes.ObterUsuarios());
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
            frmPages.Relatórios frmRelatorios = new frmPages.Relatórios(this);
            frmRelatorios.MdiParent = this;
            frmRelatorios.Show();
        }
    }
}
