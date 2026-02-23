using GenericCalculator;

namespace GenericCalculatorTest;

public class CalculatorTests
{
    [Fact]
    public void TestCalculatorAddCorrectlyAddsTwoIntegers()
    {

        //Arrange
        var intCalc = new Calculator<int>();
        var x = 10;
        var y = 20;
        var fasit = 30;


        //Act
        var result = intCalc.Add(x, y);


        //Assert
        Assert.Equal(fasit, result);
    }

    [Theory]
    [MemberData(nameof(SumTests))]
    public void TestCalculatorAddUknownNumbersOfIntegersTogether(int expected, params int[] nums)
    {
        //Arrange
        var intCalc = new Calculator<int>();
        //Act
        var result = intCalc.Add(nums);

        //Assert
        Assert.Equal(result, expected);
    }

    [Fact]
    public void TestCalculatorMultipliesTwoIntegersCorrectly()
    {
        //Arrange
        var intCalc = new Calculator<int>();
        var x = 10;
        var y = 20;
        var fasit = 200;
        //Act
        var result = intCalc.Multiply(x, y);


        //Assert
        Assert.Equal(fasit, result);
    }

    [Fact]
    public void TestAggregateMultiplyAggregatesCorrectly()
    {
        //Arrange
        var intCalc = new Calculator<int>();
        int[] nums = [2,3,4,5];
        int expected = 120;

        //Act

        var result = intCalc.Multiply(nums);

        //Assert
        Assert.Equal(result, expected);
    }

    public static IEnumerable<object[]> SumTests()
    {
        yield return [30, 10, 20];
        yield return [9, 2, 3, 4];
        yield return [15, 5, 6, 4];
        yield return [5, 2, 1, 2];
    }
}