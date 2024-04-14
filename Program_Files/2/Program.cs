using System;

class Program
{
    static void Main(string[] args)
    {
        double a, b, dx;

        while (true)
        {
            Console.WriteLine("Введіть значення а:");
            string inputA = Console.ReadLine() ?? "";
            if (string.IsNullOrWhiteSpace(inputA))
            {
                Console.WriteLine("Порожнє значення. Спробуйте знову.");
                continue;
            }
            a = Convert.ToDouble(inputA);
            break;
        }

        while (true)
        {
            Console.WriteLine("Введіть значення b:");
            string inputB = Console.ReadLine() ?? "";
            if (string.IsNullOrWhiteSpace(inputB))
            {
                Console.WriteLine("Порожнє значення. Спробуйте знову.");
                continue;
            }
            b = Convert.ToDouble(inputB);
            break;
        }

        while (true)
        {
            Console.WriteLine("Введіть значення dx:");
            string inputDx = Console.ReadLine() ?? "";
            if (string.IsNullOrWhiteSpace(inputDx))
            {
                Console.WriteLine("Порожнє значення. Спробуйте знову.");
                continue;
            }
            dx = Convert.ToDouble(inputDx);
            break;
        }

        Console.WriteLine("x\t|\ty");

        double x = a;

        while (x <= b)
        {
            double y;

            if (x < 0)
            {
                Console.WriteLine("Помилка. Значення аргумента x (a) дорівнює менше нулю."); // Збільшення x для уникнення безкінечного циклу
                break;
            }

            y = Math.Log(x) / (4 * x + 13);

            Console.WriteLine($"{x:F3}\t|\t{y:F6}");
            x = x + dx;
        }
    }
}
