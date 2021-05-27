using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._05._StacksAndQueues._09._QueueUsingStacks
{
    public class Solution
    {
        public class QueueWithStacks
        {
            private readonly Stack<int> enqueue = new();
            private readonly Stack<int> dequeue = new();

            public void Enqueue(int x)
            {
                enqueue.Push(x);
            }

            public int Dequeue()
            {
                if (dequeue.Count == 0)
                {
                    // Transfers the elements from enq to deq.
                    while (enqueue.Count > 0)
                    {
                        dequeue.Push(enqueue.Pop());
                    }
                }

                if (dequeue.Count > 0)
                {
                    return dequeue.Pop();
                }

                throw new InvalidOperationException("Cannot dequeue empty queue");
            }
        }
    }
}