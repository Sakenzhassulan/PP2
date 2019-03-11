using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student    // Создаем класс
    {
        public string name;
        public string id;     // переменные класса
        public int yearofstudy;

        public Student(string name, string id) //конструктор с 2 параметрами
        {

            this.name = name;
            this.id = id;
            PrintInfo();   // Вызвал метод, Можно вызвать метод в конструктуре
        }                // чтобы было меньше кода
         public void PrintInfo()
        {
            Console.WriteLine("Name of student: "+name); // Метод который выводит данные студента
            Console.WriteLine("ID of tudent: "+id);
        }
        public int Nextyear(int y) // метод который изменяет курс обучения студента
        {
           return y + 1;
            //yearofstudy = y;
            //return yearofstudy + 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Write ID: ");          //Вывод данных студента
            string id = Console.ReadLine();
            Console.WriteLine("Write year of study: ");
            string num = Console.ReadLine();
            int yearofstudy = int.Parse(num);
            Student student = new Student(name,id); // конструктор
            Console.WriteLine("Next Year of study: "+student.Nextyear(yearofstudy));
        }
    }
}
