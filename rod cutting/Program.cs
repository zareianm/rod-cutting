using System;

namespace rod_cutting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            int[] P = { 0, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 };

            RodCutting(P, n);
        }

        private static void RodCutting(int[] p, int n)
        {
            int[] r = new int[n + 1];
            int[] s = new int[n + 1];

            for (int i = 1; i < n + 1; i++)
            {
                int q = int.MinValue;
                for (int j = 1; j <= i; j++)
                {
                    if (q < p[j] + r[i - j])
                    {
                        q = p[j] + r[i - j];
                        s[i] = j;
                    }
                }
                r[i] = q;
            }

            Console.WriteLine(r[n]);

            PrintCods(s, n);
        }

        private static void PrintCods(int[] s, int n)
        {
            while (n > 0)
            {
                Console.Write(s[n] + " ");
                n -= s[n];
            }
        }
    }
}
