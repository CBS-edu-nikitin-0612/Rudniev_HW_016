using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            Console.WriteLine(store[0]);
            Console.WriteLine(store[1]);
            Console.WriteLine(store[2]);
            Console.WriteLine(store[3]);
            Console.WriteLine(store[4]);
            Console.WriteLine(store[5]);
            Console.WriteLine(new string('_', 50));

            do
            {
                Console.Write("Введите название товара ('exit'-для выхода): ");
                string result = Console.ReadLine();
                if (result == "exit") break;
                Console.WriteLine(store[result]);
            } while (true);
        }
    }
}
