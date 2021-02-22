using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWorkAl1_3
{
    class Program
    {
        class TestCase
        {
            public int InputA { get; set; }
            public int Expected { get; set; }
        }
        static void Main(string[] args)
        {
            var testData = new TestCase[6];

            testData[0] = new TestCase()
            { InputA = 0, Expected = 0 };
            testData[1] = new TestCase()
            { InputA = 1, Expected = 1 };
            testData[2] = new TestCase()
            { InputA = 2, Expected = 1 };
            testData[3] = new TestCase()
            { InputA = 3, Expected = 2 };
            testData[4] = new TestCase()
            { InputA = 15, Expected = 610 };
            testData[5] = new TestCase()
            { InputA = -1, Expected = Timeout.Infinite };

            Console.WriteLine("Проверка Рекурсии:");
            foreach (var testCase in testData)
            {
                var resultRec = FibonachiRec(testCase.InputA);
                var correct = resultRec == testCase.Expected;
                Console.WriteLine($"На входе {testCase.InputA}, ожидаем (Expected) {testCase.Expected} .Программа выводит {resultRec}. Ответ - {correct}");
            }
            Console.WriteLine("Проверка Цикла:");
            foreach (var testCase in testData)
            {
                var resultCycle = FibonacciCycle(testCase.InputA);
                var correct = resultCycle == testCase.Expected;
                Console.WriteLine($"На входе {testCase.InputA}, ожидаем (Expected) {testCase.Expected} .Программа выводит {resultCycle}. Ответ - {correct}");
            }
            Console.ReadKey();
        }
        static int FibonachiRec(int n)
        {
            if (n < 0) return Timeout.Infinite;
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return FibonachiRec(n - 1) + FibonachiRec(n - 2);
            }
        }
        static int FibonacciCycle(int n)
        {
            if (n < 0) return Timeout.Infinite;
            int a = 0;
            int b = 1;
            int tmp;

            for (int i = 0; i < n; i++)
            {
                tmp = a;
                a = b;
                b += tmp;
            }

            return a;
        }
    }
}
