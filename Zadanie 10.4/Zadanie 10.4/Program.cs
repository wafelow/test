using System;

namespace tablicepraktyczne
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] magazyny = new string[5,2] ;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    magazyny[i, j] = Console.ReadLine();
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(magazyny[i, j] + ' ');
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
