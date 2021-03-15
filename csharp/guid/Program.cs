using System;

namespace guid
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i < 15; i++)
            {
                var uid = Guid.NewGuid().ToString();
                Console.WriteLine($"#{i}. {uid}");
            }
        }
    }
}
