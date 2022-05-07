public class Solution {
    public void Rotate(int[] nums, int k) {
        if (k != 0 && nums.Length > 1)
    {
        int start = 0;
        int end = nums.Length - (k%nums.Length);
        int[] res = new int[nums.Length];
        for (int i = end; i < nums.Length; i++)
        {
            res[start] = nums[i];
            start++;
        }
        for (int i = 0; i < end; i++)
        {
            res[start] = nums[i];
            start++;
        }

            for (int i = 0; i < nums.Length; i++)
        {
            nums[i]=res[i];
        }
    }
    }
   
}