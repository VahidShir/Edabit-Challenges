using EdabitChallenges;

using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Tests;

public class VeryHardTests
{
    [Theory]
    [InlineData("5/7", "5/7")]
    [InlineData("4/6", "2/3")]
    [InlineData("11/10", "11/10")]
    [InlineData("8/4", "2")]
    [InlineData("7/4", "7/4")]
    [InlineData("6/4", "3/2")]
    [InlineData("300/200", "3/2")]
    [InlineData("50/25", "2")]
    [InlineData("5/45", "1/9")]

    public void Simplify(string fraction, string expectedResult)
    {
        //Act
        string actualResult = VeryHard.Simplify(fraction);

        //Assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Theory]
    [InlineData(1, "invalid")]
    [InlineData(3, "b, a, ab")]
    [InlineData(7, "b, a, ab, aba, abaab, abaababa, abaababaabaab")]
    [InlineData(10, "b, a, ab, aba, abaab, abaababa, abaababaabaab, abaababaabaababaababa, abaababaabaababaababaabaababaabaab, abaababaabaababaababaabaababaabaababaababaabaababaababa")]
    [InlineData(15, "b, a, ab, aba, abaab, abaababa, abaababaabaab, abaababaabaababaababa, abaababaabaababaababaabaababaabaab, abaababaabaababaababaabaababaabaababaababaabaababaababa, abaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaab, abaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababa, abaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaab, abaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababa, abaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaab")]

    public void FiboWord(int n, string expectedResult)
    {
        //Act
        string actualResult = VeryHard.FiboWord(n);

        //Assert
        Assert.Equal(expectedResult, actualResult);
    }
}