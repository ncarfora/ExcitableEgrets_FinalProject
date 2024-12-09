/*
# Name: Excitable Egrets (Michael Slivinski)
# email: slivinmb@mail.uc.edu
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
    /// Class containing the solution for Problem 135 from leetcode.com
    /// </summary>
    public class Problem135
    {
        public int Candy(int[] ratings)
        {
            int n = ratings.Length;
            int[] candies = new int[n];

            // Step 1: Give each child at least one candy
            for (int i = 0; i < n; i++)
            {
                candies[i] = 1;
            }

            // Step 2: Left to right pass
            for (int i = 1; i < n; i++)
            {
                if (ratings[i] > ratings[i - 1])
                {
                    candies[i] = candies[i - 1] + 1;
                }
            }

            // Step 3: Right to left pass
            for (int i = n - 2; i >= 0; i--)
            {
                if (ratings[i] > ratings[i + 1])
                {
                    candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
                }
            }

            // Step 4: Calculate the total candies required
            int totalCandies = 0;
            foreach (int candy in candies)
            {
                totalCandies += candy;
            }

            return totalCandies;
        }
    }
}