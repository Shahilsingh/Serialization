using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Serialization1
{
    [Serializable]
    class Student1
    {
        public int rollno;
        public string name;
        public Student1(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }
    public class Deserialize1Example
    {
        public static void Main(string[] args)
        {
            FileStream stream = new FileStream("G:\\Rahul.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Student1 s = (Student1)formatter.Deserialize(stream);
            Console.WriteLine("Rollno: " + s.rollno);
            Console.WriteLine("Name: " + s.name);

            stream.Close();
        }
    }
}

