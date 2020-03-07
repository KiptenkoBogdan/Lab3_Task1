using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int value1 = rnd.Next(21);
            int value2 = rnd.Next(21);

            int[] A = new int[value1];
            int[] B = new int[value2];

            Console.WriteLine("Massiv A");
            for (int i = 0; i < value1; i++)
                A[i] = rnd.Next(101);

            foreach (int i in A)
                Console.Write(i + " ");

            Console.WriteLine("\nMassiv B");
            for (int i = 0; i < value2; i++)
                B[i] = rnd.Next(101);

            foreach (int i in B)
                Console.Write(i + " ");

            Array.Sort(A, B);

            Console.WriteLine("\n\nSorted massiv A");
            foreach (int i in A)
                Console.Write(i + " ");

            Console.WriteLine("\nSorted massiv B\n(after elements of A)");
            foreach (int i in B)
                Console.Write(i + " ");

            Console.ReadKey();
        }
    }
}
