using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        
        public static bool isprime (int b)                //цикл на проверку прайм
        {
            if (b == 1)
            {
                return false;
            }
          
            for (int i=2; i*i<=b; i++)                    //цикл на проверку прайм
            {
                if(b%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());        //переменная чтобы сохранять количество чисел
            string[] arr = Console.ReadLine().Split();    //массив строк, читает с консоли числы и разделяет на каждый элемент
            int[] a = new int[n];                         //массив чисел
            int cnt = 0;                                  //коунтер чтобы выводил количество прайм в массиве 
            for(int i=0; i<n; i++)
            {
                a[i] = int.Parse(arr[i]);                 //чтобы сохранять string  как int
                if (isprime(a[i]) == true)                //проверяет и считатет кол-во праймов
                    cnt++;
            }
            Console.WriteLine(cnt);
            for (int i = 0; i < n; i++)
            {
                       if(isprime(a[i]))                 //проверяет простых чисел и сохраняет
                    Console.Write(a[i] + " ");           //выводит простых чисел
            }
            Console.ReadKey();                           //чтобы сразу не закрывался
            }
    }
}
