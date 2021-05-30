using Elements_of_Programming_Interviews.Types;

namespace Elements_of_Programming_Interviews._11._BinarySearchTrees._11._TotallyOrdered
{
    public class Solution
    {
        public static bool PairIncludesAncestorAndDescendant0Fm(BinarySearchTreeNode<int> possibleAncOrDesc0,
            BinarySearchTreeNode<int> possibleAncOrDesc1, BinarySearchTreeNode<int> middle)
        {
            var search0 = possibleAncOrDesc0;
            var search1 = possibleAncOrDesc1;

            // Perform interleaved searching from possibleAncOrDesc0 and
            // possibleAncOrDesc1 for middle.
            while (search0 != possibleAncOrDesc1 && search0 != middle
                && search1 != possibleAncOrDesc0 && search1 != middle
                &&(search0 != null || search1 != null))
            {
                if (search0 != null)
                {
                    search0 = search0.Data > middle.Data ? search0.Left : search0.Right;
                }

                if (search1 != null)
                {
                    search1 = search1.Data > middle.Data ? search1.Left : search1.Right;
                }
            }
            
            // If both searches were unsuccessful , or we got from possibleAncOrDesc1
            // to possibleAncOrDesc1 without seeing middle, or from possibleAncOrDesc1
            // to possibleAncOrDesc0 without seeing middle, middle cannot lie between
            // possibleAncOrDesc® and possibleAncOrDesc1.
            if (search0 == possibleAncOrDesc1 || search1 == possibleAncOrDesc0
                                              || (search0 != middle && search1 != middle))
            {
                return false;
            }
            
            if (possibleAncOrDesc0 == middle || possibleAncOrDesc1 == middle)
            {
                return false;
            }
            
            // If we get here, we already know one of possibleAncOrDesc0 or
            // possibleAncOrDesc1 has a path to middle. Check if middle has a path to
            // possibleAncOrDesc1 or to possibleAncOrDesc0.

            return search0 == middle
                ? SearchTarget(middle, possibleAncOrDesc1)
                : SearchTarget(middle, possibleAncOrDesc0);
        }

        private static bool SearchTarget(BinarySearchTreeNode<int> from, BinarySearchTreeNode<int> target)
        {
            while (from != null && from != target)
            {
                from = from.Data > target.Data ? from.Left : from.Right;
            }

            return from == target;
        }
    }
}