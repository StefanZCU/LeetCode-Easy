using System.Text;

public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        int tIndex = 0;

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = tIndex; j < t.Length; j++)
            {
                if (i + 1 > s.Length)
                {
                    if (s[i + 1] == t[j])
                    {
                        return false;
                    }

                    if (s[i] != t[j]) continue;
                    sb.Append(s[i]);
                    tIndex++;
                    break;
                }

                if (s[i] != t[j]) continue;
                sb.Append(s[i]);
                tIndex++;
                break;
            }
        }

        return sb.ToString() == s;
    }
}