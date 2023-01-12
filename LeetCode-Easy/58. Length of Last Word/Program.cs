public class Solution
{
    public int LengthOfLastWord(string s)
    {
        s = s.TrimEnd();
        int length = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == ' ')
            {
                return length;
            }

            length++;
        }

        return length;
    }
}
