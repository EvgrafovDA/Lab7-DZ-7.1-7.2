using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            CalcSum(a, b, c);
            Console.ReadLine();
        }
        static void CalcSum(int a, int b)
        {
            int S = a + b;
            Console.WriteLine(S);
        }
        static void CalcSum(int a, int b, int c)
        {
            int S = a + b + c;
            Console.WriteLine(S);
        }
    }
}
