using Soenneker.Utils.CommandLineArgs.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Utils.CommandLineArgs.Tests;

[Collection("Collection")]
public sealed class CommandLineArgsUtilTests : FixturedUnitTest
{
    private readonly ICommandLineArgsUtil _util;

    public CommandLineArgsUtilTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _util = Resolve<ICommandLineArgsUtil>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
