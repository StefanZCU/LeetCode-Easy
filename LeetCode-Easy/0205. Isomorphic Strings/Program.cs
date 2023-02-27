public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length == 0)
        {
            return true;
        }

        var listS = new List<char>();
        var listT = new List<char>();

        for (int i = 0; i < s.Length; i++)
        {
            var indexS = listS.IndexOf(s[i]);
            var indexT = listT.IndexOf(t[i]);

            if (indexS != indexT)
            {
                return false;
            }
            if (indexS < 0)
            {
                listS.Add(s[i]);
            }
            if (indexT < 0)
            {
                listT.Add(t[i]);
            }
        }

        return true;
    }
}