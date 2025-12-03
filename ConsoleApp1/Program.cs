using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> {1, 5, 7, 2, 1, 10};

            var even = numbers.Where(x => x % 2 == 0);

            foreach (var e in even)
            {
                Console.WriteLine(e);
            }
        }
        //helppp me
    }
}
