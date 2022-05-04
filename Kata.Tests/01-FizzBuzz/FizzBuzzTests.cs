
namespace Kata.FizzBuzz.Tests;
public class FizzBuzzTests
{
    [Theory]
    [InlineData(1,"1")]
    

    public void TestGetFizzBuzz(int input,string expected)
    {
        // Arrange
        var sut = new FizzBuzz();
        // Act
        var actual = sut.GetFizzBuzz(input);
        // Assert
        actual.Should().Be(expected);
    }
}

