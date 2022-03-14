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
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int shift;

            Console.WriteLine("На сколько сдвинуть массив: ");
            shift = Convert.ToInt32(Console.ReadLine());

            for (int i = 0 ; i < numbers.Length; i++)
            {
                numbers[i] -= shift;
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
