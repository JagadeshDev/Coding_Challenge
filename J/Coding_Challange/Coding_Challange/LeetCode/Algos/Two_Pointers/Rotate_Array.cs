namespace Coding_Challange.LeetCode.Algos.Two_Pointers
{
    public class Rotate_Array
    {
        public int[] Rotate(int[] nums, int k)
        {
            int[] tmp = new int[nums.Length];
            int magic = nums.Length - k;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i < k)
                    tmp[i] = nums[i + magic];
                else
                    tmp[i] = nums[i - k];
            }
            nums = tmp;
            return tmp;
        }
    }
}
