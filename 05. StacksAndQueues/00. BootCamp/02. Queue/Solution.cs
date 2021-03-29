using System.Collections.Generic;
using System.Linq;
using System;

namespace Elements_of_Programming_Interviews.StacksAndQueues.BootCamp.Queue
{
    public class Solution
    {
        public class QueueWithMaxIntro
        {
            private Queue<int> data = new Queue<int>();

            public void Enqueue(int x)
            {
                data.Enqueue(x);
            }

            public int Dequeue()
            {
                return data.Dequeue();
            }

            public int Max()
            {
                if (data.Count > 0)
                {
                    return data.Max();
                }

                throw new InvalidOperationException("Cannot perform Max() on empty queue.");
            }
        }
    }
}