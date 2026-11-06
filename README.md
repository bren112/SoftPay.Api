# SoftPay API

API em .NET 10 com Entity Framework Core e PostgreSQL.

## Configuração do banco

Configure a conexão PostgreSQL na chave `ConnectionStrings:SoftPay`. Uma opção é definir a variável de ambiente `ConnectionStrings__SoftPay` com a string de conexão do banco local. Para ambientes compartilhados, utilize um gerenciador de segredos e evite incluir credenciais no repositório.

Para iniciar a API:

```sh
dotnet run --project SoftPay.APi
```

## Saúde da aplicação

- `GET /health/live`: indica se a API está respondendo, sem consultar dependências.
- `GET /health/ready`: verifica se a API consegue se conectar ao PostgreSQL. Retorna HTTP 200 quando o banco está acessível e 503 quando não está.

Configure a conexão antes de iniciar a API, inclusive para usar essas verificações.
