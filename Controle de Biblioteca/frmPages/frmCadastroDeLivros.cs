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
    public partial class frmCadastroDeLivros: Form
    {
        private MainForm mainForm;
        public frmCadastroDeLivros(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }

        private void frmCadastroDeLivros_Load(object sender, EventArgs e)
        {
            inputStatus.SelectedIndex = 0;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string titulo  = inputTitulo.Text;
            string autor = inputAutor.Text;
            string ano = inputAno.Text;
            string isbn = inputISBN.Text;
            string status = inputStatus.Text;

            bool hasAllFields = !string.IsNullOrEmpty(titulo) || !string.IsNullOrEmpty(autor) || !string.IsNullOrEmpty(ano) || !string.IsNullOrEmpty(isbn) || !string.IsNullOrEmpty(status);

            if (!hasAllFields)
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            Livro livro = new Livro
            {
                _id = Guid.NewGuid().ToString(),
                titulo = titulo,
                autor = autor,
                ano = int.Parse(ano),
                isbn = isbn,
                status = (StatusLivro)Enum.Parse(typeof(StatusLivro), status)
            };
            mainForm.livros.Add(livro);
            MessageBox.Show("Parabéns! Você cadastrou um livro: \n" + livro.ExibirInformacoes());
        }
    }
}
