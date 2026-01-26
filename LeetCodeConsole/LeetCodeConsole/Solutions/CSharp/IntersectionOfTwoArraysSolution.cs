namespace LeetCodeConsole.Solutions.CSharp
{
    public class IntersectionOfTwoArraysSolution
    {
        public int[] Intersection(int[] nums1, int[] nums2) {

            bool isNums1Longest = false;

            HashSet<int> intersect = new HashSet<int>();

            if (nums1.Length > nums2.Length)
            {
                isNums1Longest = true;
            }

            int length = Math.Min(nums1.Length, nums2.Length);

            for (int i = 0; i < length; i++)
            {
                if(isNums1Longest == true && nums1.Contains(nums2[i]))
                {
                    intersect.Add(nums2[i]);
                }
                else if(isNums1Longest == false && nums2.Contains(nums1[i]))
                {
                    intersect.Add(nums1[i]);
                }
            }

            return intersect.ToArray();
        }
    }
}