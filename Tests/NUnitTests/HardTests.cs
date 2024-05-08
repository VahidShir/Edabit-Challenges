using EdabitChallenges;

using NUnit.Framework;

namespace Tests.NUnitTests;


[TestFixture]
public class HardTests
{
    [Test]
    [TestCase(new int[] { 2, 3, 5 }, 720, ExpectedResult = new int[] { 4, 2, 1 })]
    [TestCase(new int[] { 2, 3, 19 }, 1026, ExpectedResult = new int[] { 1, 3, 1 })]
    [TestCase(new int[] { 2, 3, 5 }, 600, ExpectedResult = new int[] { 3, 1, 2 })]
    [TestCase(new int[] { 2, 37, 149 }, 11026, ExpectedResult = new int[] { 1, 1, 1 })]
    [TestCase(new int[] { 2, 3, 5 }, 180, ExpectedResult = new int[] { 2, 2, 1 })]
    [TestCase(new int[] { 2, 5, 2711 }, 54220, ExpectedResult = new int[] { 2, 1, 1 })]
    public static int[] TestSolution(int[] factors, int n)
    {
        return Hard.ProductEqualTarget(factors, n);
    }
}