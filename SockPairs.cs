using System;
using System.Linq;

namespace SockPairs
{
    class Working
    {
        public int SockSorter(string socks)
        {

            IDictionary<char, int> totalSocks = new Dictionary<char, int>();

            for (int i = 0; i < socks.Length; i++)
            {

                if (!totalSocks.Keys.Contains(socks[i]))
                {
                    totalSocks.Add(socks[i], socks.Count(s => s == socks[i]));
                }
                
            }

            return totalSocks.Values.Where(s => s % 2 == 0).Sum() / 2;

        }
    }
}