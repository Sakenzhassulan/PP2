using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace task2
{   
    public class Mark
    {
        public int Points;
        public Mark() {}
        public string GetLetter()
        {
            if (Points < 100 && Points >= 90 )
                return "A";
            else if (75 <= Points && Points < 90 )
                return "B";
            else if (60 <= Points && Points < 75)
                return "C";
            else if (50 <= Points && Points < 60 )
                return "D";
            else return "F";
        }
        public void PrintInfo()
        {
            {
                Console.WriteLine(Points.ToString() + " is " + GetLetter());
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            
            //F1();
            F2();
            
        }
        private static void F2()
        {
            FileStream fs = new FileStream("mark.txt", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));
            List<Mark> t = xs.Deserialize(fs) as List<Mark>;
            //Mark t = (Mark)xs.Deserialize(fs);
            fs.Close();
            foreach (Mark p in t)
            {
                p.PrintInfo();
            }
        }
        public static void F1()
        {
            Mark one = new Mark();
            Mark two = new Mark();
            Mark three = new Mark();
            one.Points = 95;
            one.GetLetter();
            two.Points = 77;
            two.GetLetter();
            three.Points = 45;
            three.GetLetter();
            List<Mark> a = new List<Mark>()
            {
               one,two,three
            };
            XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));
            FileStream fs = new FileStream("mark.txt", FileMode.Create, FileAccess.Write);
            xs.Serialize(fs,a);
            fs.Close();

        }
    }

}