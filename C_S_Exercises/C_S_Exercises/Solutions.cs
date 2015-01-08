using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace C_S_Exercises
{
    public class Solutions
    {
        static int maxOfThree(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
        static int sum(int[] toSum)
        {
            int theSum = 0;
            foreach (int i in toSum)
                theSum += i;
            return theSum;
        }
        static int multiply(int[] toMult)
        {
            int answer = 1;
            foreach (int i in toMult)
                answer *= i;
            return answer;
        }
        static int factorial(int num)
        {
            int answer = 1;
            for (int i = num; i > 0; i--)
            {
                answer *= i;
            }
            return answer;
        }
        static bool palindrome(string foo)
        {
            for (int i = 0; i < foo.Length/2-1; i++)
            {
                if (foo[i] != foo[foo.Length - i - 1])
                {
                    return false;
                }
            }
                return true;
        }
        static string fizzBuzz()
        {
            string answer = "";
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    answer += "FizzBuzz\n";
                }
                else if (i % 5 == 0)
                {
                    answer += "Buzz\n";
                }
                else if (i % 3 == 0)
                {
                    answer += "Fizz\n";
                }
                else
                {
                    answer += i + "\n";
                }
            }
            return answer;
        }
    }
}