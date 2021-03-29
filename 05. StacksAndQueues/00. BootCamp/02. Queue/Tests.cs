using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.StacksAndQueues.BootCamp.Queue
{
    public class Tests
    {
        [Fact]
        public void QueueWithMaxIntro()
        {
            var queue = new Solution.QueueWithMaxIntro();

            queue.Enqueue(5);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();

            queue.Max().Should().Be(3);
        }
    }
}