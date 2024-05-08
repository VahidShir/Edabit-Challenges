﻿using EdabitChallenges;

using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Tests.NUnitTests;


[TestFixture]
public class VeryHardTests
{
    [Test]
    public static void OverTime()
    {
        
        ClassicAssert.AreEqual("$240.00", VeryHard.OverTime(new [] { 9, 17, 30, 1.5 }));
        ClassicAssert.AreEqual("$240.00",VeryHard.OverTime(new [] { 9, 17, 30, 1.5 }));
        ClassicAssert.AreEqual("$400.00",VeryHard.OverTime(new double[] { 9, 18, 40, 2 }));
        ClassicAssert.AreEqual("$325.00",VeryHard.OverTime(new[] { 13, 20, 32.5, 2 }));
        ClassicAssert.AreEqual("$100.00",VeryHard.OverTime(new[] { 9, 13, 25, 1.5 }));
        ClassicAssert.AreEqual("$364.00",VeryHard.OverTime(new[] { 11.30, 19, 40, 1.8 }));
        ClassicAssert.AreEqual("$210.00",VeryHard.OverTime(new[] { 10, 17, 30, 1.5 }));
        ClassicAssert.AreEqual("$209.63",VeryHard.OverTime(new[] { 10.30, 17, 32.25, 1.5 }));
        ClassicAssert.AreEqual("$84.00", VeryHard.OverTime(new[] { 16, 18, 30, 1.8 }));
        ClassicAssert.AreEqual("$130.00",VeryHard.OverTime([18, 20, 32.5, 2]));
        ClassicAssert.AreEqual("$47.50", VeryHard.OverTime(new[] { 13.25, 15, 30, 1.5 }));
        ClassicAssert.AreEqual("$432.32",VeryHard.OverTime(new[] { 13, 21, 38.6, 1.8 }));
    }
}