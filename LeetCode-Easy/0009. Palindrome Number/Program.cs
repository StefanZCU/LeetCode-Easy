public class Solution
{
    public bool IsPalindrome(int x)
    {
        int counter = 0;
        string num = x.ToString();

        if (num.Length % 2 == 0)
        {
            int half = num.Length / 2;

            for (int i = 0; i < half; i++)
            {
                if (num[i] == num[num.Length - i - 1])
                {
                    counter++;
                }
            }

            if (counter == half)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        else
        {
            int half = num.Length / 2;

            for (int i = 0; i < half; i++)
            {
                if (num[i] == num[num.Length - i - 1])
                {
                    counter++;
                }
            }

            if (counter == half)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}