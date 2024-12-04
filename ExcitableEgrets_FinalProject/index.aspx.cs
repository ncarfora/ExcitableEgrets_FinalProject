/*
# Name: Excitable Egrets
# email: carfornc@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 12/10/2024
# Course: IS 3050
# Semester/Year: Fall 2024
# Brief Description: This project uses asp.net to solves problems from LeetCode to show understanding of asp.net web forms and classes. 
# Citations: ChatGPT
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
            { tbProblemDesription.Text = "Given an integer n, count the total number of digit 1 appearing in all non-negative integers less than or equal to n. For this example, n will equal 13.";
                Problem233Solution problem233 = new Problem233Solution();
                int n = 13;
                int result = problem233.CountDigitOne(n);
                tbSolutionValue.Text = result.ToString();
            }
            
            if (ddlProblems.SelectedValue == "Problem X")
            { tbProblemDesription.Text = ""; }

            if (ddlProblems.SelectedValue == "Problem X")
            { tbProblemDesription.Text = ""; }

            if (ddlProblems.SelectedValue == "Problem X")
            { tbProblemDesription.Text = ""; }



        }
    }
}