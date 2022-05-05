using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinkedListReverse.Tests;

public class LinkedListReversalTests
{
    [Fact]
    public void Reverse_Linearly_ShouldReturnReversedList()
    {
        #region Arrange

        var linkedListReversal = new LinkedListReversal<string>();

        var testLinkedList = new LinkedList<string>();

        testLinkedList.AddLast("First");
        testLinkedList.AddLast("Second");
        testLinkedList.AddLast("Third");
        testLinkedList.AddLast("Fourth");
        testLinkedList.AddLast("Fifth");

        #endregion

        #region Act

        var expected = testLinkedList.Reverse().ToList();

        linkedListReversal.ReverseLinearly(testLinkedList);
        var actual = testLinkedList.ToList();
        
        #endregion

        #region Assert

        Assert.Equal(expected, testLinkedList);

        #endregion
    }

    [Fact]
    public void Reverse_Recursively_ShouldReturnReversedList()
    {
        #region Arrange

        var linkedListReversal = new LinkedListReversal<string>();

        var testLinkedList = new LinkedList<string>();

        testLinkedList.AddLast("First");
        testLinkedList.AddLast("Second");
        testLinkedList.AddLast("Third");
        testLinkedList.AddLast("Fourth");
        testLinkedList.AddLast("Fifth");

        #endregion

        #region Act

        var expected = testLinkedList.Reverse().ToList();

        linkedListReversal.ReverseRecursively(testLinkedList);
        var actual = testLinkedList.ToList();
        
        #endregion

        #region Assert

        Assert.Equal(expected, testLinkedList);

        #endregion
    }
}