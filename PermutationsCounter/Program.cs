using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace PermutationsCounter
{
    class Program
    {

        static int MAX_CHAR = 52;

        static void Main(string[] args)
        {
            // String to hold incoming input.
            string input;

            // Do this while input is Not null/empty.
            while ((input = Console.ReadLine()) != null)
            {
                Console.WriteLine(CountDistinctPermutations(input));
            }
        }

        // Utility function to find factorial of n. 
        static BigInteger Factorial(BigInteger n)
        {
            BigInteger fact = 1;
            for (BigInteger i = 2; i <= n; i++)
                fact = fact * i;

            return fact;
        }

        /// Returns count of distinct permutations 
        /// of string. 
        static BigInteger CountDistinctPermutations(string str)
        {
            BigInteger length = Convert.ToUInt64(str.Length);

            BigInteger[] freq = new BigInteger[MAX_CHAR];

            /// finding frequency of all the lower case 
            /// alphabet and storing them in array of 
            /// integer 

            for (int i = 0; i < length; i++)
                if (str[i] >= 'a')
                {
                    freq[str[i] - 'a']++;
                };

            /// finding factorial of number of appearances 
            /// and multiplying them since they are 
            /// repeating alphabets 
            BigInteger fact = 1;
            for (int i = 0; i < MAX_CHAR; i++)
                fact = fact * Factorial(freq[i]);

            /// finding factorial of size of string and 
            /// dividing it by factorial found after 
            /// multiplying 
            return Factorial(length) / fact;
        }


    }
}
