using System;

namespace Controle_de_Biblioteca
{
    public enum StatusLivro
    {
        Disponivel,
        Emprestado
    }

    public class Livro
    {
        public Guid _id { get; private set; }
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

    public class Usuario
    {
        public Guid _id { get; private set; }
        public string nome { get; set; }
        public TipoUsuario tipo { get; set; }

        public Usuario()
        {
            _id = Guid.NewGuid();
        }

        public virtual string ExibirInformacoes()
        {
            return $"ID: {_id} \n Nome: {nome} \n tipo: {tipo}";
        }
    }

    public class Aluno : Usuario
    {
        public int ra { get; set; }
        public string curso { get; set; }

        public override string ExibirInformacoes()
        {
            return $"ID: {_id} \n Nome: {nome} \n Tipo: {tipo} \n RA: {ra} \n Curso: {curso}";
        }
    }

    public class Professor : Usuario
    {
        public int numeroRegistro { get; set; }
        public string departamento { get; set; }

        public override string ExibirInformacoes()
        {
            return $"ID: {_id} \n Nome: {nome} \n Tipo: {tipo} \n Registro: {numeroRegistro} \n Departamento: {departamento}";
        }
    }

    public class Emprestimo
    {
        public Guid _id { get; private set; }
        public Usuario usuario { get; set; }
        public Livro livro { get; set; }
        public DateTime data { get; set; }
        public DateTime dataDevolucao { get; set; }
        public StatusLivro status { get; set; } = StatusLivro.Emprestado;

        public Emprestimo()
        {
            _id = Guid.NewGuid();
            data = DateTime.Now;
            dataDevolucao = DateTime.Now.AddDays(15);
        }

        public void RegistrarEmprestimo()
        {
            livro.MarcarComoEmprestado();
            status = StatusLivro.Emprestado;
        }

        public void RegistrarDevolucao()
        {
            livro.MarcarComoDisponivel();
            status = StatusLivro.Disponivel;
        }

        public string ExibirInformacoes()
        {
            return $"ID: {_id} \n Usuário: {usuario.nome} \n Livro: {livro.titulo} \n Data: {data} \n Data de Devolução: {dataDevolucao} \n Status: {status}";
        }
    }
}
