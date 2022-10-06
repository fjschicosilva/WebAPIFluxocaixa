# WebAPIFluxocaixa
API Rest de exemplo com endpoint´s para CRUD de um fluxo de caixa.
A mesma conta com endpoint GET para buscar todos lançamentos ou lançamento por id, com endpoint POST para buscar os lançamentos consolidados por DATA, endpoint PUT para inclusão de um novo lançamento e endpoint DELETE, para excluir um lançamento.
A mesma usa o framework Hibernate para persist~encia de dados em banco de dados SQL SERVER.
No projeto da API, existe um arquivo CreateDatabase.sql na pasta DB Scripts, que é a script para criação do banco de dados, tabela e inserção de registros exemplso nessa tabela.
Para a api conectar no banco é só alterar a string de conexão que está no arquivo Repositorio.cs da pasta Repository.
A solução também suporta Swagger auxiliar na descrição, consumo e visualização de serviços de API REST.
A solução contém um projeto de teste unitários usando a biblioteca xUnit.
