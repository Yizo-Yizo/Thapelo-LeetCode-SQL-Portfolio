namespace LeetCodeConsole.Solutions.CSharp
{
    public class TwoSumInputArrayIsSortedSolution
    {
   public int[] TwoSum(int[] numbers, int target) {
        
        int[] indecies = new int[2];
        int index = 0;
        int leftIndex = 0;
        int rightIndex = numbers.Length-1;
        int sum = numbers[leftIndex] + numbers[rightIndex];

        while(sum != target && index != numbers.Length-1)
        {
            if (sum < target)
            {
                leftIndex++;
            }
            else if (sum > target)
            {
                rightIndex--;
            }

            sum = numbers[rightIndex] + numbers[leftIndex];
        }

        indecies[0] = leftIndex+1;
        indecies[1] = rightIndex+1;

        return indecies;
    }
    }
}