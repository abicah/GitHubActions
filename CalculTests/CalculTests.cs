
using FluentAssertions;
 

public class CalculTests
{
    
    [Theory]
    [InlineData(1, 2, 3)]
    public void Add_TwoNumbers_ReturnsSum(int a,int b,int expected)
    {
        //Assert
         Calcul c=new();
        //Act
         int actual= c.Add(a,b);
         //Arrange
         actual.Should().Be(expected);

    }

    [Theory]
    [InlineData(2, 1, 1)]
    public void Sub_TwoNumbers_ReturnsSubstraction(int a,int b,int expected)
    {
        //Assert
         Calcul c=new();
        //Act
         int actual= c.Sub(a,b);
         //Arrange
         actual.Should().Be(expected);

    }

     [Theory]
    [InlineData(2, 3, 6)]
    public void Mult_TwoNumbers_ReturnsProduct(int a,int b,int expected)
    {
        //Assert
         Calcul c=new();
        //Act
         int actual= c.Mult(a,b);
         //Arrange
         actual.Should().Be(expected);

    }

}