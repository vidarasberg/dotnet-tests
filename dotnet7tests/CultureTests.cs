using System.Globalization;

namespace dotnet7tests;

public class CultureTests
{
    [Fact]
    public void rounding_culture_swedish_dot()
    {
        var success = decimal.TryParse("0.13", NumberStyles.Any, new CultureInfo("en-US"), out var rounding);
        rounding.Should().Be(0.13m);
    }

    [Fact]
    public void rounding_culture_swedish_comma()
    {
        var success = decimal.TryParse("0,13", NumberStyles.Any, new CultureInfo("sv-SE"), out var rounding);
        rounding.Should().Be(0.13m);
    }

    [Fact]
    public void rounding_culture_invariant_dot()
    {
        var success = decimal.TryParse("0.13", NumberStyles.Any, CultureInfo.InvariantCulture, out var rounding);
        rounding.Should().Be(0.13m);
    }

    [Fact]
    public void rounding_culture_invariant_comma()
    {
        var success = decimal.TryParse("0,13", NumberStyles.Any, CultureInfo.InvariantCulture, out var rounding);
        rounding.Should().Be(13m);
    }
}
