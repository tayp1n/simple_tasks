/*1. If you write down all natural numbers less than 10 that are multiples of 3 or 5, then
we get 3, 5, 6 and 9. The sum of these numbers is 23.
Find the sum of all numbers less than 1000 that are multiples of 3 or 5.
2. Each next element of the Fibonacci series is obtained by adding
the two previous ones. Starting from 1 and 2, the first 10 elements will be:
1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
Find the sum of all even elements of the Fibonacci series that are not
exceed four million.
3. The prime divisors of 13195 are 5, 7, 13 and 29.
What is the largest divisor of 600851475143 which is
prime number?
4. Palindrome number on both sides (right to left and left to right)
reads the same. The largest palindrome number obtained
by multiplying two two-digit numbers - 9009 \u003d 91 × 99.
Find the largest palindrome obtained by multiplying two
three-digit numbers.
5. 2520 is the smallest number that can be divided without a remainder by everything
numbers from 1 to 10.
What is the smallest number that is evenly divisible by all numbers from 1 to 20?*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyProjC
{
    class Program
    {
        
        //public static long divd(long N, long start)
        //{
        //    for (long i = start; i * i <= N; i += 2)
        //    {
        //        if (N % i == 0) return i;
        //    }
        //    return N;
        //}
        static void Main(string[] args)
        {
            //1
            //int sum = 0;
            //for(int i = 0; i <1000; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        sum += i;
            //    }
            //    else if(i % 5 == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);
            //2
            //ulong q = 1;
            //ulong i = 1;
            //ulong w = 0;
            //ulong res = 0;
            //for(int count = 1; count <=4000000; count++)
            //{
            //    w = q + i;
            //    q = i;
            //    i = w;
            //    if(w % 2 == 0)
            //    {
            //        res += i;
            //    }
            //}
            //Console.WriteLine(res);
            //3
            //long N = 15;
            //long start = 3;

            //while (N % 2 == 0)
            //{
            //    N /= 2;
            //}

            //while (N > 1)
            //{
            //    start = divd(N, start);
            //    N /= start;

            //}
            //Console.WriteLine(start);
            //4

            //int maximum = 0;
            //for (int i = 900; i < 1000; i++)
            //{
            //    for (int j = 900; j < 1000; j++)
            //    {
            //        int c = i * j;
            //        string s = c.ToString();
            //        char[] charArr = s.ToCharArray();
            //        char[] charArrRev = s.ToCharArray();
            //        Array.Reverse(charArrRev);

            //        if (charArr.SequenceEqual(charArrRev) == true)
            //        {
            //            maximum = Int32.Parse(s);
            //        }
            //    }
            //}
            //Console.WriteLine(maximum);


            //5
            //int i = 2520;
            //bool c = false;
            //int[] nums = new int[15] { 3, 4, 6, 7, 8, 9, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            //while (c == false)
            //{
            //    //string str = Convert.ToString(i);
            //    for(int j = 0; j < nums.Length; j++)
            //    {
            //        if (i % nums[j] == 0)
            //        {
            //            c = true;
            //            continue;
            //        }
            //        else
            //        {
            //            c = false;
            //            break;
            //        }
            //    }
            //    i += 10;
            //}
            //Console.WriteLine(i-10);

        }
        
    }
}
