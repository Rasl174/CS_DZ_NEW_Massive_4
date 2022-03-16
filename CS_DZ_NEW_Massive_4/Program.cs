using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_NEW_Massive_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int shift;

            Console.Write("На сколько сдвинуть массив: ");
            shift = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < shift; i++)
            {
                int firstNumber = numbers[0];

                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }
                numbers[numbers.Length - 1] = firstNumber;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(" " + numbers[i]);
            }
            Console.WriteLine();
        }
    }
}
