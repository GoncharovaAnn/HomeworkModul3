using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeworkModul3
{
    internal class Program
    {
        static void Square(int a, string key)
        {
            for(int i = 0; i < a; i++) 
            {
                for(int j = 1; j < a; j++)
                {
                    Write(key + " ");
                }
                WriteLine(key + " ");
            }
        }
        static void Main(string[] args)
        {
            WriteLine("\tПостроение квадрата");
            WriteLine("Введите длинну стороны квадрата: ");
            int a = Convert.ToInt32(Console.ReadLine());
            WriteLine("Введите символ из которого хотите построить квадрат: ");
            string key = Console.ReadLine();
            WriteLine(" ");
            Program.Square(a, key);
        }
    }
}
