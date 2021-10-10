using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] t = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    t[0, 0] = 1;

                    if (j % 2 > 0)
                    {
                        if (i % 2 > 0)
                        {
                            t[i, j] = 1;
                        }
                    }
                    if (j % 2 == 0)
                    {
                        if (i % 2 == 0)
                        {
                            t[i, j] = 1;
                        }

                    }

                    Console.Write("{0} ", t[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }









    }
}
