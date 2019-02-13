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
            int n = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split();
            int[] a = new int[n * 2];
            int k = 0;
            for (int i=0; i<n; i++)
            {
                for(int j=0; j<2; j++)
                {
                    a[k] = int.Parse(arr[i]);
                    k++;
                }
            }
            for(int i=0; i<n*2; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
