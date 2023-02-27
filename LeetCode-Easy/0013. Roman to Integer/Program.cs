public class Solution
{
    public int RomanToInt(string s)
    {
        int num = 0;

        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case 'I':

                    num++;
                    if (i == s.Length - 1)
                    {
                        break;
                    }
                    else if (s[i + 1] == 'V')
                    {
                        num--;
                        num += 4;
                        i++;
                    }
                    else if (s[i + 1] == 'X')
                    {
                        num--;
                        num += 9;
                        i++;
                    }

                    break;
                case 'V':

                    num += 5;

                    break;
                case 'X':

                    num += 10;

                    if (i == s.Length - 1)
                    {
                        break;
                    }
                    else if (s[i + 1] == 'L')
                    {
                        num -= 10;
                        num += 40;
                        i++;
                    }
                    else if (s[i + 1] == 'C')
                    {
                        num -= 10;
                        num += 90;
                        i++;
                    }

                    break;
                case 'L':

                    num += 50;

                    break;
                case 'C':

                    num += 100;

                    if (i == s.Length - 1)
                    {
                        break;
                    }
                    else if (s[i + 1] == 'D')
                    {
                        num -= 100;
                        num += 400;
                        i++;
                    }
                    else if (s[i + 1] == 'M')
                    {
                        num -= 100;
                        num += 900;
                        i++;
                    }

                    break;
                case 'D':

                    num += 500;

                    break;
                case 'M':

                    num += 1000;

                    break;
                default:
                    break;
            }
        }

        return num;
    }
}