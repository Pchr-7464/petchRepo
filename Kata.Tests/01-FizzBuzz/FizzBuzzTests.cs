
namespace Kata.FizzBuzz.Tests;
public class FizzBuzzTests
{
    [Theory]
    [InlineData(1,"1")]
    [InlineData(2,"2")]
    [InlineData(3,"Fizz")]
    [InlineData(5,"Buzz")]
    [InlineData(6,"Fizz")]
    [InlineData(10,"Buzz")]
    [InlineData(15,"FizzBuzz")]

    [InlineData(0,"The number must be greater than 0")]
    [InlineData(101,"The number must be less than 101")]
    

    public void TestGetFizzBuzz(int input,string expected)
    {
        // Arrange
        var sut = new FizzBuzz();
        // Act
        var actual = sut.GetFizzBuzz(input);
        // Assert
        actual.Should().Be(expected);      
    }
    /*public static void Main()
    {
        FizzBuzz fb = new FizzBuzz();
        System.Console.WriteLine.(fb.GetFizzBuzz());
    }
    */
}

