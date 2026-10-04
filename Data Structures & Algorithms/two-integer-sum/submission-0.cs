public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    
    int[] c = [0,0];

     for(int i = 0; i < nums.Length; i++)
     {
        for(int j = 0; j < nums.Length; j++)
        {
            if(nums[i] + nums[j] == target && i != j)
            {
                c[0] = i;
                c[1] = j;
                return c;
            }
        }
     }
     return c;

    }
}
