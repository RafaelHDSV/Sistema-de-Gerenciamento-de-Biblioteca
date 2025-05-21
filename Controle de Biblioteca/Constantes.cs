using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Biblioteca
{
    class Constantes
    {
        public static List<Livro> ObterLivros()
        {
            return new List<Livro>
            {
                new Livro
                {
                    titulo = "O Senhor dos Anéis",
                    autor = "J.R.R. Tolkien",
                    ano = 1954,
                    isbn = "978-0007525546",
                    status = StatusLivro.Disponivel
                },
                new Livro
                {
                    titulo = "1984",
                    autor = "George Orwell",
                    ano = 1949,
                    isbn = "978-0451524935",
                    status = StatusLivro.Emprestado
                }
            };
        }

        public static List<Usuario> ObterUsuarios()
        {
            return new List<Usuario>
            {
                new Aluno
                {
                    nome = "João da Silva",
                    tipo = TipoUsuario.Aluno,
                    ra = 123456,
                    curso = "Ciência da Computação"
                },
                new Professor
                {
                    nome = "Dra. Maria Oliveira",
                    tipo = TipoUsuario.Professor,
                    numeroRegistro = 98765,
                    departamento = "Matemática Aplicada"
                }
            };
        }
    }
}
