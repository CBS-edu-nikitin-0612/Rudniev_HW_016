using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class MyMatrix
    {
        private int[,] matrix;
        public readonly int Rows, Columns;
        public int this[int rows, int columns]
        {
            get => matrix[rows, columns];
            set => matrix[rows, columns] = value;
        }

        public MyMatrix()
        {
            this.matrix = new int[2, 2];
            this.Rows = 2;
            this.Columns = 2;

            for (int i = 0; i < this.Rows; i++)
                for (int j = 0; j < this.Columns; j++)
                    matrix[i, j] = new Random().Next(-10, 10);
        }
        public MyMatrix(int rows, int columns)
        {
            this.matrix = new int[rows, columns];
            this.Rows = rows;
            this.Columns = columns;

            for (int i = 0; i < this.Rows; i++)
                for (int j = 0; j < this.Columns; j++)
                    matrix[i, j] = new Random().Next(-10, 10);
        }

        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Columns; j++)
                    res += matrix[i, j] + " ";
                res += "\n";
            }
            return res;
        }
    }
}
