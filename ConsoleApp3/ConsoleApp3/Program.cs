
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        //static void PrintResult()
        //{
        //    int a = int.Parse(Console.ReadLine());
        //    int sum = 0;
        //    while (a > 0)
        //    {
        //        sum += a % 10;
        //        a /= 10;
        //    }
        //    Console.WriteLine(sum);

        //}

        static void PrintResultTwo()
        {
            int b = int.Parse(Console.ReadLine());
            int c = 0, plus=0, min=0;
            for (int i = 1; i <= b; i++)
            {               
                int a = int.Parse(Console.ReadLine());
                c = a;
                if (c >= 0)
                {
                    plus++;
                }
                else min++;
            }
            if (min > 0) { Console.WriteLine("False"); }
            else Console.WriteLine("True");
        }
        static void Main(string[] args)
        {
            // PrintResult();
            PrintResultTwo();

            //for
            //------
            //6.
            //double a = double.Parse(Console.ReadLine());
            //for (double i = 1.0; i <= 5; i+=0.1)
            //{
            //    Console.WriteLine(a*i);
            //}

            //5.
            //double a = double.Parse(Console.ReadLine());
            //for (double i = 0.1; i <= 1; i += 0.1)
            //{
            //    Console.WriteLine(a * i);
            //}

            //11.
            //double n = double.Parse(Console.ReadLine());
            ////double n1, n2,n3;
            //for (int i = 1; i <= n; i++)
            //{
            //    //n1 = Math.Pow(n, 2);
            //    //n2 = Math.Pow(n + i, 2);
            //    //n3 = Math.Pow(2 * n, 2);
            //    //Console.WriteLine(n1+n2+n3);
            //    Console.WriteLine(Math.Pow(n, 2)+ Math.Pow(n +i, 2) + Math.Pow(2 * n, 2));
            //}

            //12.
            //double n = double.Parse(Console.ReadLine());
            //for (double i=1.1; i<=2.0; i+=0.1)
            //{

            //    Console.WriteLine(n=n*i);
            //}

            //------
            //while

            //1.

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //while (a > b)
            //{
            //    a = a - b;
            //    Console.WriteLine(a);
            //}

            //3.

            //int n = int.Parse(Console.ReadLine());
            //int k = int.Parse(Console.ReadLine());
            ////int s = k, count =0;
            //while (n>k)
            //{
            //    //count++;
            //    //s -= 1;
            //    k = n / k;
            //    n = n % k;
            //   // k = n / k;                
            //}
            //Console.WriteLine($"Остаток от деления {n} \nЧастное от деления {k}");

            //7.
            //int n = int.Parse(Console.ReadLine());
            //int k = 1;
            //while (k*k<=n)
            //{
            //    Console.WriteLine(k++);
            //}

            //if
            //25
            //int x = int.Parse(Console.ReadLine());
            //if (x < -2 || x > 2)
            //{
            //    Console.WriteLine(2 * x);
            //}
            //else { Console.WriteLine(-3 * x); }

            //26
            //int x = int.Parse(Console.ReadLine());
            //if (x < 0)
            //{
            //    Console.WriteLine(0);
            //}
            //else if (x % 2 == 0)
            //{
            //    Console.WriteLine(1);
            //}
            //else { Console.WriteLine(-1); }

            //Series

            //11
            //int n = int.Parse(Console.ReadLine());
            //int k=0;
            //while (true)
            //{
            //    Console.WriteLine(n < k);
            //}











            Console.ReadKey();
        }
        
    }
}
