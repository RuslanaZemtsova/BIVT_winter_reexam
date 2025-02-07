// Variant_10

using System;

namespace Exam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var program = new Program();
            //Console.WriteLine(program.Task_1(4, 6, 22));
            // Task_1:
            // Input: S = 4, A = 6, N = 22
            // Output: time = 18

            //Console.WriteLine(program.Task_2(4, 6, 22));
            // Task_2:
            // Input: GPU = 4, RAM = 6, CPU = 22
            // Output: fps = 13,200000000000003

            //var M = new int[,] { { 23, 7, -13, 24, -21, 18 }, { 2, 0, 12, -16, -20, -17 }, { 22, 21, -6, 19, -22, -4 }, { -13, 13, 18, -15, -20, -2 }, { 3, 7, 1, -20, 22, -8 }, { -22, -11, 13, -2, 0, -14 } };
            //program.Task_3(M);
            //program.Print(M);
            // Task_3:
            // Input:
            /*   23,   7, -13,  24, -21,  18, 
                  2,   0,  12, -16, -20, -17, 
                 22,  21,  -6,  19, -22,  -4, 
                 -13, 13,  18, -15, -20,  -2, 
                  3,   7,   1, -20,  22,  -8, 
                -22, -11,  13,  -2,   0, -14 */
            // Output:
            /*   23,   7, -13,  24, -21,  18, 
                  2,   0,  12, -16, -20, -17, 
                 22,  21,  -6,  19, -22,  -4, 
                 22,  21,  18,  19, -22,  -4, 
                  2,   0,   1, -16, -20, -17, 
                 23,   7,  13,  24, -21,  18 */

            //var A = new int[] { 17, 17, 2, -10, -1, -20 };
            //program.Task_4(ref A);
            //program.Print(ref A);

            // Task_4:
            // Input:
            /*   17,  17,   2, -10,  -1, -20 */
            // Output:
            /*    2, -10, -20 */

            // Task_5:
            // Input:
            /*   23,   7, -13,  24, -21,  18, 
                  2,   0,  12, -16, -20, -17, 
                 22,  21,  -6,  19, -22,  -4, 
                -13,  13,  18, -15, -20,  -2, 
                  3,   7,   1, -20,  22,  -8, 
                -22, -11,  13,  -2,   0, -14 */

            /*   17,  17,   2, -10,  -1, -20 */
            // Output 1:
            /*   23,   7, -13,  24, -21,  18, 
                  2,   0,  12, -16, -20, -17, 
                 22,  21,  -6,  19, -22,  -4, 
                -13,  13,  18, -15, -20,  -2, 
                  3,   7,   1, -20,  22,  -8, 
                -22, -11,  13,  -2,   0, -14 */

            /*  -20, -10,  -1,   2,  17,  17, -15, -14,  -6,   0,  22,  23 */
            // Output 2:
            /*   23,   7, -13,  24, -21,  18, 
                  2,   0,  12, -16, -20, -17, 
                 22,  21,  -6,  19, -22,  -4, 
                -13,  13,  18, -15, -20,  -2, 
                  3,   7,   1, -20,  22,  -8, 
                -22, -11,  13,  -2,   0, -14 */
            /*   17,  17,   2,  -1, -10, -20,  23,  22,   0,  -6, -14, -15 */

        }
        public void Print(int[,] M)
        {
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write(M[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void Print(ref int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
        }

        public double Task_1(double S, double A, double N)
        {
            double currentResult = 0.0, pokazatel = 0.0;
            int time = 1;
            while (pokazatel < N)
            {
                if (time % 5 != 0)
                {
                    pokazatel += Math.Sqrt(time);
                    currentResult += pokazatel;
                }
                else
                {
                    currentResult -= S;
                }

                if (time % A == 0 && currentResult != N)
                {
                    pokazatel /= 1.5;
                    currentResult += pokazatel;
                }

                time++;

                if (currentResult < 0)
                {
                    return currentResult;
                }
            }

            return time;
        }
        public double Task_2(double GPU, double RAM, double CPU)
        {
            double gpuLoad = 10.0, ramLoad = 1.0, cpuLoad = 1.0, fps = 200.0;

            while(fps > 20.0)
            {
                if (gpuLoad < GPU)
                {
                    gpuLoad *= 1.1;
                }

                if (ramLoad < RAM)
                {
                    ramLoad *= 2.0;
                }
                else
                {
                    ramLoad /= 1.5;
                    cpuLoad++;
                }

                if (cpuLoad > CPU)
                {
                    cpuLoad = CPU;
                    gpuLoad = GPU;
                }

                fps = (GPU / gpuLoad) * (RAM / ramLoad) * (CPU / cpuLoad);
            }

            return fps;
        }
        public void Task_3(int[,] M)
        {
            if (M == null || M.GetLength(0) == 0 || M.GetLength(1) == 0 || M.GetLength(0) != M.GetLength(1)) return;

            int minElement = int.MaxValue, columnMinElement = -1;
            int n = M.GetLength(0);

            for (int rowIndex = 0; rowIndex < M.GetLength(0); rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < M.GetLength(1); columnIndex++)
                {
                    if (M[rowIndex, columnIndex] > 0)
                    {
                        if (M[rowIndex, columnIndex] < minElement)
                        {
                            minElement = M[rowIndex, columnIndex];
                            columnMinElement = columnIndex;
                        }
                    }
                }
            }

            int midIndex = n / 2;

            for (int rowIndex = 0; rowIndex < midIndex; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < n; columnIndex++)
                {
                    if (columnIndex != columnMinElement)
                    {
                        M[n - 1 - rowIndex, columnIndex] = M[rowIndex, columnIndex];
                    }
                }
            }
        }
        public void Task_4(ref int[] A)
        {
            if (A == null || A.Length == 0) return;

            int minPositiveElement = int.MaxValue, minPositiveElementIndex = -1;

            for (int index = 0; index < A.Length; index++)
            {
                if (A[index] > 0)
                {
                    if (A[index] < minPositiveElement)
                    {
                        minPositiveElement = A[index];
                        minPositiveElementIndex = index;
                    }
                }
            }

            if (minPositiveElementIndex == -1)
            {
                return;
            }

            bool isEven = (minPositiveElement % 2 == 0);

            A = GetArraySequence(A, isEven);

        }
        public int[] GetArraySequence(int[] array, bool isEven)
        {
            int countElements = 0;

            foreach (int element in array)
            {
                if (isEven && element % 2 == 0)
                {
                    countElements++;
                }
                else if (!isEven && element % 2 != 0)
                {
                    countElements++;
                }
            }

            int[] newArray = new int[countElements];
            int index = 0;

            foreach (int element in array)
            {
                if (isEven && element % 2 == 0)
                {
                    newArray[index++] = element;
                }
                else if (!isEven && element % 2 != 0)
                {
                    newArray[index++] = element;
                }
            }

            return newArray;
        }
        public void Task_5(ref int[,] M, ref int[] A, SortArray Op)
        {

        }
        public delegate void SortArray(int[] array);
        public void SortAscending(int[] array) { }
        public void SortDescending(int[] array) { }
        public int[] Concat(int[] array1, int[] array2) { return default(int[]); }

    }
}