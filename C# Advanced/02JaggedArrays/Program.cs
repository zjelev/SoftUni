using System;
using System.Linq;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            
            // 6. Jagged-Array Modification
            /*
            int[][] jagged = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                jagged[i] = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
            }

            string[] input = Console.ReadLine()
                    .Split(' ');

            while (input[0] != "END")
            {
                string command = input[0];
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int operand = int.Parse(input[3]);

                if (row < 0 || row >= rows || col < 0 || col >= jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (command.ToLower() == "add")
                    {
                        jagged[row][col] += operand;
                    }

                    if (command.ToLower() == "subtract" )
                    {
                        jagged[row][col] -= operand;
                    }
                }
                input = Console.ReadLine()
                    .Split(' ');
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write($"{jagged[row][col]} ");
                }

                Console.WriteLine();
            }
            */

            //7.Pascal Triangle
            long[][] jagged = new long[rows][];
            int currentLenght = 1;

            for (int i = 0; i < rows; i++)
            {
                jagged[i] = new long[currentLenght];
                jagged[i][0] = 1;
                jagged[i][currentLenght -1] = 1;

                if (currentLenght > 2)
                {
                    for (int j = 1; j < currentLenght - 1; j++)
                    {
                        jagged[i][j] = jagged[i-1][j-1] + jagged[i-1][j];
                    }
                }

                currentLenght++;
            }

            /*
            if (rows > 0)
            {                
                jagged[0] = new int[1];
                jagged[0][0] = 1;
                for (int row = 2; row <= rows; row++)
                {
                    jagged[row-1] = new int[row];
                    jagged[row-1][0] = 1;
                    for (int col = 1; col < row - 2; col++)
                    {
                        jagged[row-1] = new int[row];
                        jagged[row-1][col] = jagged[row - 2][col - 1] + jagged[row - 2][col];
                    }
                }
            }
            */

           foreach (long[] row in jagged)
            {
               Console.WriteLine(String.Join(' ', row));
            }
        }
    }
}
