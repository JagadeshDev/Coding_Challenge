namespace Coding_Challange.LeetCode.Algos.Two_Pointers
{
    public class Squares_Of_Sorted_Array
    {
        public int[] SortedSquares(int[] nums)
        {
            int left = 0, right = nums.Length - 1;
            int[] res = new int[nums.Length];
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
                {
                    res[i] = nums[left] * nums[left];
                    left++;
                }
                else
                {
                    res[i] = nums[right] * nums[right];
                    right--;
                }
            }
            return res;
        }
    }
}
