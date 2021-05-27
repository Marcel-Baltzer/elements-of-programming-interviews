using System.Collections.Generic;
using System.Linq;

namespace Elements_of_Programming_Interviews._09._HashTables._03._ISBNCache
{
    public class Solution
    {
        public class LRUCache
        {
            private readonly int capacity;
            private readonly List<int> loc;
            private readonly Dictionary<int, int> isbnToPrice;

            public LRUCache(int capacity)
            {
                this.capacity = capacity;
                loc = new List<int>();
                isbnToPrice = new Dictionary<int, int>();
            }
            
            public int Lookup(int key)
            {
                if (!isbnToPrice.ContainsKey(key))
                {
                    return -1;
                }

                var value = isbnToPrice[key];
                
                loc.Remove(key);
                loc.Add(key);
                
                return value;
            }

            public int? Insert(int key, int value)
            {
                // We add the value for key only if key is not present - we don’t update
                // existing values.
                if (isbnToPrice.ContainsKey(key))
                {
                    loc.Remove(key);
                    loc.Add(key);
                    return -1;
                }
                
                isbnToPrice[key] = value;
                loc.Remove(key);
                loc.Add(key);

                if (capacity < isbnToPrice.Count)
                {
                    var last = loc.First();
                    isbnToPrice.Remove(last);
                    loc.Remove(last);
                }
                
                return value;
            }

            public int Erase(int key)
            {
                if (!isbnToPrice.ContainsKey(key))
                {
                    return -1;
                }
                
                var value = isbnToPrice[key];
                isbnToPrice.Remove(key);
                loc.Remove(key);

                return value;
            }
        }
    }
}