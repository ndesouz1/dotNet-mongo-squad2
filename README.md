<<<<<<< HEAD
=======
# dotNet-mongo-squad2
continuation of the project dotNet-mongo-squad2 from Digital Innovation One


>>>>>>> 7cf34ae19aa4017a0419a48b7ac4e57ce4f295a0
<h1 align="center">Uma aplicação completa para diário de Classe Conectada com a Api online</h1>

Esse repo é um projeto incrível da DioX Squad
[Digital Innovation One](https://digitalinnovation.one/sign-up?ref=QFX2ZVP4RU)

![](https://img.shields.io/github/stars/4lexRossi/dotNet-mongo-squad1.svg) ![](https://img.shields.io/github/forks/4lexRossi/dotNet-mongo-squad1.svg) ![](https://img.shields.io/github/issues/4lexRossi/dotNet-mongo-squad1.svg)

## Conectar online
esse projeto está online e pode ser acessado pelo link

[Teacher-ADM](https://teacher-adm.azurewebsites.net/)

## clone o repositório 

`git clone https://github.com/4lexRossi/dotNet-mongo-squad1.git`

## Stack utilizada no backend:

 * dotnet 3.1.300
 * Asp.NetCore
 * C#
 * Mongo DB Atlas Database

## Stack utilizada no frontend:

 * Angular 9
 * bootstrap jquery

## Instalar dependências na API
```
    dotnet add package MongoDB.Driver
```

Criar uma conta no [MongoDB](https://www.mongodb.com/)
Após a criação terá que alterar o campo 

```
"ConnectionString": "mongodb+srv://seu_usuario:sua_senha@dotnet-mongo-seu_usuario-v5slk.gcp.mongodb.net/test?retryWrites=true&w=majority"
no arquivo appsettings.json
```

## Para iniciar o servidor backend, use o comando:

```
   dotnet run
```
## Instale as dependencias no front na pasta Estudantes com os comandos

`npm install -g @angular/cli@9.0.0-rc.7`

`npm install bootstrap jquery --save`

## Execute o frontend:

com o comando `ng serve`

porta -> [localhost:4200](http://localhost:4200/)

### Todos o Processo é enviado ao DB

>crie uma conta e faça o Login

![](https://imgur.com/QcgsVoA.jpg)
![](https://imgur.com/JqPq8j4.jpg)

>adicione alunos, visualize, edite ou delete

![](https://imgur.com/JinajFx.jpg)
![](https://imgur.com/bvwn7j2.jpg)

>adicione atividades e depois atribua aos alunos que as concluirem
![](https://imgur.com/PqCflYQ.jpg)
![](https://imgur.com/oZRwu1T.jpg)


