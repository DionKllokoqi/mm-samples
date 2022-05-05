using Xunit;

namespace StringAnagrams.Tests;

public class StringAnagramTests
{
    [Theory]
    [InlineData("Fourth of July", "joyful Fourth")]
    [InlineData("slot machines", "cash lost in 'em")]
    [InlineData("snooze alarms", "alas, no more Z's")]
    public void AreAnagrams_WithDictionary_ShouldReturnTrue(string testStringOne, string testStringTwo)
    {
        #region Arrange

        var stringAnagrams = new StringAnagrams();

        #endregion

        #region Act

        bool result = stringAnagrams.AreAnagrams(testStringOne, testStringTwo);

        #endregion

        #region Assert

        Assert.True(result);

        #endregion
    }
}