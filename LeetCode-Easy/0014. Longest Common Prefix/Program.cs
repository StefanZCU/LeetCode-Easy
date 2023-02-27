public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        char currentLetter = ' ';
        string commonPrefixes = String.Empty;

        int smallestWord = int.MaxValue;

        for (int j = 0; j < strs.Length; j++)
        {
            if (strs[j].Length <= smallestWord)
            {
                smallestWord = strs[j].Length;
            }
        }

        int counter = 0;
        int checker = 0;

        for (int i = 0; i < strs.Length; i++)
        {

            if (counter >= smallestWord)
            {
                break;
            }

            if (strs[i] == "")
            {
                break;
            }

            currentLetter = (strs[0])[counter];


            if ((strs[i])[counter] == currentLetter)
            {
                checker++;
            }

            if (checker == strs.Length)
            {
                checker = 0;
                counter++;
                commonPrefixes += currentLetter;
                i = -1;
            }
        }

        return commonPrefixes;
    }
}
