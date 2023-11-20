using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Easy
{
    internal class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int a = target - nums[i];
                if (dic.ContainsKey(a))
                {
                    return new int[] { dic[a], i };
                }
                dic[nums[i]] = i;
            }
            return new int[] { };
        }

        public int[] TwoSum_bad(int[] nums, int target)
        {
            int indexLeft = 0;
            int indexRight = 1;
            int[] indices = new int[2];
            for (indexLeft = 0; indexLeft <= nums.Length - 2; indexLeft++)
            {
                for (indexRight = indexLeft + 1; indexRight <= nums.Length - 1; indexRight++)
                {
                    if (nums[indexLeft] + nums[indexRight] == target)
                    {
                        indices[0] = indexLeft;
                        indices[1] = indexRight;
                        return indices;
                    }
                }
            }
            return indices;
        }
    }
}
