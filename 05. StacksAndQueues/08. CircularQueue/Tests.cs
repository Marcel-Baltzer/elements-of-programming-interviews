using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.StacksAndQueues.CircularQueue
{
    public class Tests
    {
        [Fact]
        public void Queue()
        {
            var queue = new Solution.Queue(3);

            queue.Enqueue(5);
            queue.Size().Should().Be(1);
            queue.Dequeue().Should().Be(5);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Size().Should().Be(4);
            queue.Dequeue().Should().Be(1);
            queue.Dequeue().Should().Be(2);
            queue.Dequeue().Should().Be(3);
            queue.Dequeue().Should().Be(4);
            queue.Size().Should().Be(0);
        }
    }
}