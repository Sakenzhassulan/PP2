using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task2
{
    class Program
    {
        class Mythread
        {
            Thread threadfield;
            public Mythread(string name)
            {
                threadfield = new Thread(func);
                threadfield.Name = name;
                threadfield.Start();
            }
            //void func()
            //{
            //    for (int i = 1; i <= 4; i++)
            //    {
            //        Console.WriteLine(Thread.CurrentThread.Name + " " + i);
            //        //Thread.Sleep(0); 
            //    }
            //    Console.WriteLine(Thread.CurrentThread.Name + " завершился");
            //}
        }
        static void Main(string[] args)
        {
            Mythread t1 = new Mythread("Thread 1");
            Mythread t2 = new Mythread("Thread 2");
            Mythread t3 = new Mythread("Thread 3");
            Mythread t4 = new Mythread("Thread 4");
            
        }
        static void func()
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + i);
                //Thread.Sleep(0); 
            }
            Console.WriteLine(Thread.CurrentThread.Name + " завершился");
        }
    }
}
