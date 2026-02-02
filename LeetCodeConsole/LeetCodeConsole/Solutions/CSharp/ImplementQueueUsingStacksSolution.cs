namespace LeetCodeConsole.Solutions.CSharp
{
    public class ImplementQueueUsingStacksSolution
    {
        Stack<int> stackIn;
        Stack<int> stackOut;

        public ImplementQueueUsingStacksSolution()
        {
            this.stackIn = new Stack<int>();
            this.stackOut = new Stack<int>();
        }

        public void Push(int x)
        {
            stackIn.Push(x);
        }

        public int Pop()
        {
            ReverseStackIfNeeded();
            return stackOut.Pop();
        }

        public int Peek()
        {
            ReverseStackIfNeeded();
            return stackOut.Peek();
        }

        public bool Empty()
        {
            return stackIn.Count == 0 && stackOut.Count == 0;
        }

        public void ReverseStackIfNeeded()
        {
            if (stackOut.Count == 0)
            {
                while (stackIn.Count() > 0)
                {
                    stackOut.Push(stackIn.Pop());
                }
            }
        }
    }
}
