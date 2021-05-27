using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._05._StacksAndQueues._01._StackApi
{
    public class Tests
    {
        [Fact]
        public void ElementWithCachedMax()
        {
            var stack = new Solution.StackWithCachedMax();

            stack.Push(2);
            stack.Push(4);
            stack.Push(2);
            stack.Pop();
            stack.Push(8);
            stack.Push(4);
            stack.Push(10);
            stack.Pop();

            var result = stack.Max();

            result.Should().Be(8);
        }

        [Fact]
        public void MaxWithCount()
        {
            var stack = new Solution.StackWithCachedMaxCount();

            stack.Push(2);
            stack.Push(4);
            stack.Push(2);
            stack.Pop();
            stack.Push(8);
            stack.Push(4);
            stack.Push(10);
            stack.Pop();

            var result = stack.Max();

            result.Should().Be(8);
        }
    }
}