using EdabitChallenges;

using NUnit.Framework;

namespace Tests.NUnitTests;


[TestFixture]
public class MediumTests
{
  [Test]
  [TestCase("@edabit.com", ExpectedResult=false)]
  [TestCase("@edabit", ExpectedResult=false)]
  [TestCase("matt@edabit.com", ExpectedResult=false)]
  [TestCase("", ExpectedResult=false)]
  [TestCase("hello.gmail@com", ExpectedResult=false)]
  [TestCase("bill.gates@microsoft.com", ExpectedResult=true)]
  [TestCase("hello@email", ExpectedResult=false)]
  [TestCase("%^%$#%^%", ExpectedResult=false)]
  [TestCase("www.email.com", ExpectedResult=false)]
  [TestCase("email", ExpectedResult=false)]
    public static bool FixedTest(string str)
    {
        return Medium.ValidateEmail(str);
    }

    [Test]
    [TestCase("4 5 29 54 4 0 -214 542 -64 1 -3 6 -6", ExpectedResult = "542 -214")]
    [TestCase("1 -1", ExpectedResult = "1 -1")]
    [TestCase("-1 -1", ExpectedResult = "-1 -1")]
    [TestCase("1 -1 0", ExpectedResult = "1 -1")]
    [TestCase("1 1 0", ExpectedResult = "1 0")]
    [TestCase("-1 -1 0", ExpectedResult = "0 -1")]
    [TestCase("42", ExpectedResult = "42 42")]
    [TestCase("1 1", ExpectedResult = "1 1")]
    public static string HighLow(string str)
    {
        return Medium.HighLow(str);
    }

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

    public static string MaskifyV2(string str)
    {
        return Medium.MaskifyV2(str);
    }
}