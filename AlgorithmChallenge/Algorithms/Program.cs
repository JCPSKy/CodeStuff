using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] gadgets = { "Brella", "Copter", "Binoculaurs", "Springs", "Cuffs", "Hands", "Legs", "Arms", "Neck", "Phone", "Skates", "Coat" };
            var numbers = new int[1000000];
            Random rnd = new Random();
            for (int i = 0; i < 1000000; i++)
            {
                numbers[i] = rnd.Next(-1000000,1000000);
            }
        }
    }
}
