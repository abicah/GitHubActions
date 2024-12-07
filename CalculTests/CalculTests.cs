
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
         actual.Should().Be(3);

    }

}