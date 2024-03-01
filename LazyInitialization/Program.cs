using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyInitialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataCache cache = new DataCache();
            Console.WriteLine(cache.p1);
            Console.WriteLine(nameof(cache.p1));
        }
    }
}
