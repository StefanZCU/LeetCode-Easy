
using System.Globalization;

public class Solution
{
    public string ThousandSeparator(int n)
    {
        var format = new NumberFormatInfo { NumberGroupSeparator = "." };
        return n.ToString("N0", format);
    }
}