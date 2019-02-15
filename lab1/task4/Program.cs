using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());        //переменная и сохранение в него размер массива
            string[,] arr = new string[n, n];             //создание двумерного массива
            for (int i=0; i<n; i++)                       //заполнение массива [*]
            {
                for(int j=0; j<n; j++)
                {
                    arr[i, j] += "[*]";
                }
            }
            for(int i=0; i<n; i++)                    
            {
                for(int j=0; j<n; j++)
                {
                    if (i >= j)                           //заполнение на половину
                        Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
