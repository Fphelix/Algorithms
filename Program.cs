using System;

namespace ContainsDuplicate
{
    class Program
    {
        
            static void Main(string[] args)
            {
                int[] nums = { 1, 2, 3, 1 };

            }

            public Boolean containsDuplicate(int[] nums)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (nums[i] == nums[j])

                            return true;

                    }
                }
                return true;
            }
        
    }
}
