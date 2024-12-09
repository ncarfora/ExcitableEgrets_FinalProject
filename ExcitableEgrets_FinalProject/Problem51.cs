/*
# Name: Excitable Egrets (David Becker)
# email: beckerd8@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 12/10/2024
# Course: IS 3050
# Semester/Year: Fall 2024
# Brief Description: Solution for the N-Queens problem (Problem 51) from LeetCode.
# Citations: ChatGPT (chatgpt.com), LeetCode (leetcode.com)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ExcitableEgrets_FinalProject
{
    /// <summary>
    /// Class containing the solution for the N-Queens problem from LeetCode.
    /// </summary>
    public class NQueens
    {
        /// <summary>
        /// Solves the N-Queens puzzle for a given board size.
        /// </summary>
        /// <param name="n">Size of the chessboard (n x n).</param>
        /// <returns>List of solutions, where each solution is a list of strings representing the board.</returns>
        public List<List<string>> SolveNQueens(int n)
        {
            char[][] board = new char[n][];
            for (int i = 0; i < n; i++)
            {
                board[i] = new char[n];
                for (int j = 0; j < n; j++)
                {
                    board[i][j] = '.';
                }
            }

            List<List<string>> results = new List<List<string>>();
            Solve(0, board, results);
            return results;
        }

        private bool IsValid(char[][] board, int row, int col)
        {
            int n = board.Length;

            // Check for another queen in the same column
            for (int i = 0; i < row; i++)
            {
                if (board[i][col] == 'Q')
                {
                    return false;
                }
            }

            // Check for another queen in the top-left diagonal
            for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i][j] == 'Q')
                {
                    return false;
                }
            }

            // Check for another queen in the top-right diagonal
            for (int i = row - 1, j = col + 1; i >= 0 && j < n; i--, j++)
            {
                if (board[i][j] == 'Q')
                {
                    return false;
                }
            }

            return true;
        }

        private void Solve(int row, char[][] board, List<List<string>> results)
        {
            int n = board.Length;
            if (row == n)
            {
                results.Add(ConstructBoard(board));
                return;
            }

            for (int col = 0; col < n; col++)
            {
                if (IsValid(board, row, col))
                {
                    board[row][col] = 'Q';
                    Solve(row + 1, board, results);
                    board[row][col] = '.';
                }
            }
        }

        private List<string> ConstructBoard(char[][] board)
        {
            List<string> result = new List<string>();
            foreach (var row in board)
            {
                result.Add(new string(row));
            }
            return result;
        }
    }
}
