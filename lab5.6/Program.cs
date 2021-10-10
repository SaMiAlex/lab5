using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону квадрата");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] t = new int[N, N];

            #region//Формирование массива пользователем
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("N({0},{1})=", i, j);
                    t[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0,-2} ", t[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
			#endregion

			// вычисляем, магический ли квадрат
			bool magic = true;
			int sum = 0;             // эталонная сумма, будем с ней сравнивать все остальные суммы
			int sumR = 0;             // сумма по строкам
			int sumC = 0;          // сумма по столбцам
			int sumD1 = 0;       // сумма по дагонали
			int sumD2 = 0; // сумма по другой диагонали
			for (int i = 0; i < N; i++)
			{
				
				for (int j = 0; j < N; j++)
				{
					sumR += t[i, j];
					sumC += t[j, i];
				}
				if (i == 0)
				{
					// запоминаем эталонную сумму 
					sum = sumR;
				}
				if (sumR != sum || sumC != sum)
				{
					// не совпали суммы по строке или столбцу с эталонной
					magic = false;
					break;
				}
				sumD1 += t[i, i];
				sumD2 += t[i, N - i - 1];
			}
			// проверяем суммы для диагоналей между собой и с одной из вычисленных сумм по строке или столбцу
			if (sumD1 != sum || sumD2 != sum)
			{
				magic = false;
			}

			if (magic)
			{
				Console.WriteLine("Магия :)");
			}
			else
			{
				Console.WriteLine("Не в этот раз :(");
			}
					
            Console.ReadKey();

        }
    }
}
