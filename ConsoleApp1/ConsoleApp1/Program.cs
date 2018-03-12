using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write 'Hello World!' program
            //Console.WriteLine("Hello World");
            //Console.ReadKey();
            Console.Write("Hi! Which program do you want to execute?\n1) Multiplication\n2) Swap Numbers\nEnter the number respective to the program.");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Programme1.multiplication();
                    break;
                case "2":
                    Programme1.swapNumbers();
                    break;
                case "3":
                    Programme1.multiplicationTable();
                    break;
                case "4":
                    Programme1.tripleSum();
                    break;
                case "5":
                    Programme1.oddNumbers();
                    break;
                case "6":
                    Programme1.sumOfInteger();
                    break;
                case "7":
                    Programme1.multiplyArrays();
                    break;
                case "8":
                    Programme1.highLow();
                    break;
                case "9":
                    Programme1.oddPossition();
                    break;
                case "10":
                    Programme1.studentPassFail();
                    break;
                case "11":
                    Programme1.studentGradesPerSubject();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose a correct option.");
                    break;

            }




            //Programme1.multiplyArrays(); (Not done yet)

            //Programme1.sumArrrayIntegers(); (Not done yet)



        }
    }
}
