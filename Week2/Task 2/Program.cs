using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task_2
{
    class Program
    {
        public static int[] F(string ss)
        {
            string[] str = ss.Split();
            int[] b = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                b[i] = int.Parse(str[i]);
            }
            return b;
        }
        public static bool F2(int b)
        {
            if (b == 1)
                return false;
            for (int i = 2; i < b; i++)
            {
                if (b % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            FileStream a = new FileStream(@"D:\c#\Test\Test 1\2.txt", FileMode.Open, FileAccess.Read);
            StreamReader r = new StreamReader(a);
            string s = r.ReadLine();
            int[] arr = F(s); // Вызвал функцию, превращает всех символов на число
            a.Close();
            r.Close();

            FileStream a1 = new FileStream(@"D:\c#\Test\Test 1\3.txt", FileMode.Create, FileAccess.Write);
            StreamWriter w = new StreamWriter(a1);
            foreach (int n in arr)
            {
                if (F2(n)) // Это функция возвращает простве числа
                    w.Write(n + " "); // Вывод ответа
            }
            w.Close();
            a1.Close();
        }
    }
}