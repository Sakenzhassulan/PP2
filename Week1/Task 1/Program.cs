using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        public static bool Prime(int b)
        {
            if (b == 1)
                return false;
            for (int i = 2; i < b; i++)
            {
                if (b % i == 0) return false;
            }
            return true;
        } /*#4 А тут я проверил является ли число простым или нет
         тут я написал bool потому что когда  if оно принимает либо True либо False */
        static void Main(string[] args)
        {
            string d = Console.ReadLine();
            int n = int.Parse(d);
            int[] a = new int[n];
            string ss = Console.ReadLine();
            string[] s = ss.Split(' ');
            //int[] a = new int[n];
            /* #1 Сперва я вожу символ потом превращаю его на цифру
           используя int.Parse(), и вожу элементы массива через пробел 
           для этого я использовал .Split()*/
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]);
                //int b = Convert.ToInt32(Console.ReadLine()); 
            }
            /* #2 Тут я открыл цикл,я превращаю массив элементов string 
             * на цифру и эти цифры являются элементами массива*/
            for (int i = 0; i < n; i++)
            {
                if (Prime(a[i])) // #3 Здесь я вызвал функцию Prime()
                {
                    cnt++; // #5 Здесь у меня счетчик, так я могу узнать сколько здесь простых чисел
                }
            }
            Console.WriteLine(cnt); // #6 Этот номер показывает сколько тут простых чисел и я вывожу его на экран
            for (int i = 0; i < n; i++)
            {
                if (Prime(a[i]))
                {
                    Console.Write(a[i] + " "); //#7  А тут я вывожу простые числа на командную строку
                }
            }
        }
    }
}
