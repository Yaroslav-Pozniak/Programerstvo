using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            int M = 0;
            do
            {
                Console.WriteLine("Enter M: ");
                M = int.Parse(Console.ReadLine());

            } while (M < 0);
            int[,] matrix = new int[M, M];

            for (int i = 0; i < M; i++)
            { 
                for(int j = 0; j < M; j++)
                {
                    Console.Write("Enter element ["+(i+1)+','+(j+1)+"] : ");
                    matrix[i,j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(" "+matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("180: ");

            for (int i = 0; i < M-i; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    int k = matrix[i, j];
                    matrix[i, j] = matrix[M - i - 1, M - j - 1];
                    matrix[M - i - 1, M - j - 1] = k;
                    
                }
                Console.WriteLine();
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(" " + matrix[i, j]);
                }
                Console.WriteLine();
            }


        }
    }
}//Повернути матрицю на 180 градусів
