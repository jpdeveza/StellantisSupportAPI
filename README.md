# StellantisSupportAPI


 # StellantisSupport API de Suporte ao Cliente Stellantis

## Descrição do Projeto

Este projeto tem como objetivo melhorar a experiência dos proprietários e potenciais compradores de veículos da Stellantis, oferecendo uma aba de suporte ao cliente no site da Stellantis Brasil. A API fornece informações relevantes sobre desempenho de veículos, dimensões e rodas, além de disponibilizar um suporte instantâneo via chatbot.

A API foi desenvolvida utilizando **ASP.NET Core Web API**, com arquitetura monolítica, integração com banco de dados Oracle, e padrões de design como **Repository Pattern** e **Singleton**.

## Funcionalidades

- CRUD completo para **Consumo e Desempenho** dos veículos.
- CRUD completo para **Peso e Dimensões** dos veículos.
- CRUD completo para **Rodas** dos veículos.
- Integração com banco de dados Oracle utilizando Entity Framework Core.
- Documentação automatizada com **Swagger/OpenAPI**.

## Arquitetura do Projeto

O projeto foi desenvolvido utilizando uma arquitetura **monolítica**, justificada pela simplicidade da aplicação e o fato de ser um MVP (Produto Mínimo Viável). Além disso, a estrutura monolítica permite um desenvolvimento mais rápido e com menos sobrecarga de comunicação entre serviços, o que é ideal para aplicações de pequeno a médio porte.

## Estrutura de Pastas

```plaintext
CarroAPI/
│
├── Controllers/                 # Controladores responsáveis pelos endpoints da API
│   ├── ConsumoDesempenhoController.cs
│   ├── PesoDimensoesController.cs
│   └── RodasController.cs
│
├── Models/                      # Modelos de dados utilizados pela API
│   ├── ConsumoDesempenho.cs
│   ├── PesoDimensoes.cs
│   └── Rodas.cs
│
├── Repositories/                # Repositórios responsáveis pela comunicação com o banco de dados
│   ├── ConsumoDesempenhoRepository.cs
│   ├── PesoDimensoesRepository.cs
│   └── RodasRepository.cs
│
├── Data/                        # Configurações do DbContext e acesso ao banco de dados
│   └── CarroContext.cs
│
├── Migrations/                  # Arquivos gerados pelo Entity Framework Core
│
├── Startup.cs                   # Configurações dos serviços e middlewares da aplicação
├── Program.cs                   # Ponto de entrada da aplicação
├── appsettings.json             # Configurações da aplicação (string de conexão com o banco de dados, etc.)
│
└── CarroAPI.csproj              # Arquivo de projeto do .NET

Configuração e Instalação
Requisitos
.NET Core SDK
SQL Server ou Oracle
Postman ou Insomnia para testar os endpoints da API

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;"
  }
}


Endpoints Disponíveis
Consumo e Desempenho
GET /api/consumodesempenho - Retorna todos os consumos e desempenhos.
GET /api/consumodesempenho/{id} - Retorna o consumo e desempenho por ID.
POST /api/consumodesempenho - Cria um novo registro de consumo e desempenho.
PUT /api/consumodesempenho/{id} - Atualiza o registro de consumo e desempenho por ID.
DELETE /api/consumodesempenho/{id} - Deleta o registro de consumo e desempenho por ID.
Peso e Dimensões
GET /api/pesodimensoes - Retorna todas as informações de peso e dimensões.
GET /api/pesodimensoes/{id} - Retorna informações de peso e dimensões por ID.
POST /api/pesodimensoes - Cria um novo registro de peso e dimensões.
PUT /api/pesodimensoes/{id} - Atualiza o registro de peso e dimensões por ID.
DELETE /api/pesodimensoes/{id} - Deleta o registro de peso e dimensões por ID.
Rodas
GET /api/rodas - Retorna todas as rodas.
GET /api/rodas/{id} - Retorna uma roda por ID.
POST /api/rodas - Cria um novo registro de roda.
PUT /api/rodas/{id} - Atualiza o registro de roda por ID.
DELETE /api/rodas/{id} - Deleta o registro de roda por ID.
Padrões de Design Utilizados
Repository Pattern: Utilizado para isolar a lógica de acesso ao banco de dados e permitir um código mais fácil de testar e manter.
Singleton Pattern: Utilizado para gerenciar configurações e dependências únicas no ciclo de vida da aplicação.

Tecnologias Utilizadas
ASP.NET Core Web API
Entity Framework Core
Swagger/OpenAPI
SQL Server/Oracle


Esse README cobre os aspectos mais importantes do projeto, como descrição, funcionalidades, estrutura de pastas, configuração, endpoints, padrões utilizados, e como rodar a aplicação localmente.
