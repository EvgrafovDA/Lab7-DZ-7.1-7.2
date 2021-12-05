using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            int f = Convert.ToInt32(Console.ReadLine());
            CalcSum(a, b, c, d, e, f);
            Console.ReadLine();
        }
        static void CalcSum(params int[] numbers)
        {
            int S = 0;
            foreach (int n in numbers)
                S += n;
            Console.WriteLine(S);
        }
    }
}

