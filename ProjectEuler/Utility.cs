using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    public class Utility
    {
        public void WriteEnumerable<T>(IEnumerable<T> enumerable)
        {
            foreach (var item in enumerable)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}