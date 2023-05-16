## Sistema de Gerenciamento de Funcionários

Este é um sistema de gerenciamento de funcionários que permite criar, ler, atualizar e excluir registros de funcionários. O sistema foi desenvolvido utilizando o padrão de arquitetura MVC no ASP.NET 7. Utilizando ORM, Entity Framework.

## Instalação

Antes de executar o sistema, é necessário realizar algumas configurações no ambiente de desenvolvimento. Primeiramente, é preciso instalar o .NET 7 SDK em sua máquina.

Em seguida, faça o download do projeto e abra-o em sua IDE preferida. No Visual Studio, basta abrir o arquivo GerenciamentoFuncionarios.sln. Caso esteja utilizando outro editor, navegue até a pasta raiz do projeto e abra o arquivo README.md para encontrar mais informações.


## Execução do Sistema

Após realizar as configurações necessárias, execute o sistema pressionando F5 no Visual Studio ou executando o comando dotnet run no terminal na pasta raiz do projeto.

O sistema será aberto em seu navegador padrão. A partir daí, você pode utilizar as funcionalidades do sistema, que incluem:

Criação de novos funcionários
Leitura dos dados dos funcionários cadastrados
Atualização dos dados dos funcionários
Exclusão dos registros de funcionários
Contribuição
Este é um projeto de código aberto e contribuições são bem-vindas. Sinta-se à vontade para fazer um fork do projeto e submeter pull requests com novas funcionalidades, correções de bugs ou melhorias na documentação.

## Configuração do Banco de Dados

Para configurar o projeto, siga os seguintes passos:

1. Clone o repositório para sua máquina local
2. Abra o arquivo `appsettings.json` e configure a string de conexão com o banco de dados
3. Abra o Visual Studio e execute o comando `dotnet ef database update` no Console do Gerenciador de Pacotes para criar o banco de dados
4. Inicie o projeto



