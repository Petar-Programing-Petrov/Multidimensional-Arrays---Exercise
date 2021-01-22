
using System;
using System.Linq;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[,];

            for (int row = 0; row < sizeOfMatrix; row++)
            {
                int[] rowValues = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


            }

        }
    }
}
