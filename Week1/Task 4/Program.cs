using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string ss = Console.ReadLine();
            int n = int.Parse(ss);
            string[,] a = new string[n, n]; // Создал двойной массив
            string s = "[*]";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    a[i, j] = s;
                    Console.Write(a[i, j]); //Вывожу на экран
                }
                Console.WriteLine();
            }
        }
    }
}

