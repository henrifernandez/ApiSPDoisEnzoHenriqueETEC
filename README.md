# API de alunos (ETEC)

API REST de cadastro de alunos feita em ASP.NET Core 8 durante o curso técnico na ETEC. Usa Entity Framework Core com SQL Server (LocalDB) e documentação interativa com Swagger.

## Endpoints

Todas as rotas ficam em `api/Aluno`.

| Método | Rota | Ação |
|---|---|---|
| GET | `/api/Aluno` | Lista os alunos |
| GET | `/api/Aluno/{id}` | Busca um aluno |
| POST | `/api/Aluno` | Cadastra um aluno |
| PUT | `/api/Aluno/{id}` | Atualiza um aluno |
| DELETE | `/api/Aluno/{id}` | Remove um aluno |

## Como rodar

Requisitos: .NET 8 SDK e SQL Server LocalDB.

```bash
dotnet restore
dotnet ef database update   # cria o banco local
dotnet run
```

Em ambiente de desenvolvimento, o Swagger abre em `/swagger`.

## Observação

O projeto referencia `..\CoreBusines\CoreBusines.csproj`, que guarda o modelo `Aluno` e não está incluído neste repositório. Por isso o build completo depende dessa pasta ao lado.
