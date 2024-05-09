using EdabitChallenges;

using Microsoft.VisualStudio.TestPlatform.TestHost;

using NUnit.Framework;

namespace Tests.NUnitTests;


[TestFixture]
public class Mediumtests
{
  [Test]
  [TestCase("test", ExpectedResult ="es")]
  [TestCase("testing", ExpectedResult="t")]
  [TestCase("middle", ExpectedResult="dd")]
  [TestCase("A", ExpectedResult="A")]
  [TestCase("inhabitant", ExpectedResult="bi")]
  [TestCase("brown", ExpectedResult="o")]
  [TestCase("pawn", ExpectedResult="aw")]
  [TestCase("cabinet", ExpectedResult="i")]
  [TestCase("fresh", ExpectedResult="e")]
  [TestCase("shorts", ExpectedResult="or")]
    public static string FixedTest(string str)
    {
        return Medium.GetMiddle(str);
    }
}