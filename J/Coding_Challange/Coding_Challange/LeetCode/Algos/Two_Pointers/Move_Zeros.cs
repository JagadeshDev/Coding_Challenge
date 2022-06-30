using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challange.LeetCode.Algos.Two_Pointers
{
    public class Move_Zeros
    {
        public int[] MoveZeroes(int[] nums)
        {
            int len = nums.Length;
            int[] tmp = new int[len];
            
            for (int i = 0,j=0; i < len; i++)
            {
                if (nums[i] == 0)
                {
                    continue;
                }
                else
                {
                    tmp[j] = nums[i];
                    j++;
                }

            }
            return tmp;
        }
    }
}
