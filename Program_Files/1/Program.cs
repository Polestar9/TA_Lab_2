using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Введіть число в діапазоні від 1-го до 9-ти:");
            string userinputnumber = Console.ReadLine() ?? "";

            int routenumber;
            if (!int.TryParse(userinputnumber, out routenumber) || routenumber <= 0 || routenumber > 9)
            {
                Console.WriteLine("Ви ввели неправильне значення, його формат, або число, яке не входить в діапазон.\nБудь ласка введіть значення відь 1-го до 9-ти.");
                continue;
            }

            switch (routenumber)
            {
                case 1:
                    Console.WriteLine("\nТролейбус №1 \nвул. Ясська – Національний університет \nНаціональний Університет – вул. Ясська \n");
                    break;
                case 2:
                    Console.WriteLine("\nТролейбус №2 \nНаціональний Університет початкова — Поліклініка Профогляду “Гравітон” \nПоліклініка Профогляду “Гравітон” — Національний Університет \n");
                    break;
                case 3:
                    Console.WriteLine("\nТролейбус №3 \nДріжджзавод — Училище №15 \nУчилище №15 — Дріжджзавод \n");
                    break;
                case 4:
                    Console.WriteLine("\nТролейбус №4 \nМузей народної архітектури та побуту — Національний Університет \nНаціональний Університет — Музей народної архітектури та побуту \n");
                    break;
                case 5:
                    Console.WriteLine("\nТролейбус №5 \nКалинівський Ринок — Південно-Кільцева \nПівденно-Кільцева — Калинівський Ринок \n");
                    break;
                case 6:
                    Console.WriteLine("\nТролейбус №6 \nПлоща Соборна — Училище №15 \nУчилище №15 — Площа Соборна \n");
                    break;
                case 7:
                    Console.WriteLine("\nТролейбус №6А \nУчилище №15— Степана Бандери \nСтепана Бандери — Училище №15 \n");
                    break;
                case 8:
                    Console.WriteLine("\nТролейбус №8 \nвул. Південно-Кільцева- Національний університет \nНаціональний університет – Південно-Кільцева \n");
                    break;
                case 9:
                    Console.WriteLine("\nТролейбус №8А \nПівденно-Кільцева — Степана Бандери \nСтепана Бандери — Південно-Кільцева \n");
                    break;
            }
        }

        Console.WriteLine("Exiting the program. Press any key to close the console window.");
        Console.ReadKey();
    }
}
