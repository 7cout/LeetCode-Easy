using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LeetCode_Easy
{
    internal class Programs
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums = { 3, 3 };
            int target = 6;
            int[] answer = { 0, 1 };
            var result = solution.TwoSum(nums, target);
            Console.WriteLine("{0}", String.Join("", result));
            Debug.Assert(answer.SequenceEqual(result));

            nums = new int[2] { 3, 3 };
            target = 6;
            answer = new int[2] { 0, 1 };
            result = solution.TwoSum(nums, target);
            Console.WriteLine("{0}", String.Join("", result));
            Debug.Assert(answer.SequenceEqual(result));

            nums = new int[2] { 3, 3 };
            target = 6;
            answer = new int[2] { 0, 1 };
            result = solution.TwoSum(nums, target);
            Console.WriteLine("{0}", String.Join("", result));
            Debug.Assert(answer.SequenceEqual(result));
            Console.WriteLine("Тесты пройдены!");

            Console.WriteLine("Нажмит Enter для завершения работы программы");
            Console.Read();
        }
    }
}
