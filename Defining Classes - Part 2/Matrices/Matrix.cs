using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Matrix<T> where T : struct
    {
        T[,] matrix;

        public Matrix(int height, int width)
        {
            matrix = new T[height, width];
        }

        public T this[int row, int col]
        {
            get
            {
                return matrix[row, col];
            }
            set
            {
                matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> c1, Matrix<T> c2)    
        {
            if (c1.GetHeight() != c2.GetHeight() || c1.GetWidth() != c2.GetWidth())
            {
                throw new Exception("operation cannot be performed - matrices are not the same size");
            }
            Matrix<T> result = new Matrix<T>(c1.GetHeight(), c1.GetWidth());
            for (int i = 0; i < c1.GetHeight(); i++)
            {
                for (int j = 0; j < c1.GetWidth(); j++)
                {
                    result[i, j] = (dynamic)c1[i, j] + (dynamic)c2[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> c1, Matrix<T> c2)
        {
            if (c1.GetHeight() != c2.GetHeight() || c1.GetWidth() != c2.GetWidth())
            {
                throw new Exception("operation cannot be performed - matrices are not the same size");
            }
            Matrix<T> result = new Matrix<T>(c1.GetHeight(), c1.GetWidth());
            for (int i = 0; i < c1.GetHeight(); i++)
            {
                for (int j = 0; j < c1.GetWidth(); j++)
                {
                    result[i, j] = (dynamic)c1[i, j] - (dynamic)c2[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> c1, Matrix<T> c2)
        {
            if (c1.GetWidth() != c2.GetHeight())
            {
                throw new Exception("operation cannot be performed - matrices are not the same size");
            }
            T sum = default(T);
            Matrix<T> result = new Matrix<T>(c1.GetHeight(), c2.GetWidth());
            for (int resRow = 0; resRow < result.GetHeight(); resRow++)
            {
                for (int resCol = 0; resCol < result.GetWidth(); resCol++)
                {
                    for (int i = 0; i < c1.GetWidth(); i++)
                    {
                        sum += (dynamic)c1[resRow, i] * (dynamic)c2[i, resCol];
                    }
                    result[resRow, resCol] = sum;
                    sum = default(T);
                }
            }

            return result;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.GetHeight(); i++)
            {
                for (int j = 0; j < matrix.GetWidth(); j++)
                {
                    if (!matrix[i,j].Equals(default(T)))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.GetHeight(); i++)
            {
                for (int j = 0; j < matrix.GetWidth(); j++)
                {
                    if (!matrix[i, j].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public int GetHeight()
        {
            return this.matrix.GetLength(0);
        }

        public int GetWidth()
        {
            return this.matrix.GetLength(1);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    string number = String.Format("{0} ", matrix[i, j]);
                    builder.Append(number);
                }
                builder.AppendLine();
            }

            return builder.ToString();
        }
    }
}
