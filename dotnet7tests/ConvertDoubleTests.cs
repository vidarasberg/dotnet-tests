using System.Globalization;

namespace dotnet7tests;

public class ConvertDoubleTests
{
    [Fact]
    public void should_throw()
    {
        //arrange
        const string input = "15.98";

        //act
        Action actual = () => Convert.ToDouble(input);

        //assert
        actual.Should().Throw<FormatException>();
    }

    [Fact]
    public void test_culture()
    {
        //arrange
        const string input = "15.98";

        //act
        var actual = Convert.ToDouble(input, CultureInfo.InvariantCulture);

        //assert
        actual.Should().Be(15.98);
    }

    [Fact]
    public void test2()
    {
        //arrange
        const string input = "15,98";

        //act
        var actual = Convert.ToDouble(input);

        //assert
        actual.Should().Be(15.98);
    }
}