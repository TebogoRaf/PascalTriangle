using System;

namespace PascalTriangle
{
    class PascalTriangle
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows you want to see on your pascal triangle :");
            int numOfRows = int.Parse(Console.ReadLine());

            PrintTriangle(numOfRows);
        }
        public static void PrintTriangle(int numOfRows)
        {
            int[][] triangle = new int[numOfRows][];

            for (int a = 0; a < numOfRows; a++)
            {
                    triangle[a] = new int[a + 1];
                }
                for (int a = 0; a < numOfRows; a++)
                {
                    for (int x = 0; x <= a; x++)
                    {
                        if (x == 0 || x == a)
                        {
                            triangle[a][x] = 1;
                        }
                        else
                        {
                            triangle[a][x] = triangle[a - 1][x - 1] + triangle[a - 1][x];
                        }
                    }
                }
            for (int a = 0; a < numOfRows; a++)
            {
                for (int x = 0; x <= a; x++)
                {
                    Console.Write(triangle[a][x] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}