using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matod2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the line of 10 words with spaces");
            string[] words = Console.ReadLine().Split(' ');
            foreach (string word in words)
                Console.Write(word+" ");
            Console.Write("\n");

            for (int i = words.Length - 1; i > -1; i--)
                Console.Write(words[i]+" ");
            Console.Write("\n");

            string tmp = words[0];
            words[0] = words[words.Length - 1];
            words[words.Length - 1] = tmp;
            Console.WriteLine(string.Join(" ", words));

            Console.WriteLine("Enter sumbol");
            string sumbol = Console.ReadLine().ToLower();
            int cnt = 0;
            int cnt1 = 0;
            foreach (string word in words)
            {
                if (word.StartsWith(sumbol))
                    cnt++;
                if (word.EndsWith(sumbol))
                    cnt1++;
            }
            Console.WriteLine(cnt.ToString() + " " + cnt1.ToString());

            Console.ReadKey();
        }
    }
}
