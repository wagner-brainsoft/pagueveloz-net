# pagueveloz-net

[![CircleCI](https://circleci.com/gh/johnnyasantoss/pagueveloz-net.svg?style=svg)](https://circleci.com/gh/johnnyasantoss/pagueveloz-net)

Biblioteca .NET (C#) de integração com os serviços da API PagueVeloz.

Instanciando o client:

```csharp
var credentials = new PagueVelozCredentials("email", "token");
var client = new PagueVelozClient(PagueVelozEnvironment.Sandbox, credentials); 
```

Emitindo um boleto:

```csharp
var emissao = new EmissaoDTO()
{
    Sacado = "Joãozinho",
    CPFCNPJSacado = "460.844.654-12",
    Valor = 100m,
    Vencimento = DateTime.Today.AddDays(10)
};

var retorno = await client.Boletos.EmitirAsync(emissao);
```

Fazendo um request diretamente na API:

```csharp
var retorno = await client.GetAsync<string>("api/v1/ping");
```
