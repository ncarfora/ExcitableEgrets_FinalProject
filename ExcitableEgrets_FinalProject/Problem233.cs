
/*
# Name: Excitable Egrets
# email: carfornc@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 12/10/2024
# Course: IS 3050
# Semester/Year: Fall 2024
# Brief Description: This project uses asp.net to solves problems from LeetCode to show understanding of asp.net web forms and classes. 
# Citations: ChatGPT (chatgpt.com)
# Anything else that's relevant:
*/using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExcitableEgrets_FinalProject
{
    /// <summary>
    /// Class containing the solution for Problem 233 from leetcode.com
    /// </summary>
    public class Problem233Solution
    {
        /// <summary>
        /// Solution for problem 233 from leetcode.com
        /// </summary>
        /// <param name="n">Accepts an integer input for the value of "n"</param>
        /// <returns>Returns count of the total number of digit 1 appearing in all non-negative integers less than or equal to n.</returns>
        public int CountDigitOne(int n)
        {
            int count = 0;
            long factor = 1; // Represents the current digit's place (1s, 10s, 100s, etc.)

            while (n / factor > 0)
            {
                long lower = n - (n / factor) * factor; // Digits below the current digit
                long current = (n / factor) % 10;       // The current digit
                long higher = n / (factor * 10);       // Digits above the current digit

                // If the current digit is 0, the count is determined by the higher digits
                if (current == 0)
                {
                    count += (int)(higher * factor);
                }
                // If the current digit is 1, count includes higher digits and lower digits
                else if (current == 1)
                {
                    count += (int)(higher * factor + lower + 1);
                }
                // If the current digit is greater than 1, count includes higher digits + 1
                else
                {
                    count += (int)((higher + 1) * factor);
                }

                factor *= 10; // Move to the next digit place
            }

            return count;
        }
    }
}