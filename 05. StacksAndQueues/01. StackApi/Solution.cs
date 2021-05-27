using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._05._StacksAndQueues._01._StackApi
{
    public class Solution
    {
        private class ElementWithCachedMax
        {
            public ElementWithCachedMax(int element, int max)
            {
                this.Element = element;
                this.Max = max;

            }
            public int Element { get; }
            public int Max { get; }
        }

        public class StackWithCachedMax
        {
            // Stores (element , cached maximum) pair.
            private readonly Stack<ElementWithCachedMax> elementWithCachedMax = new();

            public bool IsEmpty()
            {
                return elementWithCachedMax.Count == 0;
            }

            public int Max()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("max(): empty stack");
                }

                return elementWithCachedMax.Peek().Max;
            }

            public int Pop()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("pop(): empty stack");
                }

                return elementWithCachedMax.Pop().Element;
            }

            public void Push(int x)
            {
                elementWithCachedMax.Push(new ElementWithCachedMax(x, Math.Max(x, IsEmpty() ? x : Max())));
            }
        }

        // Improved Version.

        private class MaxWithCount
        {
            public MaxWithCount(int max, int count)
            {
                this.Max = max;
                this.Count = count;
            }

            public int Max { get; }

            public int Count { get; set; }
        }

        public class StackWithCachedMaxCount
        {
            private readonly Stack<int> element = new();
            private readonly Stack<MaxWithCount> cachedMaxWithCount = new();

            public bool IsEmpty()
            {
                return element.Count == 0;
            }

            public int Max()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("max(): empty stack");
                }

                return cachedMaxWithCount.Peek().Max;
            }

            public int Pop()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("pop(): empty stack");
                }

                var popElement = element.Pop();

                if (popElement.Equals(cachedMaxWithCount.Peek().Max))
                {
                    cachedMaxWithCount.Peek().Count -= 1;

                    if (cachedMaxWithCount.Peek().Count.Equals(0))
                    {
                        cachedMaxWithCount.Pop();
                    }
                }

                return popElement;
            }

            public void Push(int x)
            {
                element.Push(x);

                if (cachedMaxWithCount.Count > 0)
                {
                    if (x.CompareTo(cachedMaxWithCount.Peek().Max) == 0)
                    {
                        cachedMaxWithCount.Peek().Count += 1;
                    }
                    else if (x.CompareTo(cachedMaxWithCount.Peek().Max) > 0)
                    {
                        cachedMaxWithCount.Push(new MaxWithCount(x, 1));
                    }
                }
                else
                {
                    cachedMaxWithCount.Push(new MaxWithCount(x, 1));
                }
            }

            // Used by Solution 10. Queue-API
            public int Count()
            {
                return element.Count;
            }
        }
    }
}