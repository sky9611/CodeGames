/*
 * @lc app=leetcode id=17 lang=csharp
 *
 * [17] Letter Combinations of a Phone Number
 */
public class Solution
{
    // private readonly Dictionary<char, List<string>> map = new Dictionary<char, List<string>>()
    // {
    //     {'2', new List<string>(){"a", "b", "c"}},
    //     {'3', new List<string>(){"d", "e", "f"}},
    //     {'4', new List<string>(){"g", "h", "i"}},
    //     {'5', new List<string>(){"j", "k", "l"}},
    //     {'6', new List<string>(){"m", "n", "o"}},
    //     {'7', new List<string>(){"p", "q", "r", "s"}},
    //     {'8', new List<string>(){"t", "u", "v"}},
    //     {'9', new List<string>(){"w", "x", "y", "z"}}
    // };

    private readonly string[] map = new string[8]{"abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};

    public IList<string> LetterCombinations(string digits)
    {
        if(string.IsNullOrEmpty(digits) || digits.Contains("1"))
            return new List<string>();
        
        IList<string> res = new List<string>();
        foreach(char c in digits)
        {
            string tmp = map[c - '2'];
            if(res.Count() == 0)
                res = tmp.ToArray().Select(i => i.ToString()).ToList();
            else
                res = CollectionMultiplication(res, tmp);
        }
        return res;
    }

    public IList<string> CollectionMultiplication(IList<string> x, string y)
    {
        IList<string> res = new List<string>();
        foreach(var ix in x)
        {
            foreach(var iy in y)
            {
                res.Add(ix + iy);
            }
        }
        return res;
    }

    // public IList<string> CollectionMultiplication(IList<string> x, IList<string> y)
    // {
    //     IList<string> res = new List<string>();
    //     foreach(var ix in x)
    //     {
    //         foreach(var iy in y)
    //         {
    //             res.Add(ix + iy);
    //         }
    //     }
    //     return res;
    // }
}

