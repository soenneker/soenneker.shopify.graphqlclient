[![](https://img.shields.io/nuget/v/soenneker.shopify.graphqlclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.shopify.graphqlclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.shopify.graphqlclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.shopify.graphqlclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.shopify.graphqlclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.shopify.graphqlclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.shopify.graphqlclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.shopify.graphqlclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Shopify.GraphQlClient

Generated, strongly typed client for Shopify Admin GraphQL mutations, including products, orders, customers, fulfillment, discounts, subscriptions, webhooks, and store configuration.

## Installation

```bash
dotnet add package Soenneker.Shopify.GraphQlClient
```

For application registration and configuration-based authentication, use `Soenneker.Shopify.GraphQlClientUtil`. Instantiate this package directly when you already own the configured `HttpClient`.

## Usage

```csharp
using Soenneker.Shopify.GraphQlClient;

var httpClient = new HttpClient
{
    BaseAddress = new Uri(
        "https://your-store.myshopify.com/admin/api/2026-07/graphql.json")
};
httpClient.DefaultRequestHeaders.Add("X-Shopify-Access-Token", accessToken);

var shopify = new ShopifyGraphQlClient(new GraphQlHttpClient(httpClient));

TagsAddPayload? result = await shopify.Tags.Add.GetValue(
    new TagsAddVariables
    {
        Id = "gid://shopify/Product/1234567890",
        Tags = ["featured"]
    },
    cancellationToken);
```

`GetValue(...)` returns the operation payload directly. Use `Execute(...)` when you also need the GraphQL response envelope and top-level errors. Mutations can change store data; inspect each generated variables and payload type before calling it.
