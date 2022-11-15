using System;
using System.Linq;

namespace SockPairs
{
    class Primary
    {
        public static void Main()
        {
            Working work = new Working();
            
            Console.WriteLine(work.SockSorter("AA"));
            Console.WriteLine(work.SockSorter("ABABC"));
            Console.WriteLine(work.SockSorter("CABBACCC"));
            Console.WriteLine(work.SockSorter(""));
        }
    }
}
