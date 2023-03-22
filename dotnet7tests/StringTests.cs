namespace dotnet7tests;

public class UnitTest1
{
    [Fact]
    public void trim_newline()
    {
        var input = "vidar  \r\n\n\t ";
        var actual = input.Trim();
        actual.Should().Be("vidar");
    }
}
