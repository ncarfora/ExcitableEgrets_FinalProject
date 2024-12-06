/*
# Name: Excitable Egrets
# email: phanpv@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 12/10/2024
# Course: IS 3050
# Semester/Year: Fall 2024
# Brief Description: This project uses asp.net to solves problems from LeetCode to show understanding of asp.net web forms and classes. 
# Citations: ChatGPT (chatgpt.com), LeetCode (leetcode.com), Gemini (gemini.google.com)
# Anything else that's relevant:
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExcitableEgrets_FinalProject
{
    /// <summary>
    /// Class containing the solution for Problem 466 from leetcode.com
    /// </summary>
    public class Problem466
    {
        /// <summary>
        /// Solution for Problem 466 from leetcode.com
        /// </summary>
        /// <param name="s1">String for the value of s1</param>
        /// <param name="n1">Integer for the value of n1</param>
        /// <param name="s2">String for the value of s2</param>
        /// <param name="n2">Integer for the value of n2</param>
        /// <returns>Returns the maximum integer m such that str = [str2, m] can be obtained from str1.</returns>
        public int getMaxRepetitions(string s1, int n1, string s2, int n2)
        {
            // Initialize pointers and counters:
            // - idx1: Index pointer for s1
            // - idx2: Index pointer for s2
            // - count1: Tracks the number of times we've fully iterated through s1
            // - count2: Tracks the number of times we've fully iterated through s2
            int idx1 = 0, idx2 = 0, count1 = 0, count2 = 0;

            // Iterate through s1 n1 times
            while (count1 < n1)
            {
                // If the current characters in s1 and s2 match
                if (s1[idx1] == s2[idx2])
                {
                    // Increment both pointers
                    idx1++;
                    idx2++;

                    // If we've reached the end of s2, reset the pointer and increment the s2 count
                    if (idx2 == s2.Length)
                    {
                        idx2 = 0;
                        count2++;
                    }
                }
                else
                {
                    // If characters don't match, move to the next character in s1
                    idx1++;
                }

                // If we've reached the end of s1, reset the pointer and increment the s1 count
                if (idx1 == s1.Length)
                {
                    idx1 = 0;
                    count1++;
                }
            }

            // Calculate the maximum repetitions of s2 in s1 * n1
            return count2 / n2;
        }
    }
}