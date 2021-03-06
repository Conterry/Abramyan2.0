﻿using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Array37();
        }

        #region Tasks18_26
        static void Array18()
        {
            int[] a = { 3, 6, 3, 2, 4, 6, 5, 8, 3, 10 };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < a[9])
                {
                    Console.WriteLine(a[i]);
                    return;
                }
            }
            Console.WriteLine(0);
        }

        static void Array19()
        {
            int[] a = { 10, 24, 67, 2, 578, 2, 56, 3, 44, 5 };
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > a[0] && a[i] < a[9])
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
            int k = 3, l = 7, sum = 0;
            int[] a = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            for (int i = k - 1; i < l - 1; i++)
            {
                sum += a[i];
            }
            Console.WriteLine(sum);
        }

        static void Array21()
        {
            int k = 3, l = 7, sum = 0;
            int[] a = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            for (int i = k - 1; i < l - 1; i++)
            {
                sum += a[i];
            }
            Console.WriteLine(sum / (float)(l - k));
        }

        static void Array22()
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
            Console.WriteLine(sum2 - sum);
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
            Console.WriteLine(sum / (10 - (l - k)));
        }

        static void Array24()
        {
            int[] a = { 3, 5, 7, 9, 11, 13 };
            int diff = a[1] - a[0];
            for(int i=2; i<a.Length; i++)
            {
                if(a[i]-a[i-1]!=diff)
                {
                    Console.WriteLine(0);
                    return;
                }
            }
            Console.WriteLine( diff);
            /*int[] arefm = new int[a.Length - 1];
            for (int i = 1; i < a.Length; i++)
            {
                arefm[i - 1] = a[i] - a[i - 1];
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
            }*/
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
            while (p % 2 != v % 2 && i < n)
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
        #endregion
        //==============================================
        static void Array27()
        {
            int[] a = { 3, -1, 5, -5, 6, -1, 6 };
            int i = 1;
            //while (Proverka(a[i - 1], a[i]))
            while (a[i - 1] * a[i] < 0)
            {
                i++;
            }

            if (i > a.Length)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(a[i]);
            }

        }

        static bool Proverka(int a, int b)
        {
            a *= -1;
            return a * b > 0;
        }
        //=============================================

        static void Array28()
        {
            int[] a = { 2, 6, 3, 6, 7, 2, 1, 7, 9, 4, 3 };
            int min = a[0];
            for (int i = 2; i < a.Length; i += 2)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine(min);
        }

        static void Array29()
        {
            int[] a = { 2, 6, 3, 6, 7, 2, 1, 7, 9, 4, 3 };
            int min = a[0];
            if (a.Length % 2 == 0)
            {
                for (int i = 1; i < a.Length - 1; i += 2)
                {
                    if (a[i] < min)
                    {
                        min = a[i];
                    }
                }
                Console.WriteLine(min);
            }
            else
            {
                for (int i = 1; i < a.Length - 2; i += 2)
                {
                    if (a[i] < min)
                    {
                        min = a[i];
                    }
                }
                Console.WriteLine(min);
            }
        }

        static void Array30()
        {
            int[] a = { 2, 8, 3, 8, 3, 7, 4, 7, 9, 4, 2, 5, 7, 3, 6, 3, 2, 6, 7, 3, 2, };
            int count = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] > a[i + 1])
                {
                    count++;
                    Console.WriteLine(i);
                }
            }
        }

        static void Array31()
        {
            int[] a = { 2, 8, 3, 8, 3, 7, 4, 7, 9, 4, 2, 5, 7, 3, 6, 3, 2, 6, 7, 3, 2, };
            int count = 0;
            for (int i = a.Length; i > 1; i--)
            {
                if (a[i] > a[i - 1])
                {
                    count++;
                    Console.WriteLine(i);
                }
            }
        }

        static void Array32()
        {
            int[] a = { 2, 6, 3, 6, 9, 5, 7, 4, 2, 4, 6 };
            int count = 0, i = 1;
            while (count < 1)
            {
                if (a[i] < a[i + 1] && a[i] < a[i - 1])
                {
                    count++;
                }
                i++;
            }
            Console.WriteLine(i--);
        }

        static void Array33()
        {
            int[] a = { 2, 6, 3, 6, 9, 5, 7, 4, 2, 4, 6 };
            int count = 0, i = a.Length - 1;
            while (count < 1)
            {
                if (a[i] > a[i + 1] && a[i] > a[i - 1])
                {
                    count++;
                }
                i--;
            }
            Console.WriteLine(i++);
        }

        static void Array34()
        {
            int[] a = { 4, 7, 2, 15, 8, 2, 68, 4, 8, 3, 57 };
            int max = a[1];
            for (int i = 1; i < a.Length - 1; i++)
            {
                if (a[i] < a[i - 1] && a[i] < a[i + 1])
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                    }
                }
            }
            Console.WriteLine(max);
        }

        static void Array35()
        {
            int[] a = { 4, 7, 2, 15, 8, 2, 68, 4, 8, 3, 57 };
            int min = a[1];
            for (int i = 1; i < a.Length - 1; i++)
            {
                if (a[i] > a[i - 1] && a[i] > a[i + 1])
                {
                    if (a[i] < min)
                    {
                        min = a[i];
                    }
                }
            }
            Console.WriteLine(min);
        }

        //=========================================================================
        static void Array36()
        {
            int[] a = { 4, 7, 2, 15, 8, 2, 68, 4, 8, 3, 57 };
            int max = a[1];

            for (int i = 1; i < a.Length - 1; i++)
            {
                if (!LocalMin(a[i - 1], a[i], a[i + 1]) && !LocalMax(a[i - 1], a[i], a[i + 1]))
                {
                    if (max < a[i])
                    {
                        max = a[i];
                    }
                }
            }
            Console.WriteLine(max);

        }

        static bool LocalMin(int a, int b, int c)
        {
            return b < a && b < c;
        }


        static bool LocalMax(int a, int b, int c)
        {
            return b > a && b > c;
        }

        //=============================================================


        static void Array37()
        {
            int[] a = { 3, 5, 2, 6, 9, 1, 2, 1 };
            int i = 0;
            int count = 0;
            while (i < a.Length)
            {
                while ((i<a.Length-1) && (a[i] < a[i + 1]) )
                {
                    i++;
                }
                count++;
                i++;
            }

            Console.WriteLine(count);
        }

        static void Array38()
        {
            int[] a = { 3, 5, 2, 6, 9, 1, 2, 1 };
            int i = 0;
            int count = 0;
            while (i < a.Length)
            {
                while ((i < a.Length - 1) && (a[i] > a[i + 1]))
                {
                    i++;
                }
                count++;
                i++;
            }

            Console.WriteLine(count);
        }

        static void Array39()
        {
            int[] a = { 3, 5, 2, 6, 9, 1, 2, 1 };
            int i = 0;
            int count = 0;
            while (i < a.Length)
            {
                while (a[i] > a[i + 1] && a[i] < a[i + 1])
                {
                    i++;
                }
                count++;
            }

            Console.WriteLine(count);
        }

        static void Array40()
        {
            int[] a = { 3, 7, 8, 4, 2, 5, 8, 2, 0, 354, 3, 6, 8 };
            int k = 5;
            int CountK = Math.Abs(k - a[0]);
            for (int i = 1; i < a.Length; i++)
            {
                if (Math.Abs(k - a[i]) < CountK)
                {
                    CountK = Math.Abs(k - a[i]);
                }
            }
            Console.WriteLine(CountK);
        }

        static void Array41()
        {
            int[] a = { 4, 7, 3, 5, 7, 4, 6, 8, 0, 8, 6, 3, 1, 4, 6 };
            int max = 0, imax1 = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] + a[i + 1] > max)
                {
                    imax1 = i;
                    max = a[i] + a[i + 1];
                }
            }
            Console.WriteLine(imax1);
            Console.WriteLine(imax1 + 1);
        }

        static void Array42()
        {
            int[] a = { 3, 7, 8, 4, 2, 5, 8, 2, 0, 9, 3, 6, 8 };
            int k = 5, imax = 1;
            int CountK = Math.Abs(k - a[0]);
            for (int i = 1; i < a.Length - 1; i++)
            {
                if (Math.Abs(k - (a[i] + a[i + 1])) < CountK)
                {
                    CountK = Math.Abs(k - (a[i] + a[i + 1]));
                    imax = i;
                }
            }
            Console.WriteLine(imax);
            Console.WriteLine(imax + 1);
        }

        static void Array43()
        {
            int count = 0;
            int[] a = { 2, 3, 4, 5, 6, 7, 8, 9 };
            for(int i=0; i < a.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (a[i] != a[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }



        static void Array44()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 5, 8, 9 };
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (a[j] == a[i])
                    {
                        Console.WriteLine(a[j]);
                        break;
                    }
                }
            }
        }

        static void Array45()
        {
            int[] a = { 2, 5, 7, 3, 5, 4, 7, 3, 5 };
            int min = Math.Abs(a[0] - a[1]), imin1=0, imin2=0;
            for(int i=0; i<a.Length-1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Math.Abs(a[i] - a[j]) < min)
                    {
                        min = Math.Abs(a[i] - a[j]);
                        imin1 = i;
                        imin2 = j;
                    }
                }
            }
            if (imin1 < imin2)
            {
                Console.WriteLine(imin1);
                Console.WriteLine(imin2);
            }
            if (imin1 > imin2)
            {
                Console.WriteLine(imin2);
                Console.WriteLine(imin1);
            }
        }


        static void Array47()
        {
            int[] a = { 2, 3, 4, 5, 6, 7, 8, 11 };
            int n = 1;
            for(int i=0; i<a.Length; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if (a[i] != a[j])
                    {
                        n++;
                    }
                }
            }
            Console.WriteLine(n);
        }


        static void Array48()
        {
            int[] a = { 2, 3, 4, 5, 6, 7, 8, 11 };
            int n = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (a[i] == a[j])
                    {
                        n++;
                    }
                }
            }
            Console.WriteLine(n);
        }

        static void Array49()
        {
            int[] a = { 2, 3, 4, 5, 6, 7, 8, 11 };
            int n = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (a[i] == a[j])
                    {
                        n++;
                    }
                    else
                    {
                        Console.WriteLine(j);
                        break;
                    }
                }
            }
            if (n == a.Length)
            {
                Console.WriteLine(0);
            }
        }

        static void Array51()
        {
            int[] a = { 2, 4, 7, 3, 5, 8, 3 };
            int[] b = { 6, 2, 4, 8, 3, 7, 7 };
            int rez = 0;
            for(int i=0; i<a.Length; i++)
            {
                rez = a[i];
                a[i] = b[i];
                b[i] = rez;
            }
            for(int i=0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
        }

        static void Array52()
        {
            int[] a = { 2, 6, 3, 4, 8, 4, 3, 7, 0, 5, 3, 2 };
            int[] b = new int[a.Length];
            for(int i=0; i<a.Length; i++)
            {
                a[i] = (a[i]<5? 2*a[i]: a[i]/2);
                Console.WriteLine(b[i]);
            }

        }

        static void Array53()
        {
            int[] a = { 2, 4, 7, 3, 5, 8, 3 };
            int[] b = { 6, 2, 4, 8, 3, 7, 7 };
            int[] c = new int[a.Length];
            for(int i=0; i<a.Length; i++)
            {
                if (a[i] > b[i])
                {
                    c[i] = a[i];
                }
                else
                {
                    c[i] = b[i];
                }
                Console.WriteLine(c[i]);
            }
        }
        /*
        static void Array54()
        {
            int[] a = { 2, 3, 4, 5, 6, 7, 8, 8, 9 };
            int[] b = new int[a.Length];
            int j = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    b[j] = a[i];
                    j++;
                }
            }
            int i = 0;
            int count=0;
            while (b[i] != 0)
            {
                Console.WriteLine(b[i]);
                count++;
            }
            Console.WriteLine(count);
        }*/
    }
}
