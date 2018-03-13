using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPracticeProgram3
{
    class Program
    {
        static void Main(string[] args)
        {
            // program to tell that there is an odd number in an array
            int[] array = new int[5];
            Console.WriteLine("Enter the values of an array = ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            bool hasOddNumber = false;
            for (int i = 0; i < array.Length; i++)
            {
                int value = array[i];

                if (value % 2 != 0)
                {
                    hasOddNumber = true;
                    break;
                }
            }

            if (hasOddNumber)
            {
                Console.WriteLine("Array has odd number");
            }
            else
            {
                Console.WriteLine("Array has only even numbers");
            }
            Console.ReadLine();

        }
    }
}
