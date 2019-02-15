using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());          //переменная, и сохраняем в него кол-во чисел которых вводим
            string[] arr = Console.ReadLine().Split();      //массив строк, считаем числы иразделяем их как отделбный элемент
            int[] a = new int[n * 2];                      // увеличиваем размер массива в два раза
            int k = 0;                                     // нужна чтобы пользоваться ею при заполнении чиселв массив
            for (int i=0; i<n; i++)
            {
                for(int j=0; j<2; j++)                         
                {
                    a[k] = int.Parse(arr[i]);               //заполнение массива с повторяющимися цифрами
                    k++;
                }
            }
            for(int i=0; i<n*2; i++)
            {
                Console.Write(a[i] + " ");                 //выводит на консоль
            }
        }
    }
}
