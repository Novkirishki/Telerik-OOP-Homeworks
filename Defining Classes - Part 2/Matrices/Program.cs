//Problem 8. Matrix
//Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).

//Problem 9. Matrix indexer
//Implement an indexer this[row, col] to access the inner matrix cells.

//Problem 10. Matrix operations
//Implement the operators + and - (addition and subtraction of matrices of the 
//same size) and * for matrix multiplication.
//Throw an exception when the operation cannot be performed.
//Implement the true operator (check for non-zero elements).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            //testing
            //creating and filling 2 matrices
            Matrix<int> matrix1 = new Matrix<int>(3, 3);
            Matrix<int> matrix2 = new Matrix<int>(3, 3);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix1[i, j] = i * j;
                    matrix2[i, j] = i + j;
                }
            }
            Console.WriteLine(matrix1.ToString());
            Console.WriteLine(matrix2.ToString());

            //adding. substracting and multiplying them
            Matrix<int> matrix3 = new Matrix<int>(3, 3);
            matrix3 = matrix1 + matrix2;
            Console.WriteLine(matrix3.ToString());
            matrix3 = matrix1 - matrix2;
            Console.WriteLine(matrix3.ToString());
            matrix3 = matrix1 * matrix2;
            Console.WriteLine(matrix3.ToString());

            //testing the true and false operators
            Matrix<int> matrix4 = new Matrix<int>(3, 3);

            if (matrix3)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            if (matrix4)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
