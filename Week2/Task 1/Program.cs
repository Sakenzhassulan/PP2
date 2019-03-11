using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    class Program
    {
        public static bool ItIsPalindrom(string d)
        {
            bool b = true;
            for (int k = 0; k < d.Length / 2; k++)
            {
                if (d[k] != d[d.Length - 1 - k])
                    b = false; 
            }
            return b;
        }
        static void Main(string[] args)
        {  
            FileStream a = new FileStream(@"D:\c#\Test\Test 1\1.txt", FileMode.Open, FileAccess.Read);
            StreamReader r = new StreamReader(a);
            string s = r.ReadLine();
            a.Close();
            r.Close();
            if (ItIsPalindrom(s)) // Вызвал функцию, проверят строку полиндром или нет
                Console.WriteLine("Yes");
            else                               // Вывод ответа
                Console.WriteLine("No");
        }
    }
}
