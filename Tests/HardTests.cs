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

    [Theory]
    [InlineData(5, 31, 33, 1)]
    [InlineData(4, 250, 1300, 3)]
    [InlineData(2, 49, 65, 2)]
    [InlineData(3, 1, 27, 3)]
    [InlineData(10, 1, 5, 1)]
    [InlineData(1, 1, 5, 5)]
    [InlineData(2, 1, 100, 10)]

    public void PowerRanger(int n, int min, int max, int expectedResult)
    {
        //Act
        int actualResult = Hard.PowerRanger(n, min, max);

        //Assert
        Assert.Equal(expectedResult, actualResult);

    }

    [Theory]
    [InlineData(new int[] { 2, 3, 5 }, 720, new int[] { 4, 2, 1 })]
    [InlineData(new int[] { 2, 3, 19 }, 1026, new int[] { 1, 3, 1 })]
    [InlineData(new int[] { 2, 3, 5 }, 600, new int[] { 3, 1, 2 })]
    [InlineData(new int[] { 2, 37, 149 }, 11026, new int[] { 1, 1, 1 })]
    [InlineData(new int[] { 2, 3, 5 }, 180, new int[] { 2, 2, 1 })]
    [InlineData(new int[] { 2, 5, 2711 }, 54220, new int[] { 2, 1, 1 })]

    public void ProductEqualTarget(int[] arr, int target, int[] expectedResult)
    {
        //Act
        var actualResult = Hard.ProductEqualTarget(arr, target);

        //Assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Theory]
    [InlineData(new int[] { 2, 3, 5 }, 720, new int[] { 4, 2, 1 })]
    [InlineData(new int[] { 2, 3, 19 }, 1026, new int[] { 1, 3, 1 })]
    [InlineData(new int[] { 2, 3, 5 }, 600, new int[] { 3, 1, 2 })]
    [InlineData(new int[] { 2, 37, 149 }, 11026, new int[] { 1, 1, 1 })]
    [InlineData(new int[] { 2, 3, 5 }, 180, new int[] { 2, 2, 1 })]
    [InlineData(new int[] { 2, 5, 2711 }, 54220, new int[] { 2, 1, 1 })]

    public void ProductEqualTargetV2(int[] arr, int target, int[] expectedResult)
    {
        //Act
        var actualResult = Hard.ProductEqualTargetV2(arr, target);

        //Assert
        Assert.Equal(expectedResult, actualResult);
    }
}

