namespace LeetCodeConsole.Solutions.CSharp
{
    public class FibonacciNumberSolution
    {
        public int Fib(int n) {

            if (n > 1)
            {
                n--;
                int firstNumb = Fib(n);
                int secondNumb = Fib(n-1);
                return firstNumb + secondNumb;
            }
            return n;
        }
    }
}
