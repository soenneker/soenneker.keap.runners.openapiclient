using Soenneker.Tests.HostedUnit;

namespace Soenneker.Keap.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class KeapOpenApiClientRunnerTests : HostedUnitTest
{
    public KeapOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
