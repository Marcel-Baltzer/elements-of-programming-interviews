using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._05._StacksAndQueues._09._QueueUsingStacks
{
    public class Tests
    {
        [Fact]
        public void QueueWithStacks()
        {
            var queue = new Solution.QueueWithStacks();

            queue.Enqueue(5);
            queue.Enqueue(3);
            queue.Dequeue().Should().Be(5);
            queue.Enqueue(6);
            queue.Enqueue(4);
            queue.Dequeue().Should().Be(3);
            queue.Dequeue().Should().Be(6);
        }
    }
}