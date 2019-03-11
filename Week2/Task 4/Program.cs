using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream f = new FileStream(@"D:\c#\Test\Test 1\4.txt", FileMode.Create)) { }// Создал файл
                File.Copy(@"D:\c#\Test\Test 1\4.txt", @"D:\c#\Test\Test 2\4.txt", true); // копирую на другую папку
                File.Delete(@"D:\c#\Test\Test 1\4.txt"); // Удаляю оригинал
        } 
    }
}
