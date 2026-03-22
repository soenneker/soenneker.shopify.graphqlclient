using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Shopify.GraphQlClient.Tests;

[Collection("Collection")]
public sealed class ShopifyGraphQlClientTests : FixturedUnitTest
{
    public ShopifyGraphQlClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {

    }

    [Fact]
    public void Default()
    {

    }
}
