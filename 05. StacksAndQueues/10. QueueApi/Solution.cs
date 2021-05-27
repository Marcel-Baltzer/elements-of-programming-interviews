using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._05._StacksAndQueues._10._QueueApi
{
    public class Solution
    {
        public class QueueWithMax<T> where T : IComparable<T>
        {
            private Queue<T> entries = new Queue<T>();
            private LinkedList<T> candidatesForMax = new LinkedList<T>();

            public void Enqueue(T x)
            {
                entries.Enqueue(x);

                while (candidatesForMax.Count > 0)
                {
                    // Eliminate dominated elements in candidatesForMax.
                    if (candidatesForMax.Last.Value.CompareTo(x) >= 0)
                    {
                        break;
                    }
                    candidatesForMax.RemoveLast();
                }

                candidatesForMax.AddLast(x);
            }

            public T Dequeue()
            {
                if (entries.Count > 0)
                {
                    T result = entries.Dequeue();

                    if (result.Equals(candidatesForMax.First.Value))
                    {
                        candidatesForMax.RemoveFirst();
                    }

                    return result;
                }
                throw new InvalidOperationException("Cannot get Dequeue() on empty queue.");

            }

            public T Max()
            {
                if (candidatesForMax.Count > 0)
                {
                    return candidatesForMax.First.Value;
                }
                throw new InvalidOperationException("Cannot get Max() on empty queue.");
            }
        }

        public class QueueWithStacksAndMax
        {
            private _01._StackApi.Solution.StackWithCachedMaxCount enqueue = new _01._StackApi.Solution.StackWithCachedMaxCount();
            private _01._StackApi.Solution.StackWithCachedMaxCount dequeue = new _01._StackApi.Solution.StackWithCachedMaxCount();

            public void Enqueue(int x)
            {
                enqueue.Push(x);
            }

            public int Dequeue()
            {
                if (dequeue.Count() == 0)
                {
                    while (enqueue.Count() > 0)
                    {
                        dequeue.Push(enqueue.Pop());
                    }
                }

                if (dequeue.Count() > 0)
                {
                    return dequeue.Pop();
                }

                throw new InvalidOperationException("Cannot get Dequeue() on empty queue.");
            }

            public int Max()
            {
                if (enqueue.Count() > 0)
                {
                    return dequeue.Count() == 0 ? enqueue.Max()
                                                : Math.Max(enqueue.Max(), dequeue.Max());
                }

                if (dequeue.Count() > 0)
                {
                    return dequeue.Max();
                }

                throw new InvalidOperationException("Cannot get Max() on empty queue.");
            }
        }
    }
}