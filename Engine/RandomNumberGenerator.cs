using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class RandomNumberGenerator
    {
        private static Random mason = new Random();

        public static int NumberBetween(int minimumValue, int maximumValue)
        {
            return mason.Next(minimumValue, maximumValue + 1);
        }
    }
}
