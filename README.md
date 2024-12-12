# Compass Teste

Esta aplicação faz uso das seguintes tecnologias e práticas:
- **.NET WEB API**: Versão 8.0.
- **Entity Framework**: Utilizado para mapeamento objeto-relacional (ORM) e acesso a dados.
- **Dapper**: Utilizado para consultas SQL de alto desempenho.
- **Clean Architecture**: Adotada para garantir uma separação clara de responsabilidades e facilitar a manutenção e escalabilidade do código.
- **Banco de Dados SQL**: Utilizado para armazenamento e gerenciamento de dados.
- **Angular versão 16**: Framework front-end utilizado para construção da interface do usuário.
- **Node.js versão 18.16.1**: Ambiente de execução JavaScript utilizado para desenvolvimento e execução do Angular.
- **Bootstrap**: Utilizado para estilização e design responsivo no Angular.
- **Swagger**: Utilizado para documentação e teste dos endpoints da API.



## Endpoints

### GET

| Endpoint       | Descrição                     |
| -------------- | ----------------------------- |
| `/api/produtos` | Obtém a lista de produtos     |



## Estrutura do Projeto

| Camada       | Descrição                                                                 |
| ------------ | ------------------------------------------------------------------------- |
| **Domínio**  | Contém as entidades e interfaces principais do domínio, como `Produto.cs`.|
| **API**      | Implementa os controladores e endpoints da API, como `ProdutoController.cs`.|
| **Infra**    | Contém a implementação de acesso a dados, repositórios e configurações de banco de dados.|
| **App**      | Front-end da aplicação, desenvolvido com Angular, responsável pela interface do usuário.|

### Executando a API

1. **Setar o projeto API como padrão de execução**:
   - No Visual Studio, clique com o botão direito no projeto da API (`Compass.Api`) no Solution Explorer.
   - Selecione "Set as Startup Project".

2. **Subir a Migration**:
   - Abra o Console do Gerenciador de Pacotes (Package Manager Console) no Visual Studio.
   - Execute o comando para aplicar as migrations e criar o banco de dados:
     ```sh
     Update-Database
     ```

3. Executar o debug API via https https://localhost:7019/
//Link de acesso á API: https://localhost:7019/swagger/index.html

### Executando o Front-end (Angular)

1. **Instalar os módulos do Node.js**:
   - Abra um terminal na pasta do projeto Angular (`Compass.Teste.App`).
   - Execute o comando para instalar as dependências:
     ```sh
     npm install
     ```

2. **Rodar o servidor de desenvolvimento do Angular**:
   - No mesmo terminal, execute o comando para iniciar o servidor de desenvolvimento:
     ```sh
     ng serve
     ```
   - O front-end estará disponível em `http://localhost:4200`.
