public class Solution {
    public int[] SortedSquares(int[] nums) {
        nums = SquareArr(nums);
        Array.Sort(nums);
        return nums;
    }
    int[] SquareArr(int []nums)
    {
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] *= nums[i];
    }
    return nums;
}
}