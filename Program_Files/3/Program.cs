using System;

public class create_array
{
    private int[] arr;

    public create_array(int[] arr)
    {
        this.arr = arr;
    }

    public int num_bigger_than_five()
    {
        int count = 0;
        foreach (int num in arr)
        {
            if (num > 5)
                count++;
        }
        return count;
    }

    public int after_max_sum()
    {
        if (arr.Length == 0)
            return 0;

        int maxIndex = Array.IndexOf(arr, max_value());
        if (maxIndex == arr.Length - 1)
            return 0;

        int sum = 0;
        for (int i = maxIndex + 1; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    private int max_value()
    {
        int max = arr[0];
        foreach (int num in arr)
        {
            if (num > max)
                max = num;
        }
        return max;
    }
}

class Program
{
    static int fool_proof(string message)
    {
        int value;
        while (true)
        {
            try
            {
                Console.Write(message);
                string input = Console.ReadLine() ?? "";
                if (!int.TryParse(input, out value) || value <= 0)
                    throw new ArgumentException("Введіть коректне додатне ціле число.");
                break;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        return value;
    }

    static int[] GenerateRandomArray(int n)
    {
        Random random = new Random();
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = random.Next(-100, 101);
        }
        return arr;
    }

    static void Main(string[] args)
    {
        while (true)
        {
            int n = fool_proof("Введіть розмірність масиву: ");
            int[] arrRandom = GenerateRandomArray(n);
            Console.WriteLine("Згенерований масив:");
            foreach (var num in arrRandom)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            create_array created_array = new create_array(arrRandom);
            Console.WriteLine($"Кількість елементів масиву, більших за число п'ять: {created_array.num_bigger_than_five()}");
            Console.WriteLine($"Сума елементів масиву, розташованих після максимального елемента: {created_array.after_max_sum()}");
        }
    }
}
