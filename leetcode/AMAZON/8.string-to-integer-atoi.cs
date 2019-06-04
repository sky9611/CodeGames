/*
 * @lc app=leetcode id=8 lang=csharp
 *
 * [8] String to Integer (atoi)
 */
public class Solution
{
    public int MyAtoi(string str)
    {
        if (string.IsNullOrEmpty(str))
            return 0;

        int start = 0;
        int end = str.Length;
        bool startFound = false;

        for(int i = 0; i < str.Length; i++)
        {
            char c = str[i];
            if (!startFound)
            {
                if (IsDigit(c) || c == '+' || c == '-')
                {
                    start = i;
                    startFound = true;
                }
                else if (c != ' ')
                    return 0;
            }
            else
            {
                if (!IsDigit(c))
                {
                    end = i;
                    break;
                }
            }
        }

        if (!startFound)
            return 0;
        else if(start == str.Length - 1 || start == end-1)
        {
            char c = str[start];
            if (IsDigit(c))
                return Ctoi(c);
            else
                return 0;
        }

        double res = 0;
        for(int i = end-1; i > start; i--)
        {
            if (end-1-i > 9 && str[i] != '0')
                return str[start] == '-' ? Int32.MinValue : Int32.MaxValue;
            int digit = Ctoi(str[i]);
            res += Math.Pow(10, end-1-i) * digit;
            // Console.WriteLine(res);
        }

        char cStart = str[start];
        // Console.WriteLine(cStart); 
        if(IsDigit(cStart))
            res += Math.Pow(10, end-1-start) * Ctoi(str[start]);
        else if (cStart == '-')
            res = -res;

        // Console.WriteLine(res);

        if (res > Int32.MaxValue)
            return Int32.MaxValue;
        if (res < Int32.MinValue)
            return Int32.MinValue;
        
        return (int)res;
    }

    int Ctoi(char c)
    {
        return c - '0';
    }

    bool IsDigit(char c)
    {
        int tmp = Ctoi(c);
        return tmp >= 0 && tmp <= 9;
    }
}

