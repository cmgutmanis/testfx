using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFx;

namespace TestFxDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EnhancedRandom.RandomWords(50));
            for (var i = 0; i < 20; i++)
            {
                Console.WriteLine(EnhancedRandom.RandomBool());
            }
            Console.ReadLine();
        }
    }
}
