using System;
using System.IO;
namespace Serialization1
{
    class Tutorial
    {
        static void Main(string[] args)
        {
            String path = @"G:\Ravi.txt";

            if (File.Exists(path))
            {
                Console.WriteLine("Shahil");
            }
            Console.ReadLine();
        }
    }
}
