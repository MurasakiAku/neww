using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        //public class PrintWhile
        //{
        //    public static int PrintResultWhile(int n)
        //    {
        //        int k = 1;
        //        while (k * k < n)
        //        {
        //            k++;
        //        }
        //        return k;
        //    }
        //}
        //public class PrintFor
        //{
        //    public static double PrintResultFor(double d)
        //    {
        //        double w = 0;
        //        for (int i = 1; i <= d; i++)
        //        {
        //            w = (Math.Pow(d, 2) + Math.Pow(d + i, 2) + Math.Pow(2 * d, 2));
        //        }
        //        return w;
        //    }
        //}

        public class PrintResult {

           public static bool WriteLineOne(int b)
           {
                int[] a;

                a = new int[b];
                Console.WriteLine("Введите числа:");
                for (int i = 0; i < b; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < b - 1; i++)
                {
                    if (a[i] >= a[i + 1])
                    {
                        return false;
                    }
                }
                return true;
           }
        }
    


        static void Main(string[] args)
        {
            //PrintWhile printWhile = new PrintWhile();
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(PrintWhile.PrintResultWhile(n));

            //PrintFor printFor = new PrintFor();
            //double d = double.Parse(Console.ReadLine());
            //Console.WriteLine(PrintFor.PrintResultFor(d));

            PrintResult printResult = new PrintResult();
            Console.WriteLine("Количество вводимых чисел:");
            int b = int.Parse(Console.ReadLine());
            //int a = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintResult.WriteLineOne(b));
            
            Console.ReadKey();
        }
        
    }
}
