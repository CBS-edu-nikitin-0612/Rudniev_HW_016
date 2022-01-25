using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class MyArray
    {
        private int[] array;
        public readonly int Length;

        public int this[int index] 
        {
            get    
            {
                if (index >= 0 && index < Length)
                    return array[index];
                else
                    return 404;
            }
            set   
            {
                if (index >= 0 && index < Length)
                    array[index] = value;
            }
        }

        public MyArray()
        {
            this.array = new int[10];
            this.Length = 10;

            for (int i = 0; i < this.Length; i++)
                array[i] = new Random().Next(-100, 100);
        }
        public MyArray(byte length)
        {
            this.array = new int[length];
            this.Length = length;

            for (int i = 0; i < this.Length; i++)
                array[i] = new Random().Next(-100, 100);
        }

        public int MaxValue()
        {
            int maxValue = array[0];
            for (int i = 0; i < this.Length; i++)
                if (array[i] > maxValue)
                    maxValue = array[i];
            return maxValue;
        }
        public int MinValue()
        {
            int minValue = array[0];
            for (int i = 0; i < this.Length; i++)
                if (array[i] < minValue)
                    minValue = array[i];
            return minValue;
        }

        public int Sum()
        {
            int summa = 0;
            for (int i = 0; i < this.Length; i++)
                    summa += array[i];
            return summa;
        }
    }
}
