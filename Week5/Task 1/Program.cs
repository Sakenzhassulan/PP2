using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Task_1

{   [Serializable]
    public class Complex
    {
        public int a;
        public int b;
        public void PrintInfo()
        {
            Console.WriteLine(a + " + " + b + "*i");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            //F1();
            F2();
        }
        private static void F1()
        {
            Complex c = new Complex();
            c.a = 2;
            c.b = 3;

            FileStream fs = new FileStream(@"Com.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf= new BinaryFormatter();
            bf.Serialize(fs, c);
            fs.Close();
        }
        private static void F2()
        {
            FileStream fs = new FileStream(@"com.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter(); 
            Complex t = bf.Deserialize(fs) as Complex;
            fs.Close();
            t.PrintInfo();
        }
    }
}
