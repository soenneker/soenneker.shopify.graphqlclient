using Soenneker.Tests.HostedUnit;

namespace Soenneker.Shopify.GraphQlClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ShopifyGraphQlClientTests : HostedUnitTest
{
    public ShopifyGraphQlClientTests(Host host) : base(host)
    {

    }

    [Test]
    public void Default()
    {

    }
}
