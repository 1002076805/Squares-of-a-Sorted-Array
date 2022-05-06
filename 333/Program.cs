using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares_of_a_Sorted_Array
{

    class Program
    {

        public static void Main(string[] args)
        {

            int[] nums = { 3, 2, 4, 6, 9 };

            SortedSquares(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("nums " + nums[i]);
            }


        }

        public static int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] *= nums[i];
            }

            Array.Sort(nums);
           
            

            return nums;
        }






    }

}
