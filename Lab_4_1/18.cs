using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double R = 0, K = 0, k = 0, d = 0, b = 0;
            int n = 0,ifrst=0,isec=1, i = 0, j = 0;
            
            Console.WriteLine("Enter R: ");
            R = double.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Enter n: ");
                n = int.Parse(Console.ReadLine());
            } while (n<1);

            double[] N = new double[n];

            for(i = 0; i < n; i++)
            {
                N[i] = i + i + 1;
                Console.WriteLine(N[i]+"\n");
            }

            K = N[0] + N[1];
            d = R - K;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (j==i)
                        continue;
                    k = N[i] + N[j];
                    b = Math.Abs(R - k);
            
                    if (b < d)
                    {
                        d = b;
                        ifrst = i;
                        isec = j;
                    }
                }
            }
            Console.WriteLine("First number: " + ifrst);
            Console.WriteLine("Second number:" + isec);
        }
    }
}
//18.	Дано дійсне число R і масив розміру N. Знайти два елементи масиву, сума яких найближча (найдальша) від даного числа. 
