using FluentAssertions;

namespace greet.test;

public class UnitTest1
{
    [Theory(DisplayName = "Testa os retornos de GreetMessage")]
    [InlineData("Hello, World")]
    [InlineData("Olá, Mundo!")]
    [InlineData("Hello!")]
    [InlineData("Olá")]
    [InlineData("Greet!")]
    public void GreetTest(string expected) {  
        string result = Greet.GreetMessage(expected);

        result.Should().Be(expected);
    }
}