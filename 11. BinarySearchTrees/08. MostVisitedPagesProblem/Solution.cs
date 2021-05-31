using System;
using System.Collections.Generic;
using System.Linq;

namespace Elements_of_Programming_Interviews._11._BinarySearchTrees._08._MostVisitedPagesProblem
{
    public class Solution
    {
        public class PageVisitCount : IComparable
        {
            private readonly string page;
            public int VisitCount;

            public PageVisitCount(string page, int visitCount)
            {
                this.page = page;
                VisitCount = visitCount;
            }

            public int CompareTo(object obj)
            {
                if (obj is not PageVisitCount that)
                {
                    return -1;
                }
                
                var cmp = VisitCount.CompareTo(that.VisitCount);

                if (cmp == 0)
                {
                    return string.Compare(page, that.page, StringComparison.Ordinal);
                }

                return cmp == 1 ? -1 : 1;
            }
        }
        
        public class MostVisitedPage
        {
            private readonly SortedSet<PageVisitCount> sortedDict = new();
            private readonly Dictionary<string, PageVisitCount> dict = new();

            public void ReadLines(List<string> lines)
            {
                foreach (var line in lines)
                {
                    if (dict.ContainsKey(line))
                    {
                        var pageCount = dict[line];
                        sortedDict.Remove(pageCount);
                        pageCount.VisitCount += 1;
                        sortedDict.Add(pageCount);
                    }
                    else
                    {
                        var pageCount = new PageVisitCount(line, 1);
                        dict.Add(line, pageCount);
                        sortedDict.Add(pageCount);
                    }
                }
            }

            public List<PageVisitCount> GetKMostVisitedPages(int k)
            {
                return sortedDict.Take(k).ToList();
            }
        }
    }
}