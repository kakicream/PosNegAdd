using System;
using System.Collections.Generic;

namespace PosNegAdd
{
    class MainClass
    {
        static int Solution(int[] absolutes, bool[] signs)
        {
            int answer = 0;

            for (int i = 0; i < absolutes.Length; i++)
            {
                if (signs[i] == true)
                {
                    absolutes[i] *= 1;
                }
                else
                {
                    absolutes[i] *= -1;
                }
            }

            for (int i = 0; i < absolutes.Length; i++)
            {
                answer += absolutes[i];
            }
            return answer;
        }

        // Test
        static int[] abs1 = { 4, 7, 12 };
        static int[] abs2 = { 1, 2, 3 };

        static bool[] sign1 = { true, false, true };
        static bool[] sign2 = { false, false, true };

        public static void Main(string[] args)
        {
            Console.WriteLine(Solution(abs1, sign1));
            Console.WriteLine(Solution(abs2, sign2));            
        }
    }
}
