using System;
using System.Linq;

namespace Elements_of_Programming_Interviews.StacksAndQueues.CircularQueue
{
    public class Solution
    {
        public class Queue
        {
            private int head = 0;
            private int tail = 0;
            private int numQueueElements = 0;
            private int ScaleFactor = 2;
            private int[] entries;

            public Queue(int capacity)
            {
                entries = new int[capacity];
            }

            public void Enqueue(int x)
            {
                if (numQueueElements == entries.Length) // Need to resize.
                {
                    // Makes the queue elements appear consecutively.
                    entries = entries.Skip(head).Concat(entries.Take(head)).ToArray();
                    // Resets head and tail.
                    head = 0;
                    tail = numQueueElements;
                    Array.Resize(ref entries, numQueueElements * ScaleFactor);
                }

                entries[tail] = x;
                tail = (tail + 1) % entries.Length;
                numQueueElements++;
            }

            public int Dequeue()
            {
                if (numQueueElements != 0)
                {
                    numQueueElements--;
                    int ret = entries[head];
                    head = (head + 1) % entries.Length;

                    return ret;
                }

                throw new InvalidOperationException("Dequeue called on an empty queue.");
            }

            public int Size()
            {
                return numQueueElements;
            }
        }
    }
}