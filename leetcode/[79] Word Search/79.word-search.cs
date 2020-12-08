/*
 * @lc app=leetcode id=79 lang=csharp
 *
 * [79] Word Search
 *
 * https://leetcode.com/problems/word-search/description/
 *
 * algorithms
 * Medium (30.57%)
 * Likes:    1767
 * Dislikes: 86
 * Total Accepted:    286.3K
 * Total Submissions: 912.4K
 * Testcase Example:  '[["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]]\n"ABCCED"'
 *
 * Given a 2D board and a word, find if the word exists in the grid.
 * 
 * The word can be constructed from letters of sequentially adjacent cell,
 * where "adjacent" cells are those horizontally or vertically neighboring. The
 * same letter cell may not be used more than once.
 * 
 * Example:
 * 
 * 
 * board =
 * [
 * ⁠ ['A','B','C','E'],
 * ⁠ ['S','F','C','S'],
 * ⁠ ['A','D','E','E']
 * ]
 * 
 * Given word = "ABCCED", return true.
 * Given word = "SEE", return true.
 * Given word = "ABCB", return false.
 * 
 * 
 */
public class Solution
{
    public bool Exist(char[][] board, string word)
    {
        if (board.Count() == 0)
            return false;
        int[,] visited = new int[board.Count(), board[0].Count()];
        for (int i = 0; i < board.Count(); i++)
        {
            for (int j = 0; j < board[0].Count(); j++)
            {
                if (visited[i, j] == 0 && board[i][j] == word[0])
                {
                    if (Dfs(board, word, i, j, visited, 0))
                        return true;
                }
            }
        }

        return false;
    }

    public bool Dfs(char[][] board, string word, int i, int j, int[,] visited, int k)
    {
        if (k == word.Length)
            return true;

        if (i >= 0 && i < board.Count() && j >= 0 && j < board[0].Count() && board[i][j] == word[k] && visited[i, j] == 0)
        {
            visited[i, j] = 1;
            bool ans =  Dfs(board, word, i + 1, j, visited, k+1)
                || Dfs(board, word, i - 1, j, visited, k+1)
                || Dfs(board, word, i, j + 1, visited, k+1)
                || Dfs(board, word, i, j - 1, visited, k+1);
            visited[i, j] = 0;
            return ans;
        }
        else
        {
            return false;
        }
    }
}

