using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace BinaryTree.Tests;

public class BinaryTreeTests
{
    [Theory]
    [InlineData(new int[] {50, 17, 76, 9, 23, 54, 14, 19, 72, 12, 67}, new int[] {14, 23, 72})]
    [InlineData(new int[] { 50, 17, 76, 9, 23, 54, 80 }, new int[] {})]
    [InlineData(new int[] { 0 }, new int[] {})]
    public void FindSingleParents_ShouldReturnAllSingleParents(int[] inputVals, int[] expected)
    {
        #region Arrange

        var tree = new BinaryTree();

        inputVals.ToList().ForEach(x => tree.Add(x));

        #endregion

        #region Act

        List<int> actual = new List<int>();
        var singleParents = tree.FindSingleParents();
        singleParents.ForEach(n => actual.Add(n.Data));

        var result = Enumerable.SequenceEqual(actual, expected.ToList());

        #endregion

        #region Assert

        Assert.True(result);

        #endregion
    }
}