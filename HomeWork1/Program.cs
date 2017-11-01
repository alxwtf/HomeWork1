using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Cars = new List<Cars>
            {
                new Car1(),
                new Car2(),
                new Car3()
            };
            foreach (var Car in Cars) ;
        }
    }
}
