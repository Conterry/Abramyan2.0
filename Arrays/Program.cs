using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Array26();
        }

        static void Array18()
        {
            int count = 0;
            int[] a = { 3,6,3,2,4,6,5,8,3, 10};
            for(int i=0;i<a.Length; i++)
            {
                if (a[i] < a[9])
                {
                    Console.WriteLine(a[i]);
                    break;
                }
                else
                {
                    count++;
                }
            }
            if (count >= 10)
            {
                Console.WriteLine(0);
            }
            
        }

        static void Array19()
        {
            int[] a = { 10, 24, 67, 2, 578, 2, 56, 3, 44, 5 };
            int count = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i]>a[0] && a[i] < a[9])
                {
                    count = a[i];
                    // число с и так будет последним после прохождения цикла
                }
            }
            Console.WriteLine(count);
            //если не найдет значения, оно и так выведет 0
        }

        static void Array20()
        {
            int k = 3, l = 7, sum=0;
            int[] a = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            for(int i=k-1; i<l-1; i++)
            {
                sum += a[i];
            }
            Console.WriteLine(sum);
        }

        static void Array21()
        {
            int k = 3, l = 7 ,sum = 0;
            int[] a = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            for (int i = k - 1; i < l - 1; i++)
            {
                sum += a[i];
            }
            Console.WriteLine(sum/(l-k));
        }

        static void Array22()
        {
            int k = 3, l = 7, sum = 0, sum2 = 0;
            int[] a = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            for (int i = k - 1; i < l - 1; i++)
            {
                sum += a[i];
            }
            for(int i=0; i<10; i++)
            {
                sum2 += a[i];
            }
            Console.WriteLine(sum2 -  sum);
        }

        static void Array23()
        {
            int k = 3, l = 7, sum = 0, sum2 = 0;
            int[] a = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            for (int i = k - 1; i < l - 1; i++)
            {
                sum += a[i];
            }
            for (int i = 0; i < 10; i++)
            {
                sum2 += a[i];
            }
            sum = sum2 - sum;
            Console.WriteLine(sum/(10-(l-k)));
        }

        static void Array24()
        {
            int[] a = { 3, 5, 7, 9, 11, 13 };
            int[] arefm = new int[a.Length - 1];
            for(int i=1; i<a.Length; i++)
            {
                arefm[i - 1] = a[i] - a[i - 1];
            }
            int sum = 0;
            for(int i=0;i<a.Length - 1; i++)
            {
                sum += arefm[i];
            }
            if (sum / (a.Length-1) == arefm[3])
            {
                Console.WriteLine(arefm[3]);
            }
            else
            {
                Console.WriteLine(0);
            }
        }

        static void Array25()
        {
            int[] a = { 3, 9, 27, 81, 243, 729 };
            int[] arefm = new int[a.Length - 1];
            for (int i = 1; i < a.Length; i++)
            {
                arefm[i - 1] = a[i] / a[i - 1];
            }
            int sum = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                sum += arefm[i];
            }
            if (sum / (a.Length - 1) == arefm[3])
            {
                Console.WriteLine(arefm[3]);
            }
            else
            {
                Console.WriteLine(0);
            }
        }

        static void Array26()
        {
            int n = 5, i = 1; int[] a = { 1, 2, 4, 4, 5 };
            int p = a[1] - a[0];
            int v = a[2] - a[1];
            while (p % 2 != v % 2 && i<n)
            {
                p = v;
                v = a[i];
                i++;
            }
            if (i == n - 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
