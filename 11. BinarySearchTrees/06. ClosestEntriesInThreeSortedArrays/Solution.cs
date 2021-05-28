using System;
using System.Collections.Generic;
using System.Linq;

namespace Elements_of_Programming_Interviews._11._BinarySearchTrees._06._ClosestEntriesInThreeSortedArrays
{
    public class Solution
    {
        private class ArrayData : IComparable
        {
            public readonly int Index;
            public readonly int Value;

            public ArrayData(int index, int value)
            {
                Index = index;
                Value = value;
            }

            public int CompareTo(object obj)
            {
                if (obj is not ArrayData that)
                {
                    return -1;
                }

                var result = Value.CompareTo(that.Value);

                if (result == 0)
                {
                    result = Index.CompareTo(that.Index);
                }

                return result;
            }

            public override bool Equals(object obj)
            {
                if (obj is not ArrayData that)
                {
                    return false;
                }

                if (this == obj)
                {
                    return true;
                }

                return Value == that.Value && Index == that.Index;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Value, Index);
            }
        }

        public static int FindMinDistanceSortedArrays(List<List<int>> sortedArrays)
        {
            var heads = sortedArrays.Select(_ => 0).ToList();

            var result = int.MaxValue;

            var currentHeads = new SortedSet<ArrayData>();
            
            // Adds the minimum element of each array in to currentHeads.
            for (var i = 0; i < sortedArrays.Count; i++)
            {
                currentHeads.Add(new ArrayData(i, sortedArrays[i][heads[i]]));
            }

            while (true)
            {
                result = Math.Min(result, currentHeads.Last().Value - currentHeads.First().Value);
                var idxNextMin = currentHeads.First().Index;
                
                // Return if some array has no remaining elements.
                heads[idxNextMin] = heads[idxNextMin] + 1;
                if (heads[idxNextMin] >= sortedArrays[idxNextMin].Count)
                {
                    return result;
                }

                currentHeads.Remove(currentHeads.First());
                currentHeads.Add(new ArrayData(idxNextMin, sortedArrays[idxNextMin][heads[idxNextMin]]));
            }
        }
    }
}