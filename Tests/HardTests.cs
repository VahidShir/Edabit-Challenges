using EdabitChallenges;

using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Tests;

public class HardTests
{
    [Theory]
    [InlineData("Marta appreciated deep perpendicular right trapezoids", true)]
    [InlineData("Someone is outside the doorway", false)]
    [InlineData("She eats super righteously", true)]
    [InlineData("Ben naps so often", true)]
    [InlineData("Cute triangles are cute", false)]
    [InlineData("Mad dislikes sharp pointy yoyos", true)]
    [InlineData("Rita asks Sam mean numbered dilemmas", true)]
    [InlineData("Marigold daffodils streaming happily.", false)]
    [InlineData("Simply wonderful laughing.", false)]

    public void IsSmooth(string sentence, bool result)
    {
        //Act
        bool actualResult = Hard.IsSmoothV4(sentence);

        //Assert
        Assert.Equal(result, actualResult);
    }

    [Theory]
    [InlineData("#CD5C5C", true)]
    [InlineData("#EAECEE", true)]
    [InlineData("#eaecee", true)]
    [InlineData("#CD5C58C", false)]
    [InlineData("#CD5C5Z", false)]
    [InlineData("#CD5C&C", false)]
    [InlineData("CD5C5C", false)]
    [InlineData("#123CCCD", false)]
    [InlineData("#123456", true)]
    [InlineData("#987654", true)]
    [InlineData("#9876543", false)]
    [InlineData("#CCCCCC", true)]
    [InlineData("#ZCCZCC", false)]
    [InlineData("#Z88Z99", false)]
    [InlineData("#Z88!99", false)]

    public void IsValidHexCode(string sentence, bool result)
    {
        //Act
        bool actualResult = Hard.IsValidHexCode(sentence);

        //Assert
        Assert.Equal(result, actualResult);

    }
}