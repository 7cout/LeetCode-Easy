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

            Debug.Assert(solution.IsPalindrome(121) == true);
            Debug.Assert(solution.IsPalindrome(-121) == false);
            Debug.Assert(solution.IsPalindrome(10) == false);

            Debug.Assert(solution.MySqrt(4) == 2);
            Debug.Assert(solution.MySqrt(8) == 2);

            Debug.Assert(solution.IsPalindrome("A man, a plan, a canal: Panama") == true);
            Debug.Assert(solution.IsPalindrome("race a car") == false);
            Debug.Assert(solution.IsPalindrome("") == true);
            Debug.Assert(solution.IsPalindrome("0P") == false);

            Console.WriteLine("Нажмит Enter для завершения работы программы");
            Console.Read();
        }
    }
}
