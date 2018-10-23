using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Serialization1
{
    class Tutorial3
    {
        static void Main(string[] args)
        {
            String path = @"G:\ravi.txt";

            String copypath = @"G:\raviNew.txt";

            File.Copy(path, copypath);

            Console.ReadKey();
        }
    }
}