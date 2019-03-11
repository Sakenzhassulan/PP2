using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Home\source\repos\Week 1"); // Инфо папки
            PrintInfo(dir, 0); //функция которая выводит все папки и файлы который содержит Repos в лестничном порядке

        }
        static void PrintInfo(FileSystemInfo fsi, int k)
        {
            string s = new string(' ', k); // Стринг состоящий из к пробелов
            Console.WriteLine(s + fsi.Name);

            if (fsi.GetType() == typeof(DirectoryInfo))
            {
                FileSystemInfo[] arr = ((DirectoryInfo)fsi).GetFileSystemInfos();
                for (int i = 0; i < arr.Length; i++)
                {
                    PrintInfo(arr[i], k + 3);  //это метод вызывает сам себя с другими параметрами
                }
            }
        }
    }
}
