using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    class Program
    {
        static void Main(string[] args)
        {
            var intSample = new Calculator<int>();
            var x = intSample.Add(1, 5);
            
        }
    }
}
