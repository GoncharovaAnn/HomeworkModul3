using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeworkModul3
{
    internal class Program
    {
        static bool Palindrome(string num)
        {
            int length = num.Length;
            for(int i = 0; i < (length/2); i++) 
            { 
                if(num[i] != num[length - i - 1])
                {
                    WriteLine("число не является палиндромом");
                    return false;
                }
            }
            WriteLine("Число/слово является палиндромом");
            return true;
        }
        static void Main(string[] args)
        {
            WriteLine("\tПроверка на палиндром");
            WriteLine("Введите число или слово, которое хотите проверить на палиндромность");
            string num = Console.ReadLine();
            Program.Palindrome(num);
        }
    }
}
