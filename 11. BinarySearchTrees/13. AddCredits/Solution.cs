using System.Collections.Generic;
using System.Linq;

namespace Elements_of_Programming_Interviews._11._BinarySearchTrees._13._AddCredits
{
    public class Solution
    {
        public class ClientsCreditsInfo
        {
            private int offset;
            private readonly Dictionary<string, int> clientToCredit = new();
            private readonly SortedDictionary<int, HashSet<string>> creditToClients = new();

            public void Insert(string clientId, int c)
            {
                Remove(clientId);
                clientToCredit.Add(clientId, c - offset);

                var set = new HashSet<string>();
                
                if (creditToClients.ContainsKey(c - offset))
                {
                    set = creditToClients[c - offset];
                }
                else
                {
                    creditToClients.Add(c-offset, set);
                }
                
                set.Add(clientId);
            }

            public bool Remove(string clientId)
            {
                if (!clientToCredit.ContainsKey(clientId))
                {
                    return false;
                }
                
                var clientCredit = clientToCredit[clientId];
                creditToClients[clientCredit].Remove(clientId);

                if (!creditToClients[clientCredit].Any())
                {
                    creditToClients.Remove(clientCredit);
                }

                clientToCredit.Remove(clientId);
                return true;
            }

            public int Lookup(string clientId)
            {
                if (!clientToCredit.ContainsKey(clientId))
                {
                    return -1;
                }
                
                var clientCredit = clientToCredit[clientId];
                return clientCredit + offset;
            }

            public void AddAll(int c)
            {
                offset += c;
            }

            public string Max()
            {
                if (!creditToClients.Any())
                {
                    return "";
                }

                using var credit = creditToClients.Last().Value.GetEnumerator();
                credit.MoveNext();

                return credit.Current;
            }
        }
    }
}