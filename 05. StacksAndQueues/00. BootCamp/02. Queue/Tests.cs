using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._05._StacksAndQueues._00._BootCamp._02._Queue
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