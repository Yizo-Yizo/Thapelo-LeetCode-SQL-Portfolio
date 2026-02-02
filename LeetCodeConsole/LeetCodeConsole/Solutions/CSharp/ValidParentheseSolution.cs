namespace LeetCodeConsole.Solutions.CSharp
{
    public class ValidParentheseSolution
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> pairs = new Dictionary<char, char>()
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0 || stack.Pop() != pairs[c])
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
