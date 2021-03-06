namespace Coding_Challange.LeetCode.Algos.Binary_Search
{
    public class Binary_Search
    {
        public int Search(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1, pivot;
            while (left <= right)
            {
                pivot = left + (right - left) / 2;
                if (nums[pivot] == target)
                    return pivot;
                if (target < nums[pivot])
                    right = pivot - 1;
                else
                    left = pivot + 1;
            }
            return -1;
        }
    }
}
