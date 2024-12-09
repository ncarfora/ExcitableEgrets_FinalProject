/*
# Name: Excitable Egrets
# email: carfornc@mail.uc.edu, phanpv@mail.uc.edu
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
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExcitableEgrets_FinalProject
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnViewProblem_Click(object sender, EventArgs e)
        {
            if (ddlProblems.SelectedValue == "Problem 233")
            { tbProblemDesription.Text = "Given an integer n, count the total number of digit 1 appearing in all non-negative integers less than or equal to n. A test case in Leetcode ran such that Input: n = 13, Output: 6." +
                    " The constraints are: 0 <= n <= 10^9"+
                    " For this example, n will equal 13.";
                Problem233Solution problem233 = new Problem233Solution();
                int n = 13;
                int result = problem233.CountDigitOne(n);
                tbSolutionValue.Text = result.ToString();
            }
            
            if (ddlProblems.SelectedValue == "Problem 466")
            { tbProblemDesription.Text = "We define str = [s, n] as the string str which consists of the string s concatenated n times." + 
                    " We define that string s1 can be obtained from string s2 if we can remove some characters from s2 such that it becomes s1." +
                    " You are given two strings s1 and s2 and two integers n1 and n2. You have the two strings str1 = [s1, n1] and str2 = [s2, n2]." +
                    " Return the maximum integer m such that str = [str2, m] can be obtained from str1." +
                    " Leetcode provides the example s1 = acb, n1 = 4, s2 = ab, n2 = 2";
                Problem466 problem466 = new Problem466();
                string s1 = "acb";
                int n1 = 4;
                string s2 = "ab";
                int n2 = 2;
                int result = problem466.getMaxRepetitions(s1, n1, s2, n2);
                tbSolutionValue.Text = result.ToString();
            }

            if (ddlProblems.SelectedValue == "Problem 135")
            {
                tbProblemDesription.Text = "There are n children standing in a line. " +
                    "Each child is assigned a rating value given in the integer array ratings. You " +
                    "are giving candies to these children subjected to the following requirements: Each child must have at least " +
                    "one candy. Children with a higher rating get more candies than their neighbors. Return the minimum number of candies you need to " +
                    "have to distribute the candies to the children. For this example, there are three children with ratings of 1, 0, and 2.";

                // Step 1: Define the ratings
                int[] ratings = { 1, 0, 2 };

                // Step 2: Create an instance of the class that contains the Candy method
                Problem135 problem135 = new Problem135();

                // Step 3: Call the Candy method and pass the ratings
                int result = problem135.Candy(ratings);
                tbSolutionValue.Text = result.ToString();
            }


            if (ddlProblems.SelectedValue == "Problem X")
            { tbProblemDesription.Text = ""; }



        }

        protected void tbProblemDesription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}