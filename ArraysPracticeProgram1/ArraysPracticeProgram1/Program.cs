using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPracticeProgram1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[4];

            int[] array2 = new int[4];

            Console.WriteLine("Enter values in Array 1 = ");
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Enter values in Array 2 = ");
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = Convert.ToInt32(Console.ReadLine());

            }

            int[] array3 = new int[4];
            Console.Write("The values of new array are = { ");
            for (int i = 0; i < array1.Length; i++)
            {
                array3[i] = array1[i] * array2[i];
                Console.Write("{0} ", array3[i]);
            }
            Console.Write("}");

            Console.ReadKey();
        }
    }
}
