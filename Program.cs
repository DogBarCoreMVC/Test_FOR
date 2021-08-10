using System;

namespace Test_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int count = 1, limit = 3; count <= limit; count ++, limit --)
            {
                Console.WriteLine("Count = " + count + " limit = " + limit);
            }
        }
    }
}
