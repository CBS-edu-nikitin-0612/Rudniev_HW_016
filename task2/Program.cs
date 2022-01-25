using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray myArray = new MyArray(10);
            Console.WriteLine("Полученный массив случайных чисел:");
            for (int i = 0; i < myArray.Length; i++)
                Console.Write(myArray[i] + " ");
            Console.WriteLine();

            Console.Write("Максимальный элемент массива: ");
            Console.WriteLine(myArray.MaxValue());
            Console.Write("Минимальный элемент массива: ");
            Console.WriteLine(myArray.MinValue());

            Console.Write("Общая сумма элементов массива: ");
            Console.WriteLine(myArray.Sum());
            Console.Write("Среднее арифметическое элементов массива: ");
            Console.WriteLine(myArray.Sum() / myArray.Length);

            Console.WriteLine("Нечетные значения элементов массива:");
            for (int i = 0; i < myArray.Length; i++)
                if ((myArray[i] % 2) != 0)
                    Console.Write(myArray[i] + " ");
            Console.WriteLine();
        }
    }
}
