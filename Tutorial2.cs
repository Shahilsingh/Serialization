using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Serialization1
{
    class Tutorial2
    {
        static void Main(string[] args)
        {
            String path = @"G:\ravi.txt";

            String lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);

            Console.ReadKey();
        }
    }
}