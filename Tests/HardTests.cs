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
}