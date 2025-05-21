# 📙 Sistema de Gerenciamento de Biblioteca

![C# language](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D4?style=for-the-badge&logo=windows&logoColor=white)
![Visual Studio 2022](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white)
![GitHub language count](https://img.shields.io/github/languages/count/RafaelHDSV/Sistema-de-Gerenciamento-de-Biblioteca?style=for-the-badge)
![GitHub repo size](https://img.shields.io/github/repo-size/RafaelHDSV/Sistema-de-Gerenciamento-de-Biblioteca?style=for-the-badge)

<p align="center">
  <img src="https://github.com/user-attachments/assets/86f75661-ebb2-4f13-a40a-62d76fbbf9f8" alt="Tela Principal do Sistema" width="600">
</p>

<p align="center">
    <a href="#about">📌 Sobre</a> • 
    <a href="#features">✨ Funcionalidades</a> • 
    <a href="#started">🚀 Como Executar</a> • 
    <a href="#structure">🏗️ Estrutura do Projeto</a> • 
    <a href="#screenshots">📷 Screenshots</a>
</p>

<h2 id="about">📌 Sobre o Projeto</h2>

Sistema de controle de biblioteca desenvolvido em Windows Forms com C#. Permite gerenciar livros, alunos, professores e empréstimos, com funcionalidades de cadastro, listagem e relatórios organizados.

🔹 **Principais características:**
- Cadastro e listagem de livros
- Cadastro e listagem de alunos
- Cadastro e listagem de professores
- Gerenciamento de empréstimo, com devoluções e empréstimos
- Relatórios organizados com tabelas sobre os dados salvos
- Interface MDI (Multiple Document Interface)
- Validações de dados integradas

⚠️ **Observação:** O sistema não utiliza banco de dados permanente - todas as informações são armazenadas apenas em memória e serão perdidas ao fechar a aplicação.

<h2 id="features">✨ Funcionalidades</h2>

- **Cadastro de Livros**
  - Adição de livros com as propriedades:
    - Título
    - Autor
    - Ano
    - ISBN
    - Status (Disponível / Emprestado) _valor inicial é disponível_
  
- **Cadastro de Usuários**
  - Adição de usuários com dois tipos diferentes e as propriedades:
    - Nome
    - Tipo (Aluno / Professor)
    - Curso (_aluno_)
    - Número de mátricula (_aluno_)
    - Departamento (_professor_)
    - Número de Registro (_professor_)

- **Controle de Empréstimos**
  - Controle de empréstimos e devoluções com as propriedades:
    - Usuário _(classe Usuário)_
    - Livro _(classe Livro)_
    - Status _(Disponível / Emprestado)_

- **Relatórios**
  - Tabela de alunos cadastrados
  - Tabela de professores cadastrados
  - Tabela de livros cadastrados
  - Tabela de livros disponíveis cadastrados
  - Tabela de livros emprestados cadastrados
  - Tabela de histórico de empréstimos

<h2 id="started">🚀 Como Executar o Projeto</h2>

### Pré-requisitos
- Visual Studio 2022
- .NET Framework 4.7.2 ou superior

### Passo a Passo

1. Clone o repositório:
```bash
git clone [https://github.com/RafaelHDSV/Controle-de-Estoque-CSharp-IPOO.git](https://github.com/RafaelHDSV/Sistema-de-Gerenciamento-de-Biblioteca.git)
```

2.  Acesse a pasta do projeto:
```bash
cd Controle-de-Estoque-CSharp-IPOO
```

3.  Abra o arquivo .sln no Visual Studio 2022

4.  Compile e execute o projeto (F5)

<h2 id="structure">🏗️ Estrutura do Projeto</h2>

| Formulário | Descrição
|----------------------|-----------------------------------------------------
| MainForm | Tela principal (MDI Container) com menu de acesso a todas as funcionalidades
| frmCadastroDeLivros | Formulário para cadastro de novos livros no sistema
| frmCadastroDeUsuarios | Formulário para cadastro de novos usuários no sistema
| frmControleDeEmprestimos | Formulário para controle de empréstimos e devoluções
| frmRelatorios | Formulário com tabelas sobre todos os dados salvos no sistema

<h2 id="screenshots">📷 Screenshots</h2>

Tela Principal (MDI Container)
![image](https://github.com/user-attachments/assets/aca14c72-377e-47f7-ba54-8c43405fc1ef)

Consulta de Produtos
![image](https://github.com/user-attachments/assets/917073ae-ba17-40fc-9d39-23240bdd8ad6)

Cadastro de Produtos
![image](https://github.com/user-attachments/assets/207ac9eb-92d1-4e53-931a-47e09da6bac3)

Opções de quantidade disponíveis:
![image](https://github.com/user-attachments/assets/8b887a92-91b9-4546-aa2a-3f148a63c8cd)

Controle de Estoque
![image](https://github.com/user-attachments/assets/fa815907-1436-4fa8-bcf8-7848a27561b2)

<p align="center"> Desenvolvido com ❤️ por <a href="https://github.com/RafaelHDSV">RafaelHDSV</a> </p>
