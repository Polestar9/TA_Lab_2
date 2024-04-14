using System;

class Program
{
    static int[,] matrix_generator(int n, int m)
    {
        Random random = new Random();
        int[,] matrix = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = random.Next(-100, 101);
            }
        }
        return matrix;
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введіть розмірність матриці (n x m):");
            Console.Write("n = ");
            string inputN = Console.ReadLine() ?? "";
            int n;
            if (string.IsNullOrEmpty(inputN))
            {
                Console.WriteLine("Помилка: введено порожній рядок.");
                continue;
            }
            else if (!int.TryParse(inputN, out n) || n <= 0)
            {
                Console.WriteLine("Помилка: введено некоректне значення для n.");
                continue;
            }

            Console.Write("m = ");
            string inputM = Console.ReadLine() ?? "";
            int m;
            if (string.IsNullOrEmpty(inputM))
            {
                Console.WriteLine("Помилка: введено порожній рядок.");
                continue;
            }
            else if (!int.TryParse(inputM, out m) || m <= 0)
            {
                Console.WriteLine("Помилка: введено некоректне значення для m.");
                continue;
            }

            int[,] matrix = matrix_generator(n, m);

            Console.WriteLine("Згенерована матриця:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int[] countOccurrences = new int[201]; 
            foreach (int num in matrix)
            {
                countOccurrences[num + 100]++; 
            }

            Console.WriteLine("Кількість входжень кожного з елементів:");
            for (int i = 0; i < countOccurrences.Length; i++)
            {
                if (countOccurrences[i] > 0)
                {
                    Console.WriteLine($"Елемент {i - 100} входить {countOccurrences[i]} разів");
                }
            }
        }
    }
}