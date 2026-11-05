# SoftPay API

API em .NET 10 com Entity Framework Core e PostgreSQL.

## Configuração do banco

Configure a conexão PostgreSQL na chave `ConnectionStrings:SoftPay`. Uma opção é definir a variável de ambiente `ConnectionStrings__SoftPay` com a string de conexão do banco local. Para ambientes compartilhados, utilize um gerenciador de segredos e evite incluir credenciais no repositório.

Para iniciar a API:

```sh
dotnet run --project SoftPay.APi
```
