using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod1
{
    class Program
    {
        static int[] mult2(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] *= 2;
            return a;
        }

        static int[] xminus(int[] a)
        {
            Console.WriteLine("Enter number: ");
            int A = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a.Length; i++)
                a[i] -= A;
            return a;
        }

        static int[] xdel1(int[] a)
        {
            int B = a[0];
            for (int i = 0; i < a.Length; i++)
                a[i] /= B;
            return a;
        }

        static void Main(string[] args)
        {
            int[] x = new int[] { 2, 2, 3, 6, 8 };
            Console.WriteLine(string.Join(" ", x));

            //Console.WriteLine(string.Join(" ", mult2(x)));
            //Console.WriteLine(string.Join(" ", xminus(x)));
            //Console.WriteLine(string.Join(" ", x));
            //Console.WriteLine(string.Join(" ", xdel1(x)));
            Console.WriteLine(Math.Sqrt(x[2]).ToString());
            Console.WriteLine(Convert.ToString((x[0] + x[2]) / 2));
            Console.WriteLine(Convert.ToString(x.Average()));
            Console.WriteLine(Convert.ToString(x.Sum()));

            Console.ReadKey();
        }
    }
}
