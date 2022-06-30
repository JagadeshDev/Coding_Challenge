namespace Coding_Challange.LeetCode.Algos.Two_Pointers
{
    public class Two_Sum_II_Input_Array_Is_Sorted
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int[] output = new int[2];

            int start = 0, len = numbers.Length - 1, end = len;
            for (int i = 0; i <= len; i++)
            {
                int sum = (numbers[start] + numbers[end]);

                if (sum > target)
                {
                    end--;
                    continue;
                }
                else if (sum < target)
                {
                    start++;
                    continue;
                }

                else
                {
                    output[0] = start + 1;
                    output[1] = end + 1;
                    break;
                }
            }
            return output;
        }
    }
}
