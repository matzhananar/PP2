using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        public static bool isprime (int b)
        {
            if (b == 1)
            {
                return false;
            }
            for (int i=2; i*i<=b; i++)
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
            int n = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split();
            int[] a = new int[n];
            int cnt = 0;
            for(int i=0; i<n; i++)
            {
                a[i] = int.Parse(arr[i]);
                if (isprime(a[i]) == true)
                    cnt++;
            }
            Console.WriteLine(cnt);
            for (int i = 0; i < n; i++)
            {
                       if(isprime(a[i]))  
                    Console.Write(a[i] + " ");
            }
            }
    }
}
