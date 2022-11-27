public class Solution
{
    public bool IsValid(string s)
    {
        char[] array = s.ToCharArray();
        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == '(' || array[i] == '[' || array[i] == '{')
            {
                stack.Push(array[i]);
                continue;
            }

            if (stack.Count != 0)
            {
                if (array[i] == ')' && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if (array[i] == ']' && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else if (array[i] == '}' && stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        if (stack.Count != 0)
        {
            return false;
        }
        
        return true;
    }
}
