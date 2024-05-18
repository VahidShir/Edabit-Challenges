using EdabitChallenges;

using Microsoft.VisualStudio.TestPlatform.TestHost;

using NUnit.Framework;
using NUnit.Framework.Legacy;

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

    [Test]
    [TestCase("12/03/2020", ExpectedResult = "19/03/2020")]
    [TestCase("21/12/1989", ExpectedResult = "28/12/1989")]
    [TestCase("01/01/2000", ExpectedResult = "08/01/2000")]
    [TestCase("24/09/1924", ExpectedResult = "01/10/1924")]
    [TestCase("21/07/1964", ExpectedResult = "28/07/1964")]
    [TestCase("14/07/2085", ExpectedResult = "21/07/2085")]
    [TestCase("25/04/1953", ExpectedResult = "02/05/1953")]
    [TestCase("02/01/2200", ExpectedResult = "09/01/2200")]
    [TestCase("06/01/2007", ExpectedResult = "13/01/2007")]
    [TestCase("07/04/2195", ExpectedResult = "14/04/2195")]
    [TestCase("04/09/2094", ExpectedResult = "11/09/2094")]
    [TestCase("20/08/1910", ExpectedResult = "27/08/1910")]
    [TestCase("12/12/1894", ExpectedResult = "19/12/1894")]
    [TestCase("02/11/2094", ExpectedResult = "09/11/2094")]
    [TestCase("22/12/1955", ExpectedResult = "29/12/1955")]
    [TestCase("18/04/1859", ExpectedResult = "25/04/1859")]
    [TestCase("17/03/1847", ExpectedResult = "24/03/1847")]
    [TestCase("17/03/2142", ExpectedResult = "24/03/2142")]
    [TestCase("26/01/2145", ExpectedResult = "02/02/2145")]
    [TestCase("03/12/1959", ExpectedResult = "10/12/1959")]
    [TestCase("01/06/1947", ExpectedResult = "08/06/1947")]
    [TestCase("26/12/1853", ExpectedResult = "02/01/1854")]
    [TestCase("27/10/2068", ExpectedResult = "03/11/2068")]
    [TestCase("05/05/2080", ExpectedResult = "12/05/2080")]
    [TestCase("22/12/2144", ExpectedResult = "29/12/2144")]
    [TestCase("12/05/1870", ExpectedResult = "19/05/1870")]
    [TestCase("07/01/1882", ExpectedResult = "14/01/1882")]
    [TestCase("16/06/2032", ExpectedResult = "23/06/2032")]
    [TestCase("02/10/2007", ExpectedResult = "09/10/2007")]
    [TestCase("24/03/1871", ExpectedResult = "31/03/1871")]
    [TestCase("19/08/1847", ExpectedResult = "26/08/1847")]
    [TestCase("24/07/2157", ExpectedResult = "31/07/2157")]
    [TestCase("28/12/1848", ExpectedResult = "04/01/1849")]
    [TestCase("20/07/1951", ExpectedResult = "27/07/1951")]
    [TestCase("14/11/2071", ExpectedResult = "21/11/2071")]
    [TestCase("07/12/2170", ExpectedResult = "14/12/2170")]
    [TestCase("01/03/2080", ExpectedResult = "08/03/2080")]
    [TestCase("28/04/1906", ExpectedResult = "05/05/1906")]
    [TestCase("15/06/2023", ExpectedResult = "22/06/2023")]
    [TestCase("11/08/1950", ExpectedResult = "18/08/1950")]
    [TestCase("15/11/2103", ExpectedResult = "22/11/2103")]
    [TestCase("23/11/1852", ExpectedResult = "30/11/1852")]
    [TestCase("08/01/1928", ExpectedResult = "15/01/1928")]
    [TestCase("14/11/2118", ExpectedResult = "21/11/2118")]
    [TestCase("11/10/2096", ExpectedResult = "18/10/2096")]
    [TestCase("02/12/1816", ExpectedResult = "09/12/1816")]
    [TestCase("10/10/1937", ExpectedResult = "17/10/1937")]
    [TestCase("28/11/1959", ExpectedResult = "05/12/1959")]
    [TestCase("27/05/2133", ExpectedResult = "03/06/2133")]
    [TestCase("28/04/1932", ExpectedResult = "05/05/1932")]
    [TestCase("23/02/2050", ExpectedResult = "02/03/2050")]
    [TestCase("23/05/2146", ExpectedResult = "30/05/2146")]
    [TestCase("24/07/2167", ExpectedResult = "31/07/2167")]
    public static string TestSolution(string date)
    {
        return Hard.WeekAfter(date);
    }

    [Test]
    [TestCase("abcde", ExpectedResult = 0)]
    [TestCase("Aa", ExpectedResult = 0)]
    [TestCase("aabbcde", ExpectedResult = 2)]
    [TestCase("aabbcdeB", ExpectedResult = 2)]
    [TestCase("indivisibility", ExpectedResult = 1)]
    [TestCase("Indivisibilities", ExpectedResult = 2)]
    [TestCase("aa1112", ExpectedResult = 2)]
    [TestCase("bb2c", ExpectedResult = 1)]
    public static int FixedTest(string str)
    {
        return Hard.DuplicateCount2(str);
    }

    [Test]
    [TestCase(new int[] { 5, 1, 4, 3, 2 }, ExpectedResult = true)]
    [TestCase(new int[] { 55, 59, 58, 56, 57 }, ExpectedResult = true)]
    [TestCase(new int[] { -3, -2, -1, 1, 0 }, ExpectedResult = true)]
    [TestCase(new int[] { 5, 1, 4, 3, 2, 8 }, ExpectedResult = false)]
    [TestCase(new int[] { 5, 6, 7, 8, 9, 9 }, ExpectedResult = false)]
    [TestCase(new int[] { 5, 3 }, ExpectedResult = false)]
    public static bool FixedTest(int[] arr) =>
        Hard.Cons(arr);

    [Test]
    public void TestCupSwapping()
    {
        var i = 1;
        ClassicAssert.AreEqual(Hard.CupSwapping(new String[] { "AB", "CA" }), "C", $"Test {i++}");
        ClassicAssert.AreEqual(Hard.CupSwapping(new String[] { "AB", "CA", "AB" }), "C", $"Test {i++}");
        ClassicAssert.AreEqual(Hard.CupSwapping(new String[] { "AC", "CA", "CA", "AC" }), "B", $"Test {i++}");
        ClassicAssert.AreEqual(Hard.CupSwapping(new String[] { "BA", "AC", "CA", "BC" }), "A", $"Test {i++}");
        ClassicAssert.AreEqual(Hard.CupSwapping(new String[] { "BC", "CB", "CA", "BA" }), "A", $"Test {i++}");
        ClassicAssert.AreEqual(Hard.CupSwapping(new String[] { "BC" }), "C", $"Test {i++}");
        ClassicAssert.AreEqual(Hard.CupSwapping(new String[] { "BA", "CA", "CB", "CA" }), "B", $"Test {i++}");
        ClassicAssert.AreEqual(Hard.CupSwapping(new String[] { }), "B", $"Test {i++}");
    }

    	[Test]
    public static void TestSolution()
    {	
		var inst1 = new string[] { "right 10", "up 50", "left 30", "down 10" };
		var inst2 = new string[] {  };
		var inst3 = new string[] { "left 10", "left 100", "left 1000", "left 10000" };
		var inst4 = new string[] { "right 100", "right 100", "up 500", "up 10000" }; 
		var inst5 = new string[] { "left 10", "right 10", "down 10", "up 10" };

        ClassicAssert.AreEqual(new int[] { 0, 0 }, Hard.TrackRobot(inst2));
        ClassicAssert.AreEqual(new int[] { -11110, 0 }, Hard.TrackRobot(inst3));
        ClassicAssert.AreEqual(new int[] { 200, 10500 }, Hard.TrackRobot(inst4));
        ClassicAssert.AreEqual(new int[] { -20, 40 }, Hard.TrackRobot(inst1));
        ClassicAssert.AreEqual(new int[] { 0, 0 }, Hard.TrackRobot(inst5));
    }

    [Test]
    [TestCase(10, 15, ExpectedResult="a")]
	[TestCase(13, 16, ExpectedResult="b")]
	[TestCase(53782, 72534, ExpectedResult="b")]
	[TestCase(72221, 11198, ExpectedResult="b")]
	[TestCase(1723817263, 837249873748, ExpectedResult="a")]
	[TestCase(556238, 667822, ExpectedResult="b")]
	[TestCase(4, 3, ExpectedResult="a")]
  	public static string TestSolution(Int64 a, Int64 b)
    {
        return Hard.Collatz(a, b);
    }
}