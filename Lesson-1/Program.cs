using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        public class TestCase
        {
            public int N { get; set; }
            public bool Expected { get; set; }

        }

        static bool SimpleNumber(int n)
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
                Console.Write($"{n} is Simple = ");
                return true;

            }
            else
            {
                Console.Write($"{n} is Not Simple = ");
                return false;

            }

        }
        static void TestSimpleNumber(TestCase testCase)
        {
            try
            {
                var actual = SimpleNumber(testCase.N);

                if (actual == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");

                }
                else
                {
                    Console.WriteLine("INVALID TEST");

                }
            }
            catch (Exception e)

            {

            }

        }


        static void Main(string[] args)
        {
            var testCase1 = new TestCase()
            {
                N = 6,
                Expected = true

            };

            var testCase2 = new TestCase()
            {
                N = 3,
                Expected = true

            };

            TestSimpleNumber(testCase1);
            TestSimpleNumber(testCase2);

        }
    }
}

