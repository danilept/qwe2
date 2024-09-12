using System;

namespace danilyarik
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine("Выберите пункт меню:");
                Console.WriteLine("1. Ввести A");
                Console.WriteLine("2. Ввести B");
                Console.WriteLine("3. Выполнить операцию '+'");
                Console.WriteLine("4. Выход");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите значение A: ");
                        a = int.Parse(Console.ReadLine());
                        break;
                    case "2":
                        Console.Write("Введите значение B: ");
                        b = int.Parse(Console.ReadLine());
                        break;
                    case "3":
                        int sum = a + b;
                        Console.WriteLine($"Результат: {a} + {b} = {sum}");
                        break;
                    case "4":
                        validInput = true;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                        break;
                    case "7":
                        validInput = true;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                        break;

                }

                Console.WriteLine();
            }

            Console.WriteLine("Программа завершена.");
        }
    }
}