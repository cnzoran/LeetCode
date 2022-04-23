using System;
using System.Collections;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/word-search/
    public class _79_单词搜索
    {
        int[][] direction = new int[][] {
            new int[] {0, 1},
            new int[] {1, 0},
            new int[] {0, -1},
            new int[] {-1, 0}
        };
        public bool Exist(char[][] board, string word)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    bool[,] vis = new bool[board.Length, board[0].Length];
                    if (DFS(board, word, vis, i, j))
                        return true;
                }
            }

            return false;
        }

        private bool DFS(char[][] board, string word, bool[,] vis, int i, int j)
        {
            return false;
        }

        public void Test()
        {

        }
    }
}