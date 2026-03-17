public class SearchInsertPositionSolution
{
    public int SearchInsert(int[] nums, int target) 
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        int index = Array.IndexOf(nums, target);

        if (index == -1)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if(target < nums[i])
                {
                    target = nums[i];
                    break;
                }
            }

            index = Array.IndexOf(nums, target);

            if (index == -1)
            {
                index = nums.Length;
            }
        }

        return index;
    }
}
    