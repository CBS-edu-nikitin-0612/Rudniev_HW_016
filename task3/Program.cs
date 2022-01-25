using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix myMatrix1 = new MyMatrix();
            Console.Write(myMatrix1.ToString());
            Console.WriteLine(new string('_', 50));

            MyMatrix myMatrix2 = new MyMatrix(3, 3);
            Console.Write(myMatrix2.ToString());
            Console.WriteLine(new string('_', 50));

            MyMatrix myMatrix3 = new MyMatrix(3, 2);
            Console.Write(myMatrix3.ToString());
            Console.WriteLine(new string('_', 50));

            MyMatrix myMatrix4 = new MyMatrix(2, 3);
            Console.Write(myMatrix4.ToString());
            Console.WriteLine(new string('_', 50));
        }
    }
}
