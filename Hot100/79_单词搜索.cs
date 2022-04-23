using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    internal class _79_单词搜索
    {
        int[][] direction = new int[][]
        {
            new int[]{-1,0},
            new int[]{0, 1},
            new int[]{1, 0},
            new int[]{0, -1}
        };

        public bool Exist(char[][] board, string word)
        {
            if (board == null || board.Length == 0 || board[0].Length == 0)
                return false;

            bool[,] visited = new bool[board.Length, board[0].Length];
            
            for (int m = 0; m < board.Length; m++)
            {
                for (int n = 0; n < board[0].Length; n++)
                {
                    if (DFS(m, n, board, word, "", visited))
                        return true;
                }
            }

            return false;
        }

        private bool DFS(int m, int n, char[][] board, string word, string str, bool[,] visited)
        {            
            str += board[m][n];

            if (str.Length == word.Length)
                return str.Equals(word);

            visited[m, n] = true;
            for (int i = 0; i < direction.Length; i++)
            {
                int x = m + direction[i][0];
                int y = n + direction[i][1];
                if (x >= 0 && x < board.Length && y >= 0 && y < board[0].Length && board[x][y] == word[str.Length])
                {
                    if (!visited[x, y])
                    {
                        if (DFS(x, y, board, word, str, visited))
                            return true;
                    }
                }
            }
            visited[m, n] = false;

            return false;
        }

        public void Test()
        {

            //char[][] board = new char[][]
            //{
            //    new char[]{'A','B','C','E'},
            //    new char[]{'S','F','C','S'},
            //    new char[]{'A','D','E','E'}
            //};
            //bool ans = Exist(board, "ABCCED");

            char[][] board = new char[][] { new char[] { 'a', 'b' }, new char[] { 'c', 'd' } };
            bool ans = Exist(board, "cdbad");
            Console.WriteLine(ans); 
        }
    }
}
