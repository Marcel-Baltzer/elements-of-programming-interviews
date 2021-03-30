using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.StacksAndQueues.QueueApi
{
    public class Tests
    {
        [Fact]
        public void QueueWithMax()
        {
            var queue = new Solution.QueueWithMax<int>();

            queue.Enqueue(5);
            queue.Enqueue(3);
            queue.Max().Should().Be(5);
            queue.Dequeue().Should().Be(5);
            queue.Enqueue(6);
            queue.Max().Should().Be(6);
            queue.Enqueue(4);
            queue.Dequeue().Should().Be(3);
            queue.Dequeue().Should().Be(6);
            queue.Max().Should().Be(4);
        }

        [Fact]
        public void QueueWithStacksAndMax()
        {
            var queue = new Solution.QueueWithStacksAndMax();

            queue.Enqueue(5);
            queue.Enqueue(3);
            queue.Max().Should().Be(5);
            queue.Dequeue().Should().Be(5);
            queue.Enqueue(6);
            queue.Max().Should().Be(6);
            queue.Enqueue(4);
            queue.Dequeue().Should().Be(3);
            queue.Dequeue().Should().Be(6);
            queue.Max().Should().Be(4);
        }
    }
}