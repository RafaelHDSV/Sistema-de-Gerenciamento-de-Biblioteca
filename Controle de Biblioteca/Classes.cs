using System;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Controle_de_Biblioteca
{
    public enum StatusLivro
    {
        Disponivel,
        Emprestado
    }

    public class Livro
    {
        public Guid _id { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public int ano { get; set; }
        public string isbn { get; set; }
        public StatusLivro status { get; set; }

        public Livro()
        {
            _id = Guid.NewGuid();
            status = StatusLivro.Disponivel;
        }

        public void MarcarComoEmprestado() => status = StatusLivro.Emprestado;
        public void MarcarComoDisponivel() => status = StatusLivro.Disponivel;

        public string ExibirInformacoes()
        {
            return $"ID: {_id} \n Título: {titulo} \n Autor: {autor} \n Ano: {ano} \n ISBN: {isbn} \n Status: {status}";
        }
    }

    public enum TipoUsuario
    {
        Aluno,
        Professor
    }

    public abstract class Usuario
    {
        public string _id { get; set; }
        public string nome { get; set; }
        public TipoUsuario tipo { get; set; }

        public string ExibirInformacoes()
        {
            return $"ID: {_id} \n Nome: {nome} \n tipo: {tipo}";
        }
    }

    public class Aluno : Usuario
    {
        public int ra { get; set; }
        public string curso { get; set; }

        public new string ExibirInformacoes()
        {
            return $"ID: {_id} \n Nome: {nome} \n Tipo: {tipo} \n RA: {ra} \n Curso: {curso}";
        }
    }

    public class Professor : Usuario
    {
        public int numeroRegistro { get; set; }
        public string departamento { get; set; }

        public new string ExibirInformacoes()
        {
            return $"ID: {_id} \n Nome: {nome} \n Tipo: {tipo} \n Registro: {numeroRegistro} \n Departamento: {departamento}";
        }
    }

    public class Emprestimo
    {
        public int id { get; set; }
        public Usuario usuario { get; set; }
        public Livro livro { get; set; }
        public string data { get; set; }
        public StatusLivro status { get; private set; } = StatusLivro.Emprestado;

        public void RegistrarDevolucao()
        {
            livro.MarcarComoDisponivel();
            status = StatusLivro.Disponivel;
        }

        public void ExibirResumo()
        {
            Console.WriteLine($"Empréstimo #{id} - Livro: {livro.titulo}, Usuário: {usuario.nome}, Data: {data}, Status: {status}");
        }
    }
}
