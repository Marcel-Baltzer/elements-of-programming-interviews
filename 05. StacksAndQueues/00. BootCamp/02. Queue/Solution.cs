using System;
using System.Collections.Generic;
using System.Linq;

namespace Elements_of_Programming_Interviews._05._StacksAndQueues._00._BootCamp._02._Queue
{
    public class Solution
    {
        public class QueueWithMaxIntro
        {
            private readonly Queue<int> data = new();

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