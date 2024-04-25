using EdabitChallenges;

using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Tests;

public class ExpertTests
{

    [Fact]
    public void TranslateWord()
    {
        Assert.Equal("avehay", Expert.TranslateWord("have"));
        Assert.Equal("amcray", Expert.TranslateWord("cram"));
        Assert.Equal("aketay", Expert.TranslateWord("take"));
        Assert.Equal("Atcay", Expert.TranslateWord("Cat"));
        Assert.Equal("Impshray", Expert.TranslateWord("Shrimp"));
        Assert.Equal("ebuchettray", Expert.TranslateWord("trebuchet"));
        Assert.Equal("ateyay", Expert.TranslateWord("ate"));
        Assert.Equal("Appleyay", Expert.TranslateWord("Apple"));
        Assert.Equal("oakenyay", Expert.TranslateWord("oaken"));
        Assert.Equal("eagleyay", Expert.TranslateWord("eagle"));
        Assert.Equal("inkyay", Expert.TranslateWord("ink"));
        Assert.Equal("unicornyay", Expert.TranslateWord("unicorn"));
        Assert.Equal("", Expert.TranslateWord(""));
    }
}