using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Biblioteca.frmPages
{
    public partial class frmCadastroDeUsuarios: Form
    {
        private MainForm mainForm;

        public frmCadastroDeUsuarios(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }

        private void inputType_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarVisibilidadeCampos();
        }

        private void AtualizarVisibilidadeCampos()
        {
            string tipo = inputType.Text.Trim();

            bool isAluno = tipo == "Aluno";
            bool isProfessor = tipo == "Professor";

            labelNumeroMatricula.Visible = inputNumeroMatricula.Visible = labelCurso.Visible = inputCurso.Visible = isAluno;
            labelNumeroRegistro.Visible = inputNumeroRegistro.Visible = labelDepartamento.Visible = inputDepartamento.Visible = isProfessor;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string name = inputName.Text;
            string type = inputType.Text;
            string numeroMatricula = inputNumeroMatricula.Text;
            string curso = inputCurso.Text;
            string numeroRegistro = inputNumeroRegistro.Text;
            string departamento = inputDepartamento.Text;

            bool hasAllFields = !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(type) &&
                (type != "Aluno" || (!string.IsNullOrEmpty(numeroMatricula) && !string.IsNullOrEmpty(curso))) &&
                (type != "Professor" || (!string.IsNullOrEmpty(numeroRegistro) && !string.IsNullOrEmpty(departamento)));

            if (!hasAllFields)
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }

            switch (type)
            {
                case "Aluno":
                    Aluno aluno = new Aluno
                    {
                        nome = name,
                        tipo = TipoUsuario.Aluno,
                        ra = int.Parse(numeroMatricula),
                        curso = curso
                    };
                    mainForm.usuarios.Add(aluno);
                    MessageBox.Show("Parabéns! Você cadastrou o aluno: \n" + aluno.ExibirInformacoes());
                    break;
                case "Professor":
                    Professor professor = new Professor
                    {
                        nome = name,
                        tipo = TipoUsuario.Professor,
                        numeroRegistro = int.Parse(numeroRegistro),
                        departamento = departamento
                    };
                    mainForm.usuarios.Add(professor);
                    MessageBox.Show("Parabéns! Você cadastrou o professor: \n" + professor.ExibirInformacoes());
                    break;
            }
        }
    }
}
