Projeto B3
Desafio do cálculo CDB

Requisitos
.NET Framework 4.7.2 ou superior
Node.js e npm
Angular CLI
Visual Studio (versão)
Configuração do Projeto
Backend
Navegue até a pasta do projeto no terminal e execute o seguinte comando para restaurar os pacotes NuGet:
dotnet restore

Inicie o projeto com o Visual Studio ou use o seguinte comando:
dotnet run

Frontend
Navegue até a subpasta ClientApp:

cd ClientApp
Instale as dependências do Angular:
npm install

Inicie o servidor de desenvolvimento do Angular (não necessário se o modo de desenvolvimento do ASP.NET Core estiver ativado):
ng serve

Testando o Projeto
Testes no Backend
Navegue até a pasta de testes no terminal.

Execute:
dotnet test

Testes no Frontend
Navegue até ClientApp.

Execute:
ng test

Postman
Para testar a API usando o Postman, importe a coleção do Postman localizada em ./postman/ProjetoB3-Anderson.postman_collection.json