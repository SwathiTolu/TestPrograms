using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPracticeProgram2
{
    class Program
    {
        static void Main(string[] args)
        {
            //program to sum values in two arrays and place them in a third array

            int[] array1 = new int[4];
            Console.WriteLine("Enter the values for Array1 = ");
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] array2 = new int[4];
            Console.WriteLine("Enter the values for Array2 = ");
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] array3 = new int[4];
            Console.Write("The sum of values of both the arrays will be listed here = { ");
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = array1[i] + array2[i];
                Console.Write("{0} ", array3[i]);
            }
            Console.Write("}");
            Console.ReadKey();


        }
    }
}
