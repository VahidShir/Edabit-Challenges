using EdabitChallenges;

using Microsoft.VisualStudio.TestPlatform.TestHost;

using NUnit.Framework;

namespace Tests.NUnitTests;


[TestFixture]
public class Mediumtests
{
    [Test]
    [TestCase("test", ExpectedResult = "es")]
    [TestCase("testing", ExpectedResult = "t")]
    [TestCase("middle", ExpectedResult = "dd")]
    [TestCase("A", ExpectedResult = "A")]
    [TestCase("inhabitant", ExpectedResult = "bi")]
    [TestCase("brown", ExpectedResult = "o")]
    [TestCase("pawn", ExpectedResult = "aw")]
    [TestCase("cabinet", ExpectedResult = "i")]
    [TestCase("fresh", ExpectedResult = "e")]
    [TestCase("shorts", ExpectedResult = "or")]
    public static string GetMiddle(string str)
    {
        return Medium.GetMiddle(str);
    }

    [Test]
    [TestCase("4556364607935616", ExpectedResult = "############5616")]
    [TestCase("64607935616", ExpectedResult = "#######5616")]
    [TestCase("1", ExpectedResult = "1")]
    [TestCase("", ExpectedResult = "")]
    [TestCase("tBy>L/cMe+?<j:6n;C~H", ExpectedResult = "################;C~H")]
    [TestCase("12", ExpectedResult = "12")]
    [TestCase("8Ikhlf6yoxPOwi5cB014eWbRumj7vJ", ExpectedResult = "##########################j7vJ")]
    [TestCase("123", ExpectedResult = "123")]
    [TestCase(")E$aCU=e\"_", ExpectedResult = "######=e\"_")]
    [TestCase("2673951408", ExpectedResult = "######1408")]
    [TestCase("1234", ExpectedResult = "1234")]

    public static string Maskify(string str)
    {
        return Medium.Maskify(str);
    }

    [Test]
    [TestCase("4556364607935616", ExpectedResult = "############5616")]
    [TestCase("64607935616", ExpectedResult = "#######5616")]
    [TestCase("1", ExpectedResult = "1")]
    [TestCase("", ExpectedResult = "")]
    [TestCase("tBy>L/cMe+?<j:6n;C~H", ExpectedResult = "################;C~H")]
    [TestCase("12", ExpectedResult = "12")]
    [TestCase("8Ikhlf6yoxPOwi5cB014eWbRumj7vJ", ExpectedResult = "##########################j7vJ")]
    [TestCase("123", ExpectedResult = "123")]
    [TestCase(")E$aCU=e\"_", ExpectedResult = "######=e\"_")]
    [TestCase("2673951408", ExpectedResult = "######1408")]
    [TestCase("1234", ExpectedResult = "1234")]

    public static string FixedTest(string str)
    {
        return Medium.MaskifyV2(str);
    }
}