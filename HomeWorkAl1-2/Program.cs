using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAl1_2
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static int StrangeSum(int[] inputArray) // общая сложность - O(N^3)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++) // O(N * N * N) 
            {
                for (int j = 0; j < inputArray.Length; j++) // O(N * N)
                {
                    for (int k = 0; k < inputArray.Length; k++) // O(N)
                    {
                        int y = 0; // O(1) константа

                        if (j != 0) // O(1) константа
                        {
                            y = k / j;
                        }

                        sum += inputArray[i] + i + k + j + y; // O(1) константа
                    }
                }
            }

            return sum;
        }

    }
}
