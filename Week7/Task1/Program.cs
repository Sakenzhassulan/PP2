using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadForConsoleInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] srr = new string[4];
            srr[0] = "Zhassik";
            srr[1] = "Zhassulan";
            srr[2] = "Zhass";
            Thread[] arr = new Thread[3];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Thread(func);
                arr[i].Name = srr[i];
                arr[i].Start();
            }
        }
        static void func()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
                //Thread.Sleep(0);
            }
            //Console.WriteLine(Thread.CurrentThread.Name + " завершился"); 
        }
    }
}