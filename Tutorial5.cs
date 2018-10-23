using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
namespace Serialization1
{ 
    [Serializable]
     
   public class Tutorial5
    {
        public int ID;
        public string Name;
        static void Main(string[] args)
        {
            Tutorial5 obj = new Tutorial5();
            obj.ID = 1;
            obj.Name = ".Net";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"G:\AshuNew.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, obj);
            stream.Close();

            stream = new FileStream(@"G:\AshuNew.txt", FileMode.Open, FileAccess.Read);
            Tutorial5 objnew = (Tutorial5)formatter.Deserialize(stream);

            Console.WriteLine(objnew.ID);
            Console.WriteLine(objnew.Name);

            Console.ReadKey();
         }
      }
   }

    

