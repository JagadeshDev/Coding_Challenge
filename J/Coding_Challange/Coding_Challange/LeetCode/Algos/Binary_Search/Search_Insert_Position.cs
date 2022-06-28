﻿namespace Coding_Challange.LeetCode.Algos.Binary_Search
{
    public class Search_Insert_Position
    {
        public int SearchInsert(int[] nums, int target)
        {
            int start = 0, end = nums.Length - 1, mid = 0;
            while (start <= end)
            {
                mid = start + (end - start) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            return start;
        }
    }
}
