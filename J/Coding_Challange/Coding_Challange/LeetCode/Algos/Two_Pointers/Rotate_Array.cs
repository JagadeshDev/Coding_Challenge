namespace Coding_Challange.LeetCode.Algos.Two_Pointers
{
    public class Rotate_Array
    {
        public int[]? Rotate(int[] nums, int k)
        {
            //int[] tmp = new int[nums.Length];
            //int magic = nums.Length - k;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (i < k)
            //        tmp[i] = nums[i + magic];
            //    else
            //        tmp[i] = nums[i - k];
            //}
            //nums = tmp;
            //return tmp;
            if (k > nums.Length)
                k = k % nums.Length;
            if (k == 0)
                return null;
            var arr = new int[nums.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (k >= arr.Length)
                    k = 0;
                arr[k] = nums[i];
                k++;
            }
            return arr;
        }
    }
}
