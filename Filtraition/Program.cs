using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Filtraition
{
    internal class Program
    {
        static public void Filter( int[] original, int[] forfilter)
        {
            int[] filtered = new int[original.Length - forfilter.Length];
            bool flag;
            int tmp = 0;
            Sort(original, original.Length);
            Sort(forfilter, forfilter.Length);
            for (int i = 0; i < original.Length; i++)
            {
                flag = false;
                for (int j = 0; j < forfilter.Length; j++)
                {
                    if (original[i] == forfilter[j])
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    filtered[tmp] = original[i];
                    tmp++;
                }
            }
            WriteLine("Результат: ");
            for(int i = 0; i < filtered.Length; i++)
            {
                Write(filtered[i] + " ");
            }
            Write("\n");
        }
        static void Sort(int[] arrN, int sizeN)
        {
            int tmp = 0;
            for (int i = 0; i < sizeN; ++i)
            {
                for (int j = i + 1; j < sizeN; ++j)
                {
                    if (arrN[j] < arrN[i])
                    {
                        tmp = arrN[j];
                        arrN[j] = arrN[i];
                        arrN[i] = tmp;
                    }
                }
            }
        }
        static void Print(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Write(arr[i] + " ");
            }
            Write("\n");
        }
        static void Main(string[] args)
        {
            WriteLine("Введите количество элементов для первого массива: ");
            int Elements = int.Parse(Console.ReadLine());
            int[] original = new int[Elements];
            for (int i = 0; i < original.Length; i++)
            {
                WriteLine($"Введите элемент массива под индексом {i}\t");
                original[i] = Convert.ToInt32(Console.ReadLine());
            }
            WriteLine("Введите количество элементов для второго массива: ");
            int Elements2 = int.Parse(Console.ReadLine());
            int[] forFilter = new int[Elements2];
            for (int i = 0; i < forFilter.Length; i++)
            {
                WriteLine($"Введите элемент массива под индексом {i}\t");
                forFilter[i] = Convert.ToInt32(Console.ReadLine());
            }
            WriteLine("Оригинальный массив: ");
            Print(original);
            WriteLine("Массив для фильтрации: ");
            Print(forFilter);
            Filter(original, forFilter);
        }
    }
}
