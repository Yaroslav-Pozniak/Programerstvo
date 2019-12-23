using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            int n = 0, input = 0, i = 0, j = 0;
            do
            {
                input = int.Parse(Console.ReadLine());
                numbers.Add(input);
                n++;

            } while (input >= 0 && input <= 1);

            numbers.RemoveAt(n-1);

            foreach (int num  in numbers)
            {
                if (num == 0)
                {
                    i++;
                }
                else
                    j++;
            }
            Console.Write("Zero: "+i+"\n One:" + j);
            int[] nums = numbers.ToArray();

            Console.WriteLine("\nArray: ");
            foreach(int num in nums)
            {
                Console.Write(num+" ");
            }
        }
    }
}//Створити ліст інтових змінних, який може вміщати тільки 1 і 0, заповнити його з клавіатури. Порахувати кількість 1 і 0. Скопіювати отриманий ліст в масив.

