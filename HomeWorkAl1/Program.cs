using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAl1
{
    class Program
    {
        class TestCase
        {
            public int InputA { get; set; }
            public string Expected { get; set; }
        }
        static void Main(string[] args)
        {
            var testData = new TestCase[4];

            testData[0] = new TestCase()
            { InputA = 2, Expected = "Простое" };
            testData[1] = new TestCase()
            { InputA = 4, Expected = "Не простое" };
            testData[2] = new TestCase()
            { InputA = 11, Expected = "Простое" };
            testData[3] = new TestCase()
            { InputA = 15, Expected = "Не простое" };

            foreach (var testCase in testData)
            {
                var result = NumberCheck(testCase.InputA);
                var correct = result == testCase.Expected;
                Console.WriteLine($"Число {testCase.InputA} - {result}, Expected {testCase.Expected}. Ответ - {correct}");
            }
            Console.ReadKey();
        }

        static string NumberCheck(int n)
        {
            int d = 0;
            int i = 2;

            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                    i++;
                }
                else
                {
                    i++;
                }
            }
            if (d == 0)
            {
                return "Простое";
            }
            else
            {
                return "Не простое";
            }

        }
    }
}
