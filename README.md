<p align="center">
  <img alt="GitHub language count" src="https://img.shields.io/github/languages/count/matheushlima/ColetaDadosInvesting?color=%2304D361">
  <img alt="Repository size" src="https://img.shields.io/github/repo-size/matheushlima/ColetaDadosInvesting">  
  <a href="https://github.com/matheushlima/ColetaDadosInvesting/tree/main">
    <img alt="GitHub last commit" src="https://img.shields.io/github/last-commit/matheushlima/ColetaDadosInvesting">
  </a>    
   <img alt="License" src="https://img.shields.io/badge/license-MIT-brightgreen">   
</p>

<h1 align="center">
    TradeAPI / RoboCotacao
</h1>

<h4 align="center"> 
	Concluído
</h4>

<p align="center">
 <a href="#-sobre-o-projeto">Sobre</a> •
 <a href="#%EF%B8%8F-funcionalidades">Funcionalidades</a> •
 <a href="#-como-executar-o-projeto">Como executar</a> • 
 <a href="#-tecnologias">Tecnologias</a> • 
 <a href="#-autor">Autor</a> • 
 <a href="#user-content--licença">Licença</a>
</p>

## 💻 Sobre os projetos

TradeAPI - plataforma para cadastro e consulta de cotações de moedas e ações.

RoboCotação - Robô para obter dados do site investing.com utilizando o Selenium e enviar os dados coletados para uma API.

---

## ⚙️ Funcionalidades

TradeAPI
- [x] Cadastro de ações e moedas
- [x] Consulta de ações e moedas

RoboCotação
- [x] Obtenção de dados do site investing.com
- [x] Envio de dados para API.

---

## 🚀 Como executar os projetos

## TradeAPI

1. Backend (pasta Trade.API)

### Rodando a API
```bash

# Clone este repositório
$ git clone https://github.com/matheushlima/ColetaDadosInvesting.git

# Acesse a pasta do projeto no terminal/cmd
$ cd TradeAPI/TradeAPI

# Instale as dependências
$ dotnet restore

# Execute a aplicação em modo de desenvolvimento
$ dotnet run

# O servidor inciará na porta:5180 - acesse http://localhost:5180

```
Caso a comunicação com o banco de dados apresente alguma falha, será necessario verificar as configurações de comunicação com o banco.
https://github.com/matheushlima/ColetaDadosInvesting/blob/main/TradeAPI/TradeAPI/appsettings.json 

## Banco de dados

Nestre projeto foi utilizado o PostgreSQL como banco de dados.

Para a criação das tabelas acessar a pasta "scripts" dentro do projeto TradeAPI e executar os scripts no banco de dados.

## Robô

Com o repositório já clonado

```bash
# Acesse a pasta do projeto no terminal/cmd
$ cd RoboCotacao

# Execute a aplicação em modo de desenvolvimento
$ dotnet run
```

Caso for copiar o executavel do projeto para outra pasta, colocar a pasta "Driver" no mesmo local.
O mesmo deve ser feito com as pastas Debug ou Release.

---

## 🛠 Tecnologias

As seguintes ferramentas estão sendo utilizadas na construção do projeto:

#### **Server**

- **[.NET](https://dotnet.microsoft.com/en-us/)**
- **[EF Core](https://docs.microsoft.com/pt-br/ef/core/)**

#### **Utilitários**

- IDE: **[Visual Studio](https://visualstudio.microsoft.com/)**
- Teste de API: **[Swagger](https://swagger.io/)**

---

## Autor

 <img style="border-radius: 50%;" src="https://avatars.githubusercontent.com/u/61208750?s=400&u=3e0e3cb2cb77fece3d1ff59f477d441d123769bb&v=4" width="100px;" alt=""/>
 <br />
 <sub><b>Matheus Henrique</b></sub>

[![Linkedin Badge](https://img.shields.io/badge/-Matheus-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/matheus-henrique-31b974118/)](https://www.linkedin.com/in/matheus-henrique-31b974118/)
[![Gmail Badge](https://img.shields.io/badge/-math.henry04@hotmail.com-c14438?style=flat-square&logo=Gmail&logoColor=white&link=mailto:math.henry04@hotmail.com)](mailto:math.henry04@hotmail.com)

---

## 📝 Licença

Este projeto esta sobe a licença [MIT](./LICENSE).
