using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0, i = 0, M = 0, j = 0;


            do {

                Console.WriteLine("Enter N: ");
                N = int.Parse(Console.ReadLine());

            } while (N < 0);

            M = N;

            int[] a = new int[N];

            for(i = 0; i < N; i++)
            {
                Console.WriteLine("Enter element №"+(i+1)+": ");
                a[i]=int.Parse(Console.ReadLine());
            }

            for (i = 0; i < N; i++)
            {

                if (a[i] > 0)
                {
                    M++;
                }
            }

            int[] arr = new int[M];

            bool B = false;
            i = 0;
            for (j = 0; j < M; j++)
            {
                if (B)
                {
                    B = false;
                    continue;
                }

                if (a[i] < 0)
                {
                    arr[j] = a[i];
                    B = false;
                    i++;
                }

                else if (a[i] > 0)
                {
                    arr[j] = a[i];
                    B = true;
                    i++;
                }

                

               
            }

            for (j = 0; j < M; j++)
            {
                Console.WriteLine("\n Element: "+arr[j]);
            }
        }
    }
}
//23.	Даний масив розміру N. Перетворити його, вставивши перед (після) кожного додатного (від’ємного) елементу нульовий елемент. 
